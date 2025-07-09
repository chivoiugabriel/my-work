const map = L.map('map').setView([45.0, 25.0], 6);

L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
  attribution: '&copy; OpenStreetMap contributors'
}).addTo(map);

let heatLayer = L.heatLayer([], { radius: 25 }).addTo(map);
let markers = {};
let paths = {};
let allData = [];

function getColorByAltitude(alt) {
  if (alt < 5000) return "green";
  if (alt < 15000) return "orange";
  return "red";
}

function rotatedIcon(angle, color) {
  return L.divIcon({
    html: `<div style="transform: rotate(${angle-90}deg); color: ${color}; font-size: 24px;">✈</div>`,
    className: "",
    iconSize: [24, 24]
  });
}

function updateMarkers(data) {
  const latestByIcao = {};
  data.forEach(ac => {
    latestByIcao[ac.ICAO] = ac;
  });

  heatLayer.setLatLngs([]);
  Object.keys(markers).forEach(key => map.removeLayer(markers[key]));
  Object.keys(paths).forEach(key => map.removeLayer(paths[key]));
  markers = {};
  paths = {};

  data.forEach(ac => {
    const key = ac.ICAO;
    const latlng = [ac.Latitude, ac.Longitude];

    if (!paths[key]) {
      paths[key] = L.polyline([], { color: getColorByAltitude(ac.Altitude), weight: 2 }).addTo(map);
    }
    paths[key].addLatLng(latlng);
    heatLayer.addLatLng(latlng);
  });

  for (const key in latestByIcao) {
    const ac = latestByIcao[key];
    const latlng = [ac.Latitude, ac.Longitude];
    const color = getColorByAltitude(ac.Altitude);
    const icon = rotatedIcon(ac.Heading || 0, color);
    markers[key] = L.marker(latlng, { icon }).addTo(map)
      .bindPopup(`${key}<br>Alt: ${ac.Altitude} ft<br>Spd: ${ac.Speed} kt`);
  }
}

function updateTable(data) {
  const tbody = document.querySelector("#plane-table tbody");
  tbody.innerHTML = "";
  const seen = new Set();
  data.reverse().forEach(ac => {
    if (seen.has(ac.ICAO)) return;
    seen.add(ac.ICAO);
    const row = document.createElement("tr");
    row.innerHTML = `
      <td>${ac.ICAO}</td>
      <td>${ac.Latitude.toFixed(4)}</td>
      <td>${ac.Longitude.toFixed(4)}</td>
      <td>${ac.Altitude}</td>
      <td>${ac.Speed}</td>
    `;
    tbody.appendChild(row);
  });
}

function applyFilters() {
  const icaoFilter = document.getElementById("search-icao").value.trim().toUpperCase();
  const sortOrder = document.getElementById("sort-alt").value;

  let filtered = allData.filter(ac => !icaoFilter || ac.ICAO.includes(icaoFilter));

  if (sortOrder === "asc") {
    filtered.sort((a, b) => a.Altitude - b.Altitude);
  } else if (sortOrder === "desc") {
    filtered.sort((a, b) => b.Altitude - a.Altitude);
  }

  updateMarkers(filtered);
  updateTable(filtered);
}

function fetchAndDisplay() {
  fetch('/data')
    .then(res => res.json())
    .then(data => {
      allData = data;
      applyFilters();
    })
    .catch(err => console.error("Eroare date:", err));
}

setInterval(fetchAndDisplay, 2000);

import folium
import serial

# Funcție pentru a extrage coordonatele din propozițiile NMEA
def extrage_coordnate(line):
    if line.startswith("$GPGGA") or line.startswith("$GPGLL") or line.startswith("$GPRMC"):
        fields = line.split(",")
        if fields[2] and fields[4]:  # Verifică dacă latitudinea și longitudinea există
            # Conversia coordonatelor în format decimal
            lat = float(fields[2]) / 100
            lon = float(fields[4]) / 100
            lat_deg = int(lat)
            lon_deg = int(lon)
            lat_min = (lat - lat_deg) * 100
            lon_min = (lon - lon_deg) * 100
            lat_decimal = lat_deg + lat_min / 60
            lon_decimal = lon_deg + lon_min / 60

            # Corectează direcția (N/S, E/W)
            if fields[3] == "S":
                lat_decimal = -lat_decimal
            if fields[5] == "W":
                lon_decimal = -lon_decimal

            return lat_decimal, lon_decimal
    return None, None

# Configurare port serial
ser = serial.Serial('COM3', 9600, timeout=1)  # Înlocuiește 'COM3' cu portul tău

while True:
    try:
        # Citește linia brută de la portul serial
        raw_line = ser.readline()
        line = raw_line.decode('latin-1').strip()  # Decodifică linia

        # Extrage coordonatele din linia curentă
        lat, lon = extrage_coordnate(line)
        if lat and lon:
            print(f"Coordonate valide: Latitudine = {lat}, Longitudine = {lon}")

            # Creează harta centrată pe coordonatele date
            harta = folium.Map(location=[lat, lon], zoom_start=15)

            # Adaugă un marker pe hartă
            folium.Marker(
                [lat, lon],
                popup=f"Lat: {lat}, Lon: {lon}",
                tooltip="Locație GPS"
            ).add_to(harta)

            # Salvează harta într-un fișier HTML
            harta.save("harta.html")
            print("Harta a fost generată și salvată ca 'harta.html'. Deschide acest fișier într-un browser!")
            break  # Ieși din buclă după ce salvezi harta

    except Exception as e:
        print(f"Eroare: {e}")

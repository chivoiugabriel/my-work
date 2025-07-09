import sqlite3
import time
from datetime import datetime

conn = sqlite3.connect("adsb_data.db")
cursor = conn.cursor()
cursor.execute('''
CREATE TABLE IF NOT EXISTS messages (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    timestamp TEXT,
    icao TEXT,
    lat REAL,
    lon REAL,
    alt INTEGER,
    spd INTEGER,
    hdg INTEGER
)
''')
conn.commit()

mesaje = [
 # Aproape de Ploiești
    "A1B2C3,44.9500,26.0100,11000,450,270",

    # La vest de București, spre Alexandria
    "B2C3D4,44.2000,25.3000,11500,460,265",

    # Nord-Est, spre Buzău
    "C3D4E5,45.1500,26.8000,12000,440,280",

    # Sud, aproape de Giurgiu
    "D4E5F6,43.9500,25.9500,11300,455,250",

    # Est, spre Slobozia
    "E5F6G7,44.6300,27.3700,11800,470,275",

]

while True:
    for line in mesaje:
        parts = line.strip().split(',')
        if len(parts) >= 6:
            icao, lat, lon, alt, spd, hdg = parts[:6]
            cursor.execute('''
                INSERT INTO messages (timestamp, icao, lat, lon, alt, spd, hdg)
                VALUES (?, ?, ?, ?, ?, ?, ?)
            ''', (datetime.utcnow().isoformat(), icao, float(lat), float(lon), int(alt), int(spd), int(hdg)))
            conn.commit()
            print(f"Simulat: {icao} @ {lat}, {lon}, {alt} ft, {spd} kt, HDG {hdg}")
            time.sleep(2)

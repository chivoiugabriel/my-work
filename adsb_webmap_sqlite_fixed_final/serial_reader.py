import serial
import sqlite3
import time
from datetime import datetime

ser = serial.Serial(port='COM4', baudrate=115200, timeout=1)

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

while True:
    try:
        line = ser.readline().decode().strip()
        parts = line.split(',')
        if len(parts) >= 6:
            icao, lat, lon, alt, spd, hdg = parts[:6]
            cursor.execute('''
                INSERT INTO messages (timestamp, icao, lat, lon, alt, spd, hdg)
                VALUES (?, ?, ?, ?, ?, ?, ?)
            ''', (datetime.utcnow().isoformat(), icao, float(lat), float(lon), int(alt), int(spd), int(hdg)))
            conn.commit()
            print(f"Salvat: {icao} @ {lat}, {lon}, {alt} ft, {spd} kt, HDG {hdg}")
    except Exception as e:
        print("Eroare:", e)
        time.sleep(1)

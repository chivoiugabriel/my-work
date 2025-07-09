from flask import Flask, render_template, jsonify
import sqlite3

app = Flask(__name__)

def get_latest_messages(limit=10):
    conn = sqlite3.connect("adsb_data.db")
    cursor = conn.cursor()
    cursor.execute("SELECT icao, lat, lon, alt, spd, hdg FROM messages ORDER BY timestamp DESC LIMIT ?", (limit,))
    rows = cursor.fetchall()
    conn.close()
    return [
        {"ICAO": row[0], "Latitude": row[1], "Longitude": row[2], "Altitude": row[3], "Speed": row[4], "Heading": row[5]}
        for row in rows
    ]

@app.route('/')
def index():
    return render_template("index.html")

@app.route('/data')
def data():
    return jsonify(get_latest_messages())

if __name__ == '__main__':
    app.run(debug=True)

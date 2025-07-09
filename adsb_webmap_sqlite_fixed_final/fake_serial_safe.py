import serial
import time

port_name = 'COM4'
baudrate = 115200

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

class FakeSerial:
    def write(self, data):
        print("Simulare trimis:", data.decode().strip())

try:
    ser = serial.Serial(port_name, baudrate)
    print(f"✔ Port serial deschis: {port_name}")
except serial.SerialException:
    print(f"⚠ Portul {port_name} nu a fost găsit. Se rulează în mod simulare.")
    ser = FakeSerial()

while True:
    for linie in mesaje:
        ser.write((linie + '\n').encode())
        time.sleep(2)

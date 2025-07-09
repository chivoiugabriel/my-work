import serial

try:
    # Deschide portul serial
    ser = serial.Serial('COM3', 9600, timeout=1)  # Înlocuiește COM3 cu portul corect
    print("Portul a fost deschis cu succes!")
    
    while True:
        try:
            # Citește linia brută de la portul serial
            raw_line = ser.readline()
            print(f"Date brute: {raw_line}")  # Afișează datele brute
            
            # Decodifică linia în format text
            line = raw_line.decode('latin-1').strip()
            print(f"Date decodificate: {line}")  # Afișează linia decodificată
            
            # Procesare linie, dacă începe cu $GPGGA sau alt prefix relevant
            if line.startswith("$GPGGA"):
                print(f"Propoziție NMEA validă: {line}")
        except UnicodeDecodeError as e:
            print(f"Eroare la decodare: {e}")
except serial.SerialException as e:
    print(f"Eroare la deschiderea portului: {e}")

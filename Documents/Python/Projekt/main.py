
import datetime
import serial #TODO: pip install pyserial
from serial.tools import list_ports

class Steinhart:
    a = 0.0011212735580564
    b = 0.000235338520425013
    c = 8.3442490007E-08
    
    def ohm_to_celsius(ohm):
        return ohm

class Atlas:
    def __init__(self, port_name):
        self.port = serial.Serial(port_name, timeout=1, baudrate=250000, dsrdtr=True)

    def read_ohms(self):
        self.port.write(b'r')
        lines = []
        while True:
            line = self.port.readline().decode().strip()
            print(line)
            if line == 'r':  # Ha az üzenet 'r'
                break  # Kilépés a ciklusból
            lines.append(line.replace(',', '.'))

        for _ in range(4):
            lines.append(self.port.readline().decode().strip().replace(',', '.'))

        ohms_from_bytes = []
        ohm_from_byte = 262140
        while True:
            byte1 = self.port.read()
            byte2 = self.port.read()

            # Bájtokból értékek kiszámítása
            ohm_from_byte = int.from_bytes(byte2 + byte1, byteorder='little', signed=False) * 4
            if ohm_from_byte != 262140:
                ohms_from_bytes.append(ohm_from_byte)
            else:
                break
        return ohms_from_bytes
    
    def read_celsius(self):
        ohms = self.read_ohms()
        op = []
        for ohm in ohms:
            op.append(self.ohm_to_celsius(ohm))
        return op

    def ohm_to_celsius(ohm):
        return ohm

ports = list_ports.comports()
driver = Atlas(ports[1].name)
ohms = driver.read_ohms()
print(len(ohms))

class Diák:
    osztályszintű_adattag = "asda"

    def __init__(self, név: str, születés_évszám: int) -> None:
        self.név = név
        self.kor = 2024 - születés_évszám
    
    @staticmethod
    def osztályszintű_metódus():
        print("asd")

    def példányszintű_metódus(self):
        print(self)

diák = Diák("Kiss Béla", 1995)

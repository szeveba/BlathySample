import serial #TODO: pip install pyserial
from Steinhart import Steinhart

class Atlas:
    """
    Represents an Atlas device for reading resistance and temperature values.

    Attributes:
    - port (Serial): The serial port object used for communication with the device.

    Methods:
    - __init__(self, port_name): Initializes an instance of the Atlas class.
    - read_ohms(self): Reads the resistance values from the device.
    - read_celsius(self, digits=2): Reads the temperature in Celsius from the sensor and returns a list of rounded values.
    """

    def __init__(self, port_name) -> None:
        """
        Initializes an instance of the Atlas class.

        Parameters:
        - port_name (str): The name of the serial port to connect to.

        Returns:
        None
        """
        self.port = serial.Serial(port_name, timeout=1, baudrate=250000, dsrdtr=True)

    def read_ohms(self):
        """
        Reads the resistance values from the device.

        Returns:
            list: A list of resistance values in ohms.
        """
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
    
    def read_celsius(self, digits: int = 2) -> list[float|None]:
            """
            Reads the temperature in Celsius from the sensor and returns a list of rounded values.

            Args:
                digits (int): Number of digits to round the Celsius values to. Default is 2.

            Returns:
                list[float|None]: A list of rounded Celsius temperature values. If a temperature reading is not available, None is included in the list.
            """
            ohms = self.read_ohms()
            op = []
            for ohm in ohms:
                celsius = Steinhart.OhmToCelsius(ohm)
                if celsius is not None:
                    celsius = round(celsius, digits)
                op.append(celsius)
            return op

import math

class Steinhart:
    """
    A class for converting resistance in ohms to temperature in Celsius using the Steinhart equation.
    """
    a = 0.0011212735580564
    b = 0.000235338520425013
    c = 8.3442490007E-08
    
    def OhmToCelsius(ohm: int) -> float|None:
        """
        Converts resistance in ohms to temperature in Celsius.

        Args:
            ohm (int): The resistance value in ohms.

        Returns:
            float|None: The temperature in Celsius if the value of resistance is available, None otherwise.
        """
        if ohm == 0:
            return None
        x = (1 / (Steinhart.a + Steinhart.b * math.log(ohm) + Steinhart.c * (math.log(ohm) ** 3))) - 273.15
        return x

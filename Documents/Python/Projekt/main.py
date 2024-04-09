from serial.tools import list_ports
from Atlas import Atlas

import matplotlib.pyplot as plt
import numpy as np

yAxisLabels = range(1, 17)
xAxisLabels = range(1, 17)

fig, ax = plt.subplots()
im = ax.imshow(np.zeros((16, 16)))  # Kezdetben üres kép

# Show all ticks and label them with the respective list entries
ax.set_xticks(np.arange(len(xAxisLabels)), labels=xAxisLabels)
ax.set_yticks(np.arange(len(yAxisLabels)), labels=yAxisLabels)

# Rotate the tick labels and set their alignment.
plt.setp(ax.get_xticklabels(), rotation=45, ha="right",
         rotation_mode="anchor")

ax.set_title("Heatmap")
fig.tight_layout()
plt.show(block=False)  # Blokkolás nélküli megjelenítés

ports = list_ports.comports()
driver = Atlas(ports[1].name)

while True:
    temperatures = driver.read_celsius()

    values = np.ndarray((16, 16))
    idx = 0
    for xIdx in range(0, 16):
        for yIdx in range(0, 16):
            values[xIdx][yIdx] = temperatures[idx]
            idx += 1

    print(values)
    im.set_data(values)  # Adatok frissítése
    plt.draw()
    plt.pause(5)  # Frissítési idő


# Jegyzet

## Metódusok

Egy osztály függvénye vagy metódusa.

- kódrészlet kiemelésére
- névvel látjuk el a kódrészletet
- név által tetszőlegesen meghívható
- rendelkezhet egy vagy több paraméterrel
- paraméter: metódus működése szempontjából egy változó, melyet híváskor megadhatunk

### Paraméterek fajtái

- **positional**: sorrend által tudjuk megadni
- **keyword**: kulcsszó által tudjuk megadni

### Metódusok fajtái

- **Függvény**: van visszatérési értéke
- **eljárás**: nincs visszatérési értéke

## print() függvény

Karakterlánc kiíratása a standard outputra (alapértelmezetten a konzolra)

```python
print(*args, sep=' ', end='\n', file=None, flush=False)
    Prints the values to a stream, or to sys.stdout by default.

    sep
      string inserted between values, default a space.
    end
      string appended after the last value, default a newline.
    file
      a file-like object (stream); defaults to the current sys.stdout.
    flush
      whether to forcibly flush the stream.

```

### Paraméterek

- **args**: értékek felsorolása, ezeket fogja kiíratni a sep-el elválasztva
- **sep**: értékek közötti elválasztó karakterlánc, alapértelmezetten szóköz
- **end**: értékek felsorolása végén kiírandó karakterlánc, alapértelmezetten új sor karakter

## Literálok
- **jelentése**: programkódban megadott érték

### Példa

```python
a = "asd"
```
Ebben az esetben
- **a**: változó neve
- **"asd"**: string **LITERÁL**, a változó kezdeti értéke

|típus|literál|
|:---:|:---:|
|karakterlánc|"asd", "", ...|
|egész|-1, 0, 1, 2, ...|
|logikai|True,False|
|valós|3.14, 0.5, ...|
## Escape karakterek

|szimbólum|jelentés|
|:---:|:---:|
|\n|új sor|
|\t|tabulátor|
|\\\'|aposztróf|
|\\\\ |fordított perjel|
|\r|kocsi vissza (sor elejére ugrás)|
|\b|backspace (horizontálisan -1)|

## Típuskonverzió vs típuskényszerítés
- **típuskényszerítés**: a adott értéket kezeljünk úgy mintha más típusú lenne
    - pl.: 3.14 egész számként kezelve 3
- **típuskonverzió**: 
adott érték átalakítása adatszerkezet szintjén másik típusúra
    - pl.: int("3")
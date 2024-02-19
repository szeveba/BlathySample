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

## Típuskonverzió vs típuskényszerítés (lehet nem jó)
- **típuskényszerítés**: a adott értéket kezeljünk úgy mintha más típusú lenne
    - pl.: 3.14 egész számként kezelve 3
- **típuskonverzió**: 
adott érték átalakítása adatszerkezet szintjén másik típusúra
    - pl.: int("3")

## Operátorok
Operandusok között alkalmazott műveletek halmaza.

### Operátorok fajtái

#### Aritmetikai operátorok

|köznyelvben|pythonban|
|:---:|:---:|
|összeadás|+|
|kivonás|-|
|szorzás|*|
|osztás|/|
|egészrész|//|
|maradékos osztás|%|
|hatványozás|**|


#### Logikai operátorok

|köznyelvben|pythonban|
|:---:|:---:|
|és|and|
|vagy|or|
|negáció (tagadás)|not|

#### Relációs operátorok
Reláció jelentése: kölcsönös függés, viszonyulás

|köznyelvben|pythonban|
|:---:|:---:|
|egyenlőségvizsgálat (ekvivalencia)|==|
|nem egyenlő|!=|
|kisebb|<|
|nagyobb|>|
|kisebb vagy egyenlő|<=|
|nagyobb vagy egyenlő|>=|

#### Értékadó operátorok

|köznyelvben|pythonban|
|:---:|:---:|
|értékadás|=|
|összeadás|+=|
|kivonás|-=|
|szorzás|*=|
|osztás|/=|
|egészrész|//=|
|maradékos osztás|%=|
|hatványozás|**=|

#### Bitenkénti operátorok
Kettes számrendszerben alkalmazott műveleteket szimbolizáló operátorok halmaza.


## Elemi programozási tételek

### Algoritmus futásidejének jellemzése

- **O(n):** Az algoritmus futásideje elemszám függvényében
  - **O():** futásidő függvénye
  - **n:** gyűjtemény elemszáma melyel dolgozik az algoritmus

### Elemi programozási tételek csoportosítása futásidő szempontjából
- minimum O(n)
  - Összegzés
  - Megszámlálás
  - Maximumkiválasztás
- maximum O(n)
  - Eldöntés
  - Kiválasztás
  - Lineáris keresés

### Elemi programozási tételek jellemzése futásidő szempontjából

- **O(1):** Akár egy lépés alatt végezhet az algoritmus.
- **O(n/2):** Átlagosan a lépések száma az elemszám fele.
- **O(n):** Minden elemet végig kell nézzünk legalább egyszer.

|Tétel neve|Legjobb eset|Átlagos eset|Legrosszabb eset|
|:---:|:---:|:---:|:---:|
|**Összegzés**|O(n)|O(n)|O(n)|
|**Megszámlálás**|O(n)|O(n)|O(n)|
|**Maximumkiválasztás**|O(n)|O(n)|O(n)|
|**Eldöntés**|O(1)|O(n/2)|O(n)|
|**Kiválasztás**|O(1)|O(n/2)|O(n)|
|**Lineáris keresés**|O(1)|O(n/2)|O(n)|

### Összegzés 

- [minta](../Python/Programozási%20tételek/összegzés.py)
- **Cél:** Valamilyen művelet által a gyűjteményben való elemeket összegezzük.
- példák
  - összeadás
    - minden szám összeadása
    - minden karakterlánc összefűzése
  - szorzás
    - minden szám összeszorzása

### Megszámlálás 

- [minta](../Python/Programozási%20tételek/megszámlálás.py)
- **Cél:** Hány feltételt teljesítő elem található egy gyűjteményben?

### Eldöntés 

- [minta](../Python/Programozási%20tételek/eldöntés.py)
- **Cél:** Van e feltételt teljesítő elem a gyűjteményben?

### Kiválasztás

### Lineáris keresés

### Maximumkeresés

- **Cél:** Szélsőérték keresés egy gyűjteményben.

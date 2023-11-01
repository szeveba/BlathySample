# Tesztelés

## Unit tesztelés

### .NET-es környezetben

Javasolt könyvtár a .NET-es egységtesztek készítésére az NUnit.

#### NUnit tesztkörnyezet kialakítása

1. Solution belül egy NUnit projekt hozzáadása.
2. A Solution Exploreren belül a tesztprojekt Dependency-s bejegyzésére jobb klikk => add project references.
    - Add hozzá azokat a projekt referenciákat amiket tesztelnél.
    - **Figyelem**: Ahhoz, hogy elérd a tesztprojektedből a tesztelendő kódokat, publikusnak kell definiálnod amit el szeretnél érni. (pl.: egy metódus esetében public osztályon belül public metódus)


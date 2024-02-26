# MVVM

## Elmélet

MVVM = Model-View-ViewModel
- Model => a programunk modellje ami nem a nézetet írja le
- View => a nézeteket leíró fájlok
- ViewModel (VM) => A Model-t és a View-t összekötő osztály

Cél: A nézetek és az üzleti logika szétválasztása, modulárisabb és kevesebb, átláthatóbb kód.
Megoldás: 
- ViewModeleket hozunk létre, minden nézetnek megvan a saját VM-je.
- Egy VM szerepe: adott nézet minden adatát tartalmazza, ha megváltozik egy tulajdonsága eseményt süt el. A nézet az esemény alapján frissíti a megjelenített adatot.
- Adatkötés: technikai megoldás a VM és a view-ok adatainak szinkronizációjához. Ha egy adatkötésre alkalmas tulajdonság megváltozik a kódnak el kell sütnie egy PropertyChanged eseményt.
- Az üzleti logika a ViewModellel áll kapcsolatban a ViewModel pedig adatkötés útján a View-al, ami lehet egy vagy kétirányú kötés.

## Gyakorlat

1. 1. Nuget csomagkezelőről CommunityToolkit.Mvvm telepítése.
2. 
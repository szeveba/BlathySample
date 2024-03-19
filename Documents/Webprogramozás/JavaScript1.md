# JavaScript I. (Webprogramozás - 11. évfolyam)

## Tárgyleírás

A témakör legfontosabb feladata, hogy a tanulók megismerkedjenek a JavaScript nyelv szintaktikai elemeivel és az eseményvezérelt webprogramozás alapjaival. A tanulók a JavaScript témakör során megszerzik azokat az elméleti ismereteket és gyakorlati készségeket, amelyek segítségével képesek lesznek interaktív weboldalak és egyszerűbb webes alkalmazások létrehozására JavaScript segítségével. 

A témakörben az alábbi ismeretek és gyakorlati készségek elsajátítására kerül sor:

- JavaScript kód futtatása konzolon
- Elemi és összetett adattípusok (Number, String, Array, Boolean, undefined, null, Object, Map, Set) a JavaScriptben; értékadás, aritmetikai és logikai műveletek, kifejezések kiértékelése
- Reguláris kifejezések
- Változók és konstansok deklarálása (var, let, const), láthatóságuk
- Vezérlési szerkezetek (of, while, for, for in, for of, switch, break) 
- Függvények deklarálása, arrow functions
- Objektumok webes környezetben, tulajdonságok és metódusok, DOM (Document Object Model), node-ok (csomópontok), element (elem), attribute (tulajdonság) és text (szöveg) node-ok
- Elemek elérése, módosítása és létrehozása
- Események és eseményfigyelő eljárások (onClick, onLoad, onBlur, onFocus események)
- Űrlapelemek (form, input, select, option, textarea, label) elhelyezése weboldalakon, és azok interaktív kezelése

## JavaScript kód futtatása konzolon
### Változók és konstansok deklarálása
`[let|const] {változónév} = {literál|kifejezés};`
```js
let változó = 3; //inicializáció után is megváltoztatható
const konstans = 3; //inicializáció után nem változtatható meg
```
__Megjegyzés:__ Régebben a `var` kulcsszóval tehettük meg, manapság kerülendő.

## Elemi és összetett adattípusok
értékadás, aritmetikai és logikai műveletek, kifejezések kiértékelése
### Number

A számokat a JavaScriptben az `Number` típus reprezentálja. Ez lehet egész szám vagy lebegőpontos szám.

```js
// Egész szám létrehozása
let integerNumber = 10;
console.log("Egész szám:", integerNumber);

// Lebegőpontos szám létrehozása
let floatingPointNumber = 3.14;
console.log("Lebegőpontos szám:", floatingPointNumber);

// Aritmetikai műveletek
let sum = integerNumber + floatingPointNumber;
console.log("Összeg:", sum);

let difference = integerNumber - floatingPointNumber;
console.log("Különbség:", difference);

let product = integerNumber * floatingPointNumber;
console.log("Szorzat:", product);

let quotient = integerNumber / floatingPointNumber;
console.log("Hányados:", quotient);

// Összehasonlítás
let isGreaterThan = integerNumber > floatingPointNumber;
console.log("Nagyobb-e:", isGreaterThan);

let isLessThan = integerNumber < floatingPointNumber;
console.log("Kisebb-e:", isLessThan);

// Néhány beépített metódus használata
let strNumber = "123";
console.log("Szövegként:", strNumber);

// A szövegként tárolt számot Number típusra konvertáljuk
let convertedNumber = Number(strNumber);
console.log("Konvertált szám:", convertedNumber);

// Ellenőrzés, hogy valóban szám-e
let isNumber = isNaN(convertedNumber);
console.log("Szám-e:", !isNumber);

// Tizedesre kerekítés
let roundedNumber = Math.round(floatingPointNumber);
console.log("Kerekített szám:", roundedNumber);
```

### String

A karakterláncokat a JavaScriptben az `String` típus reprezentálja.

```js
// String létrehozása
let szoveg = "Hello, világ!";

// Hossz lekérdezése
let hossz = szoveg.length;
console.log("A szöveg hossza: " + hossz);

// Karakterek elérése index alapján
let karakter = szoveg[0];
console.log("Az első karakter: " + karakter);

// Karakterek összefűzése
let ujSzoveg = szoveg + " Üdvözlet!";
console.log("Az új szöveg: " + ujSzoveg);

// Karakterlánc keresése
let pozicio = szoveg.indexOf("világ");
console.log("A 'világ' szó pozíciója: " + pozicio);

// Karakterlánc cseréje
let ujSzoveg2 = szoveg.replace("világ", "JavaScript");
console.log("Cserélve: " + ujSzoveg2);

// Karakterlánc darabolása
let szavak = szoveg.split(" ");
console.log("Szavak tömbje: ", szavak);
```

### Array

A tömbök egy sorozatot jelentenek a JavaScriptben, és azonos típusú vagy különböző típusú elemeket is tartalmazhatnak. A tömböknek zérótól kezdődő indexeik vannak.

```js
// Tömb létrehozása és inicializálása
let numbers = [1, 2, 3, 4, 5];

// Tömb elemeinek kiíratása
console.log("Tömb elemei:");
for (let i = 0; i < numbers.length; i++) {
    console.log(numbers[i]);
}

// Új elem hozzáadása a tömbhöz
numbers.push(6);

// Módosítás az adott indexen
numbers[0] = 10;

// Törlés az adott indexen
delete numbers[1];

// Tömb elemeinek kiíratása a módosítások után
console.log("Módosított tömb elemei:");
for (let i = 0; i < numbers.length; i++) {
    if (numbers[i] !== undefined) {
        console.log(numbers[i]);
    }
}
```

### Boolean

A logikai értékeket a JavaScriptben az `Boolean` típus reprezentálja. Ez a típus `true` vagy `false` értéket vehet fel.
```js
// Boolean típus létrehozása
let isRaining = true;
let isSunny = false;

// Logikai műveletek
let isCold = true;
let isWarm = false;

// Logikai operátorok
let isCloudy = true;
let isClear = false;

// Példa a logikai operátorok használatára
let isGoodWeather = isSunny && !isCold; // Ha napos és nem hideg, jó idő van
let isBadWeather = isRaining || isCloudy; // Ha esik az eső vagy felhős az ég, rossz idő van

// Kiíratás a konzolra
console.log("Is it good weather?", isGoodWeather); // Kiírja, hogy jó-e az idő
console.log("Is it bad weather?", isBadWeather); // Kiírja, hogy rossz-e az idő
```

### undefined

Az undefined érték azt jelzi, hogy egy változó létezik, de még nem kapott értéket, vagy értékét nem állították be. Ez gyakran akkor fordul elő, amikor egy változót deklarálnak, de nem kap kezdőértéket, vagy amikor egy olyan objektum tulajdonságára hivatkoznak, ami nem létezik.

```js
let x; // x változó deklarálása, de nincs értékadás, így az értéke undefined lesz
console.log(x); // Output: undefined

let y = 10; // y változó deklarálása és értékadása
if (y === undefined) {
    console.log("y változó értéke undefined");
} else {
    console.log("y változó értéke nem undefined");
}

// Függvény, amely nem ad vissza értéket, így az alapértelmezett visszatérési érték undefined lesz
function greet(name) {
    console.log("Hello, " + name + "!");
}
let result = greet("John"); // greet függvény meghívása, de a visszatérési értéket nem mentjük el
console.log(result); // Output: undefined
```

### null

A null érték pedig azt jelzi, hogy egy változónak nincs értéke, vagy hogy egy változó értékét explicit módon beállították null-ra. Tehát, bár mindkét típus azt jelzi, hogy a változónak nincs értéke, a null-t általában programozók helyezik el tudatosan egy változóban, míg az undefined inkább azt jelzi, hogy a változó értékét még nem állították be.

### Object

Az objektumok kulcs-érték párokat tartalmazó összetett adattípusok a JavaScriptben. Kulcsok lehetnek karakterláncok vagy számok, az értékek pedig bármilyen típusúak lehetnek.

```js
// Objektum létrehozása
let car = {
    brand: "Toyota",
    model: "Corolla",
    year: 2022,
    color: "blue",
    // Metódus hozzáadása az objektumhoz
    displayInfo: function() {
        console.log(`Brand: ${this.brand}, Model: ${this.model}, Year: ${this.year}, Color: ${this.color}`);
    }
};

// Objektum tulajdonságainak elérése és módosítása
console.log("Car brand:", car.brand); // Kinyomtatja: Car brand: Toyota
car.color = "red";
console.log("Car color after update:", car.color); // Kinyomtatja: Car color after update: red

// Metódus meghívása az objektumon
car.displayInfo(); // Kinyomtatja: Brand: Toyota, Model: Corolla, Year: 2022, Color: red

```

### Map

A `Map` objektum egy kulcs-érték párokat tároló kollekció a JavaScriptben. A kulcsok és az értékek bármilyen típusúak lehetnek.

```js
// Új Map létrehozása
let myMap = new Map();

// Kulcs-érték párok hozzáadása
myMap.set('a', 1);
myMap.set('b', 2);
myMap.set('c', 3);

// Kulcs-érték párok lekérése
console.log(myMap.get('a')); // 1
console.log(myMap.get('b')); // 2
console.log(myMap.get('c')); // 3

// Map méretének lekérése
console.log(myMap.size); // 3

// Kulcsok lekérése
console.log(myMap.keys()); // MapIterator {"a", "b", "c"}

// Értékek lekérése
console.log(myMap.values()); // MapIterator {1, 2, 3}

// Kulcs-érték párok kiíratása
myMap.forEach((value, key) => {
  console.log(`${key}: ${value}`);
});

// Kulcs-érték párok törlése
myMap.delete('b');
console.log(myMap.has('b')); // false

// Minden kulcs-érték párnak ugyanaz az értéke
let sameValueMap = new Map([
  ['a', 1],
  ['b', 1],
  ['c', 1]
]);
console.log(sameValueMap.get('a')); // 1
console.log(sameValueMap.get('b')); // 1
console.log(sameValueMap.get('c')); // 1
```

### Set

A `Set` objektum egyedi értékeket tároló kollekció a JavaScriptben. Ez egy halmaz típusú adatszerkezet, tehát nem tartalmaz duplikált elemeket.

```js
// Új üres Set létrehozása
let mySet = new Set();

// Értékek hozzáadása a Set-hez
mySet.add(1);
mySet.add(2);
mySet.add(3);
mySet.add(1); // Az egyedi értékek miatt ez a hozzáadás nem történik meg

// Set tartalmának kiíratása
console.log(mySet); // Output: Set { 1, 2, 3 }

// Ellenőrzés, hogy egy elem benne van-e a Set-ben
console.log(mySet.has(2)); // Output: true
console.log(mySet.has(4)); // Output: false

// Elemek eltávolítása a Set-ből
mySet.delete(2);

// Set tartalmának kiíratása
console.log(mySet); // Output: Set { 1, 3 }

// Set méretének lekérdezése
console.log(mySet.size); // Output: 2

// Set elemeinek bejárása
mySet.forEach(item => {
    console.log(item);
});
// Output:
// 1
// 3

// Set ürítése
mySet.clear();

// Set tartalmának kiíratása (üres Set)
console.log(mySet); // Output: Set {}
```

---
__Továbbiak kidolgozás alatt...__

---

## Reguláris kifejezések

[W3Schools összefoglaló](https://www.w3schools.com/jsref/jsref_obj_regexp.asp)

## Vezérlési szerkezetek (of, while, for, for in, for of, switch, break) 
## Függvények deklarálása, arrow functions
## Objektumok webes környezetben, tulajdonságok és metódusok, DOM (Document Object Model), node-ok (csomópontok), element (elem), attribute (tulajdonság) és text (szöveg) node-ok
- Elemek elérése, módosítása és létrehozása
- Események és eseményfigyelő eljárások (onClick, onLoad, onBlur, onFocus események)
- Űrlapelemek (form, input, select, option, textarea, label) elhelyezése weboldalakon, és azok interaktív kezelése
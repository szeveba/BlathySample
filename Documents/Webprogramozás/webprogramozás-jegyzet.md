Tanmenet:
# Webprogramozás 11. évfolyam jegyzet

## HTML3 + CSS3

### Mediaelemek alkalmazása

#### **Elméleti Rész: Részletes vizsgálat a médiaelemekről**

A médiaelemek, mint például képek, hangok és videók, kulcsfontosságúak a webes dizájnban. Ezek a vizuális és hangzó elemek hatékonyan fokozzák a weboldal élményét. Ebben az órában részletesen megvizsgáljuk ezeket az elemeket és azok helyes beillesztését.

##### **1. Képek (img elem):**
A `img` elem segítségével illeszthetünk be képeket a weboldalba. A fontos tulajdonságok közé tartozik a `src` (forrás), `alt` (alternatív szöveg) és a `width`, `height` (szélesség, magasság).

```html
<img src="kep.jpg" alt="Leíró szöveg" width="300" height="200">
```

##### **2. Hangok (audio elem):**
Az `audio` elem segítségével beilleszthetünk hangfájlokat. Fontos attribútumok: `src`, `controls` és opcionálisan `autoplay`.

```html
<audio controls>
  <source src="zene.mp3" type="audio/mp3">
  A böngésző nem támogatja a hanglejátszást.
</audio>
```

##### **3. Videók (video elem):**
A `video` elem segítségével videókat illeszthetünk be. Fontos attribútumok: `src`, `controls`, `width`, `height` és opcionálisan `autoplay`.

```html
<video width="400" height="300" controls>
  <source src="video.mp4" type="video/mp4">
  A böngésző nem támogatja a videolejátszást.
</video>
```

#### **Gyakorlat: Multimédiás Oldal Tervezése**

Készíts egy egyszerű weboldal tervezetet, amely tartalmaz legalább egy képet, hangfájlt és videót. Használd a fenti kódokat a médiaelemek beillesztéséhez. Ne felejtsd el megadni az `alt` szöveget a képeknél és ellenőrizd, hogy a médiaelemek jól működnek-e.

#### **Feladat: Médiaelemek Stílusának Megváltoztatása CSS-sel**

Adj stílust a médiaelemeknek CSS segítségével. Próbálj ki különböző szélesség, magasság, és árnyék beállításokat. Használd a `box-shadow`, `border` és egyéb stílusokat a vonzó megjelenés érdekében.

```css
img {
  width: 100%;
  height: auto;
  box-shadow: 2px 2px 5px #888888;
}

audio, video {
  width: 80%;
  margin: 20px 0;
  border: 1px solid #ddd;
  box-shadow: 3px 3px 8px #888888;
}
```

#### **Visszajelzés és Összegzés:**
Az óra során alaposan megismertük a médiaelemeket és gyakorlatban is alkalmaztuk azokat egy valós weboldal tervezésével és stílusozásával. A következő órákon ezen alapokra építve folytatjuk a webdizájn fejlesztését.
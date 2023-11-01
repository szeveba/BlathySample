# Git Cheatsheet

A konzolos gitet a hardcore arcoknak javasom első sorban. Én szeretem de meg kell hagyni, hogy a Dark Souls-t is...

A Git egy verziókövető rendszer. Van más megoldás is erre a kontextusra, de az ipar ezt használja mint de facto szabvány. (A de facto szabvány olyan szokás vagy konvenció, amely a közvélemény vagy a piaci erők által domináns pozíciót szerzett, például korai piacra lépéssel, egyszerűen megfogalmazva, azért 'szabvány' mert mindenki ezt használja.)

A Git egy szoftver amit a Git-CLI-n keresztül tudunk használni. Van Git-GUI is. Ránézésre is olyan fapadosnak tűnt számomra, hogy nem volt kedvem megismerkedni vele.

**Figyelem:** A verziókövető rendszerek használata egy készség. Méghozzá egy olyan készség ami abszolút elvárt a szoftverfejlesztés területén. Nem kell brutálisan mélyen ismerned, de minél jobban tudod használni annál jobb. Kezd el használni, mire odaérsz, hogy fizetnének a munkádért rád fog ragadni kellően a szükséges ismeret.

## Alapfogalmak

### commit

Változtatások halmaza melyhez message-t fűzünk, hogy tudjuk mi is a változtatások célja

### staged

olyan változtatások melyek a következő commitba fognak kerülni

### branch

magyarul ág: egy commit mindig a checkouttal megjelölt branch-be kerül

### lokális repository

a repository helyi változata, ebbe dolgozol

### remote repository

a repository távoli helye, ezzel szinkronizálod a lokális repository-d

### clone

remote repository első letöltése, hogy kialakítsd lokálisan a repository-d

### push

lokális repository módosításainak feltöltése a remote repositoryra

### pull

a remote repository változtatásainak letöltése a már meglévő lokális repository-dba

### merge

amikor egy branch commitjait szinkronizálod egy másik branch-el

### fork

leágaztatás, gyakorlatilag egy repository állapotának a magadévá tétele

### stash

átmeneti tároló a kódbázisod változtatásainak tárolására

## Személyes ajánlás a verziókövetésre

A git egy iszonyatosan egyszerű, de mégis nagyon összetett rendszer. Nagyon sok funkciója van és sok funkciót több parancs által is elérsz. A legkevésbé sem célom teljes git anyagot átadni. A cél csak az, hogy értelmesen, hatékonyan tudd használni, annyira amennyire szeretnéd. Minimum annyira használd, hogy van egy ágad amibe mindig commmitolsz és pusholod, hogy meglegyen bárhol is dolgoznál vele.

**OneDrive, GoogleDrive, e-mail-en és Messengeren elküldöm magamnak iszonyatosan kontraproduktív és antipattern!**

Jómagam a GitHub-CLI-t és a Git-CLI-t használom. A GitHub-CLI-t arra használom, hogy definiáljak a segítségével egy távoli repository-t a GitHub-on. Ez többek között azért is jó, mert így nem kell beállítanom a távoli repository-m lokálisan. (--set-upstream-es parancs kiadása nem szükséges)

Ha olyan környezetben dolgozom ami a projekt generálás során lokális repository-t is létrehoz akkor először létrehozom a projektet majd odanavigálok parancssorban és a `gh repo create` parancs kiadása után a lokális repository push-olása opciót választom. Ezt azért így csinálom, mert  így a fejlesztőkörnyezet beállítja a megfelelő gitignore fájlt előre.

Ha nem ilyen jellegű a fejlesztőkörnyezet amiben dolgozom akkor viszont nagyon hasznos a GitHub-CLI mert a repo létrehozásakor kiválaszthatjuk, hogy milyen típusú gitignore-t akarunk használni.

### GitHub-CLI parancsok

|parancs|hatás|
|:---:|:---:|
|`gh auth login`|GitHub-ra való bejelentkezés a CLI-vel, csak egyszer kell|
|`gh repo create`|új távoli repository definiálása|
|`gh browse`|távoli repository GitHub-os böngészős nézetének megnyitása|
|`gh repo clone username/repositoryName`|repo klónozása GitHub-ról|
|`gh repo list`|összes távoli GitHub repository kilistázása|

A többit olyan ritkán használom, ha egyáltalán használom, hogy inkább meg sem említem.

### Git-CLI parancsok

|parancs|hatás|
|:---:|:---:|
|`git status`|repository állapotának lekérdezése|
|`git log`|repository előzmények megjelenítése|
|`git diff`|verziókövetett fájlok változtatásainak lekérdezése, melyek még nem lettek staged-nek jelölve|
|`git add .`|Minden módosítás staged-nek jelölése|
|`git restore --staged .`|minden staged-nek jelölt módosítás visszaállítása unstaged-re|
|`git commit -m "commit message"`|A staged változtatások commit-olása|
|`git push`|lokális repository változtatásainak feltöltése a távoli repositoryba|
|`git pull`|remote repository változtatásainak letöltése a lokális repository-ba|
|`git stash`|minden verziókövetett fájl módosításának eltétele a stash-be|
|`git stash pop`|módosítások kivétele a stash-ből|
|`git stash drop`|a stash eldobása|
|`git branch -a`|repository ágainak lekérdezése|
|`git branch asd`|asd nevű ág definiálása|
|`git checkout asd`|a használandó branch kijelölése, a commitok az asd nevű ágra fognak kerülni|
|`git merge asd`|asd commitjainak hozzáadása az aktuálisan használt branchbe (checkout!)|

Ahol pontot használok a parancsban az mind olyan aminek egy fájlt meg kell határozni. Amikor `.`-ot írok azzal egy relatív elérési utat adok meg, azt ahol éppen vagyok a parancssoron belül. Ennek eredménye, hogy minden ami az aktuális mappában van (rekurzívan értendő) kijelölésre kerül.

asd-nevű branch-et nem szoktam létrehozni, azt csak a példa kedvéért írtam. Jómagam a következő brancheket szoktam használni.

|branch név|szerepe|
|:---:|:---:|
|master|a stabil forráskód helye|
|development|amikor fejlesztek ide committolok, ha elérek egy mérföldkövet és stabil, a dev branchet merge a masterbe|
|production|ebbe csak a masterből merge-elök|

Ezen kívül ha valami tök új funkciót készülök összerakosgatni, előfordul, hogy egy külön branchet hozok létre. Az ilyen brancheket a szakzsargon `feature branch`-nek nevezi.

## Git kliensek

### Grafikus

- [GitHub Desktop](https://desktop.github.com): Egyszerű, csak GitHub-hoz.
- [GitKraken](https://www.gitkraken.com): Elég szép, de fizetős. Ha kibulizod a [GitHub Student Developer Pack](https://education.github.com/pack)-et akkor a megkapod a teljes hozzáférést ingyen. Meg még elég sok minden mást is. Javaslom a figyelmetekbe a lehetőséget.
- IDE: Minden fejlesztőkörnyezetben implementálva van ez a funkció. Ugyanakkor én nem szoktam őket preferálni.

### Parancssoron keresztül

- [Git](https://git-scm.com): Ez az ős git kliens. Amikor kiadjuk a `git` parancsot, ezt használjuk.
- [GitHub-CLI](https://cli.github.com): `gh` parancson kereszül használható. Én mindig ezt használom, ha kiakarom alakítani GitHub-on a repository-m.\
  1. `gh repo create`: kiadom és válaszolok a kérdésekre
  2. `git ...`: később már csak az alap cli klienst használom.

## Alapvető Git Parancsok

### Kezdeti beállítások

- `git init`: Új Git repository inicializálása.
- `git config --global user.name "Your Name"`: Felhasználónév beállítása.
- `git config --global user.email "your.email@example.com"`: E-mail cím beállítása.

### Munkavégzés a repository-ban

- `git clone <repository_url>`: Lemásolja a távoli repository-t a helyi gépre.
- `git status`: Megjeleníti a módosított, hozzáadott és törölt fájlokat.
- `git add <file>`: Hozzáad egy fájlt a staging area-hoz.
- `git commit -m "Commit üzenet"`: Módosítások rögzítése a repository-ban.
- `git pull`: Frissíti a helyi repository-t a távoli repository-val.
- `git push`: Küldi a helyi módosításokat a távoli repository-ba.

### Ágak kezelése

- `git branch`: Listázza az összes elérhető ágat.
- `git checkout <branch_name>`: Átváltás egy másik ágra.
- `git branch <new_branch>`: Új ág létrehozása.
- `git merge <branch_name>`: Ág összefésülése a jelenlegi ággal.

### Távoli repository kezelése

- `git remote -v`: Megjeleníti a távoli repository-k listáját.
- `git remote add <remote_name> <repository_url>`: Hozzáad egy új távoli repository-t.
- `git remote remove <remote_name>`: Távoli repository eltávolítása.

### Távoli repository beállítása a GitHub-CLI-vel

`gh repo create`

## Haladó Git Parancsok

### Stash kezelése

- `git stash`: Kiveszi a módosításokat a kódodból és eltárolja azt.
- `git stash pop`: Visszatölti az utolsó stash-t és törli azt.
- `git stash drop`: Stash eldobása

### Konfliktusok

#### Jelentése

A Git-ben a "konfliktus" (conflict) egy olyan helyzet, amikor a verziókezelő rendszer nem tud automatikusan eldönteni, hogyan kellene összeilleszteni két eltérő változtatást ugyanazon fájlban vagy szakaszban.

Ez általában akkor fordul elő általában, amikor két vagy több fejlesztő ugyanazon fájl vagy rész szakaszában változtatásokat hajt végre, majd megpróbálják a változtatásokat a központi Git repository-ba összefésülni (merge vagy pull) vagy amikor valaki próbál egy másik ágról beilleszteni változtatásokat egy ágba (merge vagy rebase). Ebben az esetben a Git jelzi, hogy "konfliktus" van, és a fejlesztőnek **manuálisan** meg kell oldania a konfliktust.

A rossz hír, hogyha egyedül dolgozol akkor is össze lehet hozni.

#### Gyakorlatban

##### Konfliktusok feloldása konzolon

- `git add <resolved_file>`: A konfliktusok feloldott fájlok hozzáadása a staging area-hoz.
- `git commit`: Konfliktusok feloldásának rögzítése.

Magyarán kijavítod majd committolod. De grafikus felületen javítgatnám ki, általában egy speciális nézet segít összeollózni a kívánt fájlt.

##### Konfliktusok feloldása (gordiuszi csomó szerűen:D)

Általában akkor fogod megtapasztalni eleinte amikor dolgozol, ha **A** helyen majd pusholod, dolgozol **B** helyen majd azt is pusholnád, csak hát elfelejtetted a **B** munka kezdetén pull-olni a változtatásokat (és pont olyan módosításokat töltenél ami ütközést mutat). Ekkor a git felszólít hogy push előtt pull kell mert van fent módosítás. Lehívod és bumm.

Eléggé bele lehet kavarodni. Első sorban igyekezz elkerülni. Ha bekövetkezett a baj körültekintően próbáld meg grafikus felületen összeollózni. Ha nem megy sehogy sem bármikor létre tudsz hozni egy új repositoryt amibe áthúzhatod a fájlokat majd committolod. Nem a legszebb megoldás, de garantáltan megoldja a problémát... De csak végső esetben csináljátok ezt.

## Git parancsok megismerése

- `git help <command>`: Segítség egy konkrét parancs használatához.
- `git --help`: Git parancssor segítség.

## Dokumentációk

[Git hivatalos dokumentációja](https://git-scm.com/doc).

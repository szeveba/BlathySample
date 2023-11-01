# Git Cheatsheet

A konzolos gitet a hardcore arcoknak javasom első sorban. Én szeretem de meg kell hagyni, hogy a Dark Souls-t is...

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

## Git Parancsok Segítségéhez

- `git help <command>`: Segítség egy konkrét parancs használatához.
- `git --help`: Git parancssor segítség.

## Dokumentációk

[Git hivatalos dokumentációja](https://git-scm.com/doc).

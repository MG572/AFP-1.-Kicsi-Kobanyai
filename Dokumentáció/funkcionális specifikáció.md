# Funkcionális specifikáció
## 1. Jelenlegi helyzet leírása
A projekt célja az hogy alkossunk egy egyszerű alkalmazást ahol a felhasználó feltud magának venni megoldható feladatokat egy táblázatba ezzel segítve a munkavégzést. Képesnek kell lennie ezen kívűl határidőket és emlékeztetőket kapnia hogy ne kerüljön elfelejtésre a kihívás.

## 2. Vágyálomrendszer leírása
Az elképzelés egy alkalmazás ahol a felhasználó meg tud nézni egy táblázatot. Elösször is ez a táblázat üres lesz. Azonban a felhasználónak képesnek kell lennie felvennie a táblázatba feladatokat, majd látnia kell ezeket benne. Ezen kívűl lehetőséget szeretnék adni a feladat módosítására felvétele után, illetve kitörlésére ha nem akarjuk hogy továbbra is jelen legyen a táblázatban(például mert már sok feladat szerepel benne vagy esetleg extrém névütközés és átláthatatlanná válik). Ezen kívűl képesnek kellene lennie késznek bejelölni a feladatot hogy tudja hogy azzal már nem kell tovább foglalkozni. Határidőt is be kell tudni állítani hogy lássa a táblázatba meddik kell elvégeznie a feladatát illetve lehetőség szerint valamiféle értesítést is kellene kapnia ha a határidő közeled ezzel elérve hogy ne felejtse el. A könnyebb átláthatóság elérése érdekében törlésen kívűl lehetőséget szeretnénk adni arra is hogy szűrni és rendezni lehessen a táblázatot.

## 3. Jelenlegi üzleti folyamatok modellje
  [Felhasználó indítja az alkalmazást]
          |
          v
  [Felhasználó megtekinti a feladatokat]
          |
          v
  +------------------------------+
  |                              |
  v                              v
[Új feladat hozzáadása]    [Feladat módosítása]
  |                              |
  v                              |
[Feladat adatok megadása]      |
  |                              |
  v                              |
[Feladat mentése] <-------------+
  |
  v
[Feladatok listája frissítése]
          |
          v
[Feladat törlése]
          |
          v
[Feladat törlése megerősítése]
          |
          v
[Feladatok listája frissítése]


## 4. Igényelt üzleti folyamatok modellje
  [Felhasználó indítja az alkalmazást]
          |
          v
  [Felhasználó megtekinti a feladatokat]
          |
          v
  +------------------------------+
  |                              |
  v                              v
[Új feladat hozzáadása]    [Feladat módosítása]
  |                              |
  v                              |
[Feladat adatok megadása]      |
  |                              |
  v                              |
[Feladat mentése] <-------------+
  |
  v
[Feladat törlése]
          |
          v
[Feladat törlése megerősítése]
          |
          v
[Feladatok listája frissítése]
          |
          v
[Értesítések beállítása]
          |
          v
[Feladat határidejének ellenőrzése]
          |
          v
[Értesítés a határidőről]


## 5. Követelménylista

1. Funkcionális követelmények

Feladatok hozzáadása

A felhasználó képes új feladatokat hozzáadni.

A feladat bevitelekor kötelező megadni a feladat nevét.

Opcionálisan megadható feladat leírás és határidő (határidő dátum formátumban).

A feladat státuszát (pl. "Aktív") automatikusan az alkalmazás állítja be hozzáadáskor.

Feladatok listázása

A felhasználó megtekintheti az összes feladatot egy listában.

A lista tartalmazza a feladat nevét, leírását, határidejét és státuszát.

A felhasználó képes szűrni a feladatokat státusz szerint (pl. csak az aktív vagy kész feladatokat jelenítse meg).

Feladatok szerkesztése

A felhasználó képes meglévő feladatokat módosítani.

A feladat neve, leírása, határideje és státusza szerkeszthető.

A szerkesztés után a feladat frissített adatai mentésre kerülnek az adatbázisban.

Feladatok törlése

A felhasználó képes feladatokat törölni a listából.

Törlés esetén a feladat véglegesen eltávolításra kerül az adatbázisból.

Adatbázis integráció

Az alkalmazás a feladatokat egy helyi SQL adatbázisban (pl. SQLite) tárolja.

A CRUD műveletek (hozzáadás, olvasás, módosítás, törlés) valós időben hajtódnak végre az adatbázisban.

2. Nem-funkcionális követelmények

Felhasználói felület

Az alkalmazás Windows Forms alapú, egyszerű és felhasználóbarát.

A felhasználói felület intuitív és könnyen kezelhető legyen minden funkció számára.

Az alkalmazás támogassa a magyar nyelvű felhasználói felületet.

Teljesítmény

Az adatbázis-lekérdezések és -műveletek gyorsak és hatékonyak legyenek, hogy a felhasználói élmény zavartalan maradjon.

Az alkalmazás képes legyen kezelni akár 100-200 feladatot anélkül, hogy jelentős teljesítménycsökkenés tapasztalható lenne.

Biztonság

Az alkalmazás biztonságosan kezelje az adatokat, a felhasználói adatok ne legyenek elérhetők illetéktelenek számára.

A felhasználói adatok helyi gépen kerülnek tárolásra, és nem kerülnek továbbításra külső szerverekre.

Hordozhatóság és telepítés

Az alkalmazás Windows operációs rendszeren futtatható.

Egyszerű telepítési folyamat, amely nem igényel bonyolult konfigurációt vagy külső függőségeket.

Skálázhatóság

Az adatbázis struktúrája későbbi bővítésekhez könnyen igazítható legyen (pl. több felhasználó támogatása vagy bonyolultabb státuszkezelés).

3. Egyéb követelmények

Dokumentáció

A rendszerhez tartozó dokumentáció tartalmazza az adatbázis struktúráját, az alkalmazás funkcióit és a telepítési lépéseket.

Tesztelhetőség

Minden funkció alapos tesztelése szükséges (pl. feladatok hozzáadása, módosítása, törlése), hogy a rendszer hibamentesen működjön.

Tesztelni kell az alkalmazás teljesítményét különböző számú feladat mellett.

Ez a követelménylista biztosítja, hogy a todolist alkalmazás teljes mértékben megfeleljen a felhasználói és technológiai igényeknek, miközben egyszerű, átlátható és hatékony marad.

## 6. Használati esetek

1. Feladat hozzáadása
Cél: Új feladat létrehozása.

Használati lépések:

A felhasználó megnyitja az alkalmazást.

A felhasználó a "Új feladat" gombra kattint.

Kitölti a feladat nevét, leírását és határidejét.

A felhasználó a "Hozzáadás" gombra kattint.

A rendszer menti a feladatot és megjeleníti a listában.

2. Feladat módosítása
Cél: Meglévő feladat adatainak szerkesztése.

Előfeltételek: Léteznie kell a módosítandó feladatnak.

Használati lépések:

A felhasználó kiválasztja a módosítani kívánt feladatot a listából.

A felhasználó a "Módosítás" gombra kattint.

Megváltoztatja a szükséges mezőket.

A felhasználó a "Mentés" gombra kattint.

A rendszer frissíti a feladat adatait a listában.

3. Feladat törlése
Cél: Meglévő feladat eltávolítása.

Előfeltételek: Léteznie kell a törlendő feladatnak.

Használati lépések:

A felhasználó kiválasztja a törölni kívánt feladatot.

A felhasználó a "Törlés" gombra kattint.

A rendszer megerősítést kér a törlésről.

A felhasználó megerősíti a törlést.

A rendszer eltávolítja a feladatot a listából.

4. Feladatok megjelenítése
Cél: A felhasználó összes feladatának megjelenítése.

Használati lépések:

A felhasználó megnyitja az alkalmazást.

A rendszer megjeleníti az összes feladatot, a státuszukkal és határidejükkel együtt.

A felhasználó szűrheti és rendezheti a feladatokat.

5. Értesítések kezelése
Cél: Határidők értesítéseinek beállítása.

Használati lépések:

A felhasználó megnyitja az értesítések beállításait.

A felhasználó beállítja az értesítési időpontokat.

A rendszer elmenti a beállításokat és értesíti a felhasználót a közelgő határidőkről.

## 7. Megfeleltetés, hogyan fedik le a használati eseteket a követelményeket

Funkció                                Követelmény                                      Megfeleltetés
------------------------------------------------------------------------------------------------------------------------------------------
Feladat hozzáadása	| A felhasználónak lehetősége kell,           |      A "Hozzáadás" gomb megnyomásával a felhasználó új feladatot adhat meg, beleértve a nevét, 
                    | hogy legyen új feladatokat létrehozni.	    |      leírását és határidejét.
------------------------------------------------------------------------------------------------------------------------------------------
Feladat módosítása	|	A felhasználónak lehetősége kell, hogy legyen | A felhasználó a módosítani kívánt feladatra kattintva, majd a "Módosítás" gombra kattintva 
                    |  meglévő feladatok adatainak szerkesztésére.	|    módosíthatja a feladat adatait.
------------------------------------------------------------------------------------------------------------------------------------------                   
Feladat törlése		  | A felhasználónak lehetősége kell, hogy legyen | A felhasználó a törölni kívánt feladatra kattintva, majd a "Törlés" gombra kattintva 
                    | meglévő feladatok törlésére.                  | eltávolíthatja a feladatot, melyet a rendszer megerősít.
------------------------------------------------------------------------------------------------------------------------------------------                        
Feladatok listájának| A felhasználónak látnia kell az összes feladatát, | A rendszer megjeleníti a felhasználó összes feladatát a feladatlistában, beleértve azok 
megjelenítése       | azok státuszával és határidejével.                | státuszát és határidejét.
------------------------------------------------------------------------------------------------------------------------------------------    		
Értesítések beállítása | A felhasználónak lehetősége kell, hogy legyen | A felhasználó beállíthatja az értesítéseket a feladatok határidejével kapcsolatban, 
                       | határidő értesítések beállítására.            | amelyeket a rendszer figyelmeztetései alapján aktivál.
------------------------------------------------------------------------------------------------------------------------------------------  	
Határidők ellenőrzése	 | A rendszernek nyomon kell követnie a feladatok | A rendszer automatikusan ellenőrzi a feladatok határidejét, és értesítést küld a közelgő 
                       | határidejét.                                   | határidőkről, segítve ezzel a felhasználót a feladatok időben történő elvégzésében.


## 8. Képernyőtervek

[todoplan.png](https://github.com/gybence202/KobanyaiCopy/blob/36e081ea03f7849641816ee6029402681a02de4f/todoplan.png)

## 9. Forgatókönyvek
Forgatókönyv 1: Új feladat hozzáadása

Cél: A felhasználó új feladatot akar hozzáadni az alkalmazáshoz.

Előfeltétel: Az alkalmazás elindítva, a fő felhasználói felület látható.

Lépések:

A felhasználó rákattint a "Új feladat hozzáadása" gombra.

Megnyílik egy ablak vagy űrlap, ahol a felhasználó megadhatja a feladat nevét, leírását, határidejét (opcionális).

A felhasználó kitölti a mezőket, majd a "Mentés" gombra kattint.

Rendszer válasz:

A rendszer validálja az adatokat (pl. nem üres név).

A rendszer létrehozza az új feladatot és elmenti az adatbázisba.

A feladat megjelenik a feladatok listájában.

Utófeltétel: Az új feladat sikeresen hozzáadva, és látható a listában.

Forgatókönyv 2: Feladat szerkesztése

Cél: A felhasználó módosítani szeretne egy meglévő feladatot.

Előfeltétel: A felhasználó által szerkesztendő feladat már létezik és megjelenik a listában.

Lépések:

A felhasználó kiválasztja a szerkesztendő feladatot a listából.

A felhasználó rákattint a "Szerkesztés" gombra.

A szerkesztési felület megnyílik, ahol a felhasználó módosítja a feladat nevét, leírását, határidejét vagy státuszát.

A felhasználó a változtatásokat menti a "Mentés" gombbal.

Rendszer válasz:

A rendszer validálja a módosított adatokat.

A rendszer frissíti az adatokat az adatbázisban.

A frissített feladat megjelenik a listában a módosított adatokkal.

Utófeltétel: A feladat adatai frissítve lettek az adatbázisban és a felhasználói felületen.

Forgatókönyv 3: Feladat törlése

Cél: A felhasználó törölni szeretne egy meglévő feladatot.

Előfeltétel: A felhasználó által törölni kívánt feladat létezik a listában.

Lépések:

A felhasználó kiválasztja a törölni kívánt feladatot a listában.

A felhasználó rákattint a "Törlés" gombra.

A rendszer megerősítést kér egy felugró ablakban: "Biztosan törölni szeretné a feladatot?"

A felhasználó megerősíti a törlést.

Rendszer válasz:

A rendszer törli a feladatot az adatbázisból.

A feladat eltűnik a feladatok listájából.

Utófeltétel: A feladat véglegesen törlődött az adatbázisból és a felhasználói felületről.

Forgatókönyv 4: Feladat státuszának módosítása

Cél: A felhasználó módosítani szeretné egy feladat státuszát (pl. "Kész"-re állítani).

Előfeltétel: A felhasználó által szerkeszteni kívánt feladat létezik és szerepel a listában.

Lépések:

A felhasználó kiválasztja a feladatot, amelynek státuszát módosítani szeretné.

A felhasználó a feladat részleteit megnyitva a státuszt "Aktív"-ról "Kész"-re változtatja.

A változtatást a felhasználó menti.

Rendszer válasz:

A rendszer frissíti a feladat státuszát az adatbázisban.

A feladat státusza frissítve megjelenik a listában ("Kész").

Utófeltétel: A feladat státusza sikeresen módosult.

Forgatókönyv 5: Feladatok listázása és szűrése

Cél: A felhasználó meg szeretné tekinteni a hozzáadott feladatokat, és szűrni kívánja őket státusz alapján.

Előfeltétel: A rendszerben már léteznek feladatok különböző státusszal.

Lépések:

A felhasználó megnyitja a feladatok listáját az alkalmazásban.

A felhasználó kiválaszt egy szűrőt, például a "Csak aktív feladatok" opciót.

Rendszer válasz:

A rendszer lekérdezi az adatbázisból az aktív feladatokat.

A rendszer csak azokat a feladatokat jeleníti meg, amelyek státusza "Aktív".

Utófeltétel: A felhasználó csak az aktív feladatokat látja a felületen.

Forgatókönyv 6: Hiba kezelése üres név esetén

Cél: A felhasználó hibát követ el, amikor egy új feladatot ad hozzá, mert nem adja meg a feladat nevét.

Előfeltétel: A felhasználó egy új feladatot szeretne hozzáadni.

Lépések:

A felhasználó rákattint a "Új feladat hozzáadása" gombra.

A felhasználó üresen hagyja a "Feladat neve" mezőt és rákattint a "Mentés" gombra.

Rendszer válasz:

A rendszer validálja a mezőket és érzékeli, hogy a "Feladat neve" mező üres.

A rendszer hibaüzenetet jelenít meg: "A feladat neve nem lehet üres!"

A felhasználó visszatér a feladat hozzáadása képernyőre.

Utófeltétel: A feladat nem került mentésre, amíg a név mező nincs kitöltve.

Ezek a forgatókönyvek bemutatják a felhasználói interakciókat és a rendszer válaszait, amelyeken keresztül az alkalmazás funkciói megfelelően működnek, és a felhasználói élmény gördülékeny marad.

## 10. Funkció - követelmény megfeleltetése

| Id | Követelmény | Funkció |
| :---: | --- | --- |
| K4 | ... | ... |

## 11 Fogalomszótár

- Feladat: Azt a feladatot kell ide beírni, amit el szeretnénk végezni.
- Prioritás: Az adott feladat prioritási szintje, hogy melyik milyen hamar kéne megcsinálni. Három szintje van: Alacsony, Közepes és Magas.
- Határidő: A feladatnak meg lehet jelölni egy határidőt, ami egy naptár formájában lehet kijelölni Év. hónap nap. formátumban például: 2024. szeptember 25.
- Kész van-e: A Kész van-e egy gomb amit ha bejelölünk, akkor a hozzáadott feladat végén külön odaírja hogy kész van-e.
- Hozzáad: A Hozzáad gomb hozzáadja a listánkhoz a feladatot amit felvettünk, ha nem írtunk be semmit, akkor kapunk egy jelzést, hogy meg kell adni a feladatot.
- Szerkesztés: A Szerkesztésnél ki kell jelölni a feladatot amit csináltunk és minden a felső sorban felsorolt tevékenységet lehet szerkeszteni. Hibaüzenetet kapunk, ha nem jelöltünk ki semmilyen feladatot sem.
- Törlés: A Törlés a kijelölt feladatot kitörli teljesen.
- Fájlba írás: A Fájlba írás gomb, ha van feladatunk kiírja az adott feladatot, a teendok.txt fájlba és ezt egy kis felugró ablak jelzi a felhasználónak.

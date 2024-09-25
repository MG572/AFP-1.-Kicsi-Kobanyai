# Követelmény specifikáció

## 1. Áttekintés

  A projekt célja egy Windows Forms alapú To-Do list alkalmazás kifejlesztése, amely lehetővé teszi a felhasználók számára, hogy egyszerűen kezelhessék teendőiket. Az alkalmazás lehetőséget biztosít feladatok létrehozására, szerkesztésére, törlésére és állapotuk követésére. A program célja a hatékony időmenedzsment támogatása, és a teendők áttekinthetőségének növelése.

## 2. A jelenlegi helyzet leírása

  Jelenleg a felhasználók többnyire papíron vagy más nem strukturált digitális formában kezelik teendőiket, mint például szövegszerkesztő programok vagy egyszerű jegyzetek használatával. Ez a módszer nem biztosít értesítéseket vagy állapotkezelést. A feladatok állapotának követése és strukturálása nehézkes, különösen, ha több feladatot kell egyszerre kezelni.

## 3. Vágyálomrendszer

  Az alkalmazásnak az alábbi fő funkciókkal kell rendelkeznie:

    Feladatok hozzáadása, szerkesztése és törlése.

    Feladatok állapotának beállítása (pl. „Folyamatban”, „Kész”).

    Határidők kezelése, értesítések beállítása a közelgő határidők figyelmeztetésére.

    Feladatok kategorizálása különböző témák szerint.

    Adatmentés és betöltés lehetősége helyi fájlokba.

## 4. Jelenlegi üzleti folyamatok modellje

  A jelenlegi folyamatok szerint a felhasználók manuálisan követik nyomon feladataikat különböző eszközökkel, ami nagyban függ az egyén szervezési készségeitől. A feladatok nem mindig átláthatók, és nem áll rendelkezésre megfelelő módszer a prioritások gyors beállítására vagy a határidők nyomon követésére.

## 5. Igényelt üzleti folyamatok modellje

  A célunk egy olyan alkalmazás készítése amely lehetőséget biztosít az összes teendő vizualizálására, a prioritások meghatározására és a határidők kezelésére.

## 6. Követelménylista
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

## 7. Fogalomtár

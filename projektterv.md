1. Projekt célja

A cél egy Windows Forms alapú todolist alkalmazás fejlesztése, amely feladatok hozzáadását, listázását, szerkesztését és törlését biztosítja. Az alkalmazás egy lokális adatbázist használ a feladatok tárolására és kezelésére.

2. Ütemterv (4 hét)

Tervezés (1. hét)

Funkciók meghatározása: Részletes specifikáció (feladat hozzáadása, listázása, szerkesztése, törlése).

Felhasználói felület megtervezése: Windows Forms egyszerű és felhasználóbarát felület tervezése.

Adatbázis tervezése: Egyszerű adatbázis-struktúra meghatározása (pl. SQLite, SQL Server Express), amely a feladatokat tárolja (feladat ID, név, leírás, határidő, státusz).

Fejlesztés (2-3. hét)

Adatbázis integráció: Az adatbázis beállítása és integrálása az alkalmazásba (kapcsolat létrehozása, CRUD műveletek).

Alapfunkciók implementálása:

Feladat hozzáadása: Új feladatok felvitele az adatbázisba.

Feladatok listázása: A feladatok lekérdezése és megjelenítése a felhasználói felületen.

Feladat szerkesztése: A meglévő feladatok módosítása és frissítése az adatbázisban.

Feladat törlése: Teljesített vagy felesleges feladatok eltávolítása az adatbázisból.

Felhasználói interakciók kezelése: Az alkalmazás reagál a felhasználói műveletekre (pl. gombnyomások, listaelem kiválasztása).

Tesztelés és hibajavítás (4. hét)

Funkcionális tesztelés: Minden funkció és az adatbázis kapcsolatok alapos tesztelése.

Hibajavítás: Az észlelt hibák javítása a tesztelés során.

Felhasználói visszajelzések: Tesztkör futtatása, visszajelzések alapján finomítások elvégzése.

Véglegesítés: Stabil alkalmazás verzió készítése.

3. Főbb funkciók

Feladat hozzáadása: Új feladatok rögzítése az adatbázisban.

Feladatok listázása: Az adatbázisban tárolt összes feladat megjelenítése listában.

Feladat szerkesztése: A felhasználó meglévő feladatainak módosítása.

Feladat törlése: Nem releváns feladatok eltávolítása az adatbázisból.

4. Technológiai követelmények

Fejlesztői környezet: Microsoft Visual Studio

Nyelv: C#

Adatbázis: SQLite vagy SQL Server Express (lokális adatbázis)

Platform: Windows (Windows Forms)

5. Erőforrások és szerepkörök

Fejlesztő: Felelős a programozásért és az adatbázis integrációjáért.

Tesztelő: A funkciók és az adatbázis működésének tesztelése.

6. Kockázatok

Adatbázis hibák: Az adatbázis helytelen kezelése esetén adatvesztés vagy kapcsolati hibák fordulhatnak elő.

Időhiány: Az adatbázis integrációja és a fejlesztési folyamat időigényes lehet, ezért a 4 hetes ütemtervet szigorúan követni kell.

7. Siker kritériumai

A projekt sikeres, ha az alkalmazás stabilan működik, az adatbázis megfelelően kezeli a feladatokat, és a felhasználók könnyedén tudják kezelni a programot.
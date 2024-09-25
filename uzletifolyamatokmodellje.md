1. Felhasználói folyamatok

Ezek a folyamatok a felhasználó interakcióira épülnek, a feladatok létrehozásától azok törléséig.

Feladat hozzáadása

Bemenet: A felhasználó megadja a feladat nevét, leírását, határidejét.

Folyamat: Az alkalmazás ellenőrzi a bemenetek érvényességét. Ha érvényesek, a feladat bekerül az adatbázisba.

Kimenet: A feladat megjelenik a feladatlistában, és mentésre kerül az adatbázisban.

Feladatok listázása

Bemenet: A felhasználó megnyitja az alkalmazást vagy kéri a feladatok megjelenítését.

Folyamat: Az alkalmazás lekérdezi az adatbázisból a mentett feladatokat.

Kimenet: A feladatok megjelennek a felhasználó felületén egy listában.

Feladat szerkesztése

Bemenet: A felhasználó kiválasztja a szerkesztendő feladatot, módosítja annak adatait.

Folyamat: Az alkalmazás ellenőrzi a módosításokat, és frissíti az adatbázisban az adott feladatot.

Kimenet: A feladat frissítve jelenik meg a listában, és az adatbázisban is módosulnak az adatok.

Feladat törlése

Bemenet: A felhasználó kiválaszt egy feladatot és törli azt.

Folyamat: Az alkalmazás eltávolítja a feladatot az adatbázisból.

Kimenet: A feladat törlődik a listából és az adatbázisból.

2. Rendszerfolyamatok

Ezek a folyamatok a háttérben zajlanak, és biztosítják, hogy az adatbázis megfelelően kezelje a felhasználói adatokat.

Adatbázis lekérdezés

Bemenet: Lekérdezés (SQL) futtatása a feladatok lekérdezésére (pl. a felhasználói felületen történő listázás során).

Folyamat: Az alkalmazás SQL utasítást küld az adatbázisnak a feladatok lekérdezésére.

Kimenet: Az adatbázis visszaküldi a feladatokat, amelyeket az alkalmazás megjelenít a felhasználó számára.

Adatbázis frissítés

Bemenet: A felhasználó adatot ad hozzá vagy szerkeszt.

Folyamat: Az alkalmazás SQL utasítást küld az adatbázisnak (INSERT, UPDATE).

Kimenet: Az adatbázis tárolja a módosított adatokat.

Adatbázis törlés

Bemenet: A felhasználó törli a feladatot.

Folyamat: Az alkalmazás SQL DELETE utasítást küld az adatbázisnak.

Kimenet: A feladat törlődik az adatbázisból.

3. Folyamatok integrációja

Felhasználói interakciók: A felhasználók végzik a feladatok kezelését az alkalmazáson keresztül.

Adatkezelés: Az adatbázis kezeli a feladatok hozzáadását, módosítását, törlését, és biztosítja az adatok hosszú távú tárolását.

4. Szerepkörök a folyamatokban

Felhasználó: Teendőket kezel (hozzáad, szerkeszt, töröl, listáz).

Rendszer: Közvetít a felhasználói interakciók és az adatbázis között, végrehajtja a műveleteket (CRUD műveletek).

Ez az üzleti folyamatmodell segít megérteni a todolist alkalmazás működését, és biztosítja a rendszer megfelelő megvalósítását.
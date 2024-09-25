1. Adatbázis szerkezete

Az adatbázis egyetlen fő táblából áll, amely a feladatokat tárolja. Ez lehet SQL alapú adatbázis, például SQLite vagy SQL Server Express, attól függően, hogy milyen típusú környezetet használunk.

Táblák:

Feladatok (Tasks) tábla

A táblában minden egyes feladat rögzítésre kerül a szükséges attribútumokkal. Ez a tábla a CRUD műveletek (hozzáadás, olvasás, szerkesztés, törlés) alapja lesz.

Oszlopok leírása:

TaskID: Egyedi azonosító minden feladathoz, elsődleges kulcs (Primary Key), automatikusan növekvő érték.

TaskName: A feladat neve, maximum 255 karakter hosszúságú.

TaskDescription: Opcionális, hosszabb leírás a feladatról (pl. teendők részletei).

DueDate: Az a dátum, ameddig a feladatot el kell végezni.

Status: A feladat státusza, amely megmutatja, hogy a feladat folyamatban van-e, kész, vagy valamilyen más állapotban van (pl. késlekedés).

CreatedDate: A feladat létrehozásának dátuma, automatikusan a feladat rögzítésekor kerül kitöltésre.

UpdatedDate: Az utolsó módosítás dátuma, amikor a feladatot szerkesztik.

2. Kapcsolatok

A jelenlegi verzióban az adatbázis egyetlen táblából áll (feladatok), így nincs szükség bonyolult kapcsolatkezelésre. Az egyszerű struktúra előnye, hogy gyorsan lekérdezhető és módosítható, mivel minden feladat adatait egyetlen tábla tartalmazza.

3. További lehetőségek

Indexelés: Az adatbázis teljesítményének javítása érdekében indexek létrehozhatók a gyakran használt oszlopokon, például a TaskID, DueDate, vagy Status oszlopokon.

Státusz típusok: A Status mezőhöz előre definiált értékek létrehozása (pl. "Aktív", "Kész", "Függőben") segíthet az egységesség fenntartásában.

Ez az adatbázis terv biztosítja a todolist alkalmazás adatainak könnyű kezelését és bővítését, miközben rugalmas marad a különböző felhasználói igényekhez.
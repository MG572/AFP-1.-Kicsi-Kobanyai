# Rendszerterv
## 1. A rendszer célja

A todolist alkalmazás célja az, hogy felhasználók egyszerűen nyomon követhessék és kezeljék a teendőiket, feladataikat. Az alkalmazás Windows Forms felületen fog működni, ami grafikus interfészt biztosít, hogy a felhasználók könnyedén hozzáadhassanak, szerkeszthessenek és törölhessenek feladatokat.

Összefoglalva a rendszer fő céljai:

Feladatok hozzáadása: A felhasználók új feladatokat adhatnak hozzá, megadva a szükséges adatokat (feladat neve, leírása, határidő, stb.).

Feladatok listázása: A felhasználók egy átlátható listában láthatják az összes feladatukat, időrendi sorrendben vagy prioritás alapján.

Feladatok módosítása: Lehetőség lesz a meglévő feladatok szerkesztésére.

Feladatok törlése: A felhasználók egyszerűen törölhetnek feladatokat, ha már nem relevánsak vagy teljesítve lettek.

Könnyű használat: A Windows Forms alapú felület felhasználóbarát módon biztosítja a fenti funkciókat, ikonos, gombos vagy lista alapú megoldásokkal.

Ez az alkalmazás alapvetően az egyéni produktivitást kívánja növelni azáltal, hogy segít a felhasználóknak a teendőik rendszerezésében és hatékony kezelésében.

## 2. Projektterv

### 2.1 Projektszerepkörök, felelőségek:
   * Scrum masters:Sinka Barnabás
   * Junior fejlesztők: Győrfi Bence, Sálek Dániel, Szilágyi Kristóf, Márton Gergely, Bukovinszki Bálint
   * Üzleti szereplő: Penyaskó Dávid
     
### 2.2 Projektmunkások és felelőségek:
   * Frontend:
   * Backend:
   * Tesztelés:
     
### 2.3 Ütemterv:

|Funkció                  | Feladat                                | Prioritás | Becslés (nap) | Aktuális becslés (nap) | Eltelt idő (nap) | Becsült idő (nap) |
|-------------------------|----------------------------------------|-----------|---------------|------------------------|------------------|---------------------|
|Követelmény specifikáció |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |             
|Funkcionális specifikáció|Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Rendszerterv             |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Program                  |Képernyőtervek elkészítése              |         2 |             1 |                      1 |                1 |                   1 |
|Program                  |Prototípus elkészítése                  |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Alapfunkciók elkészítése                |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Tesztelés                               |         4 |             2 |                      2 |                2 |                   2 |

### 2.4 Mérföldkövek:
   •	Dokumentáció elkészítése
   •	Funkciók kidolgozása
   •	Prototípus készítés
   •	Kész program publikálása

## 3. Üzleti folyamatok modellje

### 3.1 Üzleti szereplők
- Vállalat: Kőbányai (Projekt neve)
- Egyéni vásárlók: Akik megveszik vagy használják a programot.

### 3.2 Üzleti folyamatok
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

## 4. Követelmények

### Funkcionális követelmények
  1.	Feladatok hozzáadása:
     A felhasználónak lehetősége van új feladatokat hozzáadni, beleértve a feladat nevét és határidejét.
  2.	Feladatok módosítása:
     A felhasználó szerkesztheti a meglévő feladatokat (pl. nevét, határidejét, prioritását).
  3.	Feladatok törlése:
     A felhasználó törölheti a feladatokat a listából.
  4.	Feladatok megjelölése késznek:
     A felhasználó kijelölheti a feladatokat, hogy elkészültek (checkbox).
  5.	Feladatok határideje:
     Minden feladat tartalmazhat egy határidőt, amely alapján a program különböző színekkel vagy szimbólumokkal jelzi a közelgő határidőket.
  6.	Feladatok szűrése:
     A felhasználó képes szűrni a feladatokat (pl. összes feladat, kész feladatok, határidő szerint).
  7.	Feladatok rendezése:
     A felhasználó rendezheti a feladatokat különböző kritériumok szerint (pl. név, határidő).
  8.	Értesítések:
     A program figyelmeztetheti a felhasználót a közelgő vagy lejárt határidőkre.
  9.	Feladatok mentése és betöltése:
     A programnak lehetőséget kell biztosítania arra, hogy a feladatokat fájlba mentse és onnan később betöltse.
  10.	Felhasználói felület:
     A feladatok listáját egy táblázatos formában jeleníti meg, ahol a felhasználó könnyedén navigálhat és interakcióba léphet az egyes elemekkel.


### Nemfunkcionális követelmények
  1.	Teljesítmény:
   A programnak gyorsan kell reagálnia a felhasználói műveletekre, beleértve a feladatok hozzáadását, módosítását és törlését, még nagyobb feladatlisták esetén is.
  2.	Felhasználhatóság:
     A felhasználói felületnek könnyen érthetőnek és kezelhetőnek kell lennie, akár tapasztalatlan felhasználók számára is.
  3.	Hordozhatóság:
     A program csak Windows operációs rendszeren fut, de kompatibilis kell legyen különböző Windows verziókkal (Windows 10, 11).
  4.	Megbízhatóság:
     A programnak hibamentesen kell működnie, különös tekintettel a feladatok mentésére és visszatöltésére. Nem szabad adatvesztést vagy programösszeomlást okoznia.
  5.	Biztonság:
     A felhasználói adatok (feladatok) biztonságos tárolása érdekében a programnak kezelnie kell a megfelelő fájlhozzáférést. Az adatoknak biztonságban kell lenniük a nem szándékos törléstől vagy sérüléstől.
  6.	Skálázhatóság:
     A programnak képesnek kell lennie nagyobb mennyiségű feladat kezelésére anélkül, hogy jelentős teljesítménybeli lassulás tapasztalható lenne.
  7.	Karbantarthatóság:
     A kódnak jól strukturáltnak és karbantarthatónak kell lennie, hogy a jövőbeli bővítések és hibajavítások könnyen elvégezhetők legyenek.
  8.	Felhasználói élmény (UI/UX):
     Az alkalmazásnak letisztult és felhasználóbarát dizájnnal kell rendelkeznie, amely megkönnyíti a feladatok hozzáadását, módosítását és kezelését.
  9.	Stabilitás:
     A programnak hosszabb idő alatt is stabilan kell működnie, anélkül, hogy hibák vagy váratlan leállások fordulnának elő.

### Támogatott eszközök
   •	Operációs rendszer:
      o	Windows 10 vagy újabb: A program futtatásához Windows alapú környezet szükséges, mivel Windows Forms technológián alapul.
   •	.NET keretrendszer:
      o	.NET Framework 4.8 vagy újabb, vagy
      o	.NET Core 3.1 / .NET 5/6: Az alkalmazás futtatásához a megfelelő .NET keretrendszer telepítése szükséges.

      
## 5. Funkcionális terv
   Feladatkezelés
      •	Feladat hozzáadása: Új feladat létrehozása névvel, leírással és határidővel.
      •	Feladat módosítása: Meglévő feladatok szerkesztése.
      •	Feladat törlése: Feladatok eltávolítása.
      •	Feladatok megjelölése késznek: Befejezett feladatok jelölése.
   Feladatok listázása és szűrése
      •	Feladatok megjelenítése: Lista az összes feladatról.
      •	Szűrés: Feladatok szűrése állapot és határidő szerint.
      •	Rendezés: Feladatok rendezése határidő vagy népszerűség alapján.
   Határidők kezelése
      •	Értesítések: Közelgő határidőkről való értesítés.
      •	Lejárt határidők megjelenítése: Kiemelés a már lejárt feladatoknál.
   Adatkezelés
      •	Adatok mentése: Feladatok helyben fájlba mentése.
      •	Adatok betöltése: Feladatok betöltése indításkor.
   Felhasználói felület (UI)
      •	Intuitív dizájn: Könnyen navigálható felhasználói felület.
      •	Gombok: Funkciókhoz tartozó jól látható gombok.

      
### 5.1 Rendszerszereplők
   •	Felhasználó: Az alkalmazás használója, aki feladatokat kezel.
   •	Rendszer: Az alkalmazás, amely a felhasználói műveleteket végrehajtja.
   •	Adatbázis/fájlrendszer: Az adatok tárolásáért felelős háttértároló.

   
### 5.2 Menühierarchiák
   Főmenü
      •	Fájl
         o	Új feladat: Új feladat hozzáadása
         o	Mentés: Aktuális feladatok mentése
         o	Kilépés: Alkalmazás bezárása
      •	Feladatok
         o	Módosítás: Kiválasztott feladat szerkesztése
         o	Törlés: Kiválasztott feladat eltávolítása
         o	Megjelölés késznek: Kiválasztott feladat késznek jelölése
      •	Szűrés és rendezés
         o	Szűrés állapot szerint
            	Összes
            	Kész
            	Nem kész
         o	Rendezés
            	Határidő szerint
            	Prioritás szerint
      •	Értesítések
         o	Értesítések beállítása: Értesítések engedélyezése/kikapcsolása
         o	Értesítési időpontok: Határidők értesítéseinek beállítása
      •	Segítség
         o	Útmutató: Felhasználói kézikönyv
         o	Kapcsolat: Kapcsolatfelvételi információk
         o	Névjegy: Alkalmazásról szóló információk

   Felhasználói felület (UI) elemek
      •	Főoldal
         o	Feladatok listája
         o	Keresősáv
         o	Gombok (Hozzáadás, Módosítás, Törlés, Kész)
      •	Pop-up ablakok
         o	Új feladat hozzáadása
         o	Feladat szerkesztése


## 6. Fizikai környezet
   Hardver követelmények
      •	Személyi számítógép: A felhasználóknak minimum Windows 10 operációs rendszerrel rendelkező PC-re van szükségük.
         o	Processzor: Minimum 1 GHz-es vagy gyorsabb processzor.
         o	Memória: Minimum 2 GB RAM (ajánlott 4 GB vagy több).
         o	Tárhely: Legalább 100 MB szabad lemezterület az alkalmazás telepítéséhez és az adatok tárolásához.
      •	Monitor: Minimum 1024x768 felbontású kijelző, amely támogatja a Windows Forms felhasználói felületet.
      •	Bemeneti eszközök:
         o	Billentyűzet: A felhasználói interakciókhoz szükséges.
         o	Egér: Navigációhoz és a felhasználói felületen való interakcióhoz.
   Szoftver környezet
      •	Operációs rendszer: Windows 10 vagy újabb.
      •	.NET keretrendszer: .NET Framework 4.8 vagy újabb, vagy .NET Core 3.1 / .NET 5/6 telepítése szükséges.
      •	Fejlesztői környezet: Visual Studio (C#), amely lehetővé teszi az alkalmazás fejlesztését és tesztelését.

### Vásárolt softwarekomponensek és külső rendszerek

### Hardver topológia
Internet
   |
[Router]
   |
[Switch] (opcionális, ha több számítógép van)
   |
-------------------------
  |                     |
[PC1]                 [PC2] (több felhasználó esetén)
  |                     |
[Monitor]             [Monitor]
[Billentyűzet]        [Billenytűzet]
[Egér]                [Egér]


### Fizikai alrendszerek

### Fejlesztő eszközök
   •	Visual Studio


## 8. Architekturális terv
  1. A TO-DO List alkalmazás egy asztali alkalmazás, amely lehetővé teszi a felhasználók számára, hogy könnyen nyomon követhessék feladataikat. Az alkalmazás 
  felhasználói felülete, üzleti logikája és adatkezelése külön modulokra van osztva, hogy a fejlesztés és karbantartás egyszerűbb legyen.

  2. Architekturális rétegek
  Az alkalmazás három fő rétegre oszlik:

   * Felhasználói felület (UI) réteg
       * Leírás: A felhasználói interakciókat biztosítja, ideértve a feladatok listájának megjelenítését, feladat hozzáadását, módosítását és törlését.
       * Technológiák: Windows Forms, WPF (Windows Presentation Foundation) vagy más asztali UI keretrendszer.
   * Üzleti logika réteg
       * Leírás: Az alkalmazás működését vezérli, ideértve a feladatok kezelését, a módosítási és törlési folyamatokat, valamint az értesítések kezelését.
       * Technológiák: C# programozási nyelv, MVVM (Model-View-ViewModel) minta alkalmazása az üzleti logika és a felhasználói felület szétválasztására.
   * Adatkezelési réteg
       * Leírás: A feladatok és a felhasználói beállítások tárolásáért felelős. Ez a réteg kezeli az adatbázis kapcsolatait, valamint az adatok lekérdezését és             frissítését.
       * Technológiák: SQLite, JSON fájlok vagy más adatkezelési megoldások a feladatok tárolására.

3. Adatmodell
    * Feladat (Task): A feladat adatai, mint például név, leírás, határidő, státusz (pl. befejezett/nem befejezett).
    * Felhasználói beállítások (User Settings): Az alkalmazás személyre szabásához szükséges beállítások, mint például értesítések időpontjai.
4. Folyamatábra
    Az alábbiakban bemutatott folyamatábra szemlélteti a feladatok kezelésének folyamatát:
      1. A felhasználó megnyitja az alkalmazást.
      2. A felhasználó új feladatot ad hozzá.
      3. A rendszer menti a feladatot az adatkezelési réteg segítségével.
      4. A felhasználó megtekinti a feladatok listáját.
      5. A felhasználó módosítja vagy törli a feladatot, ami szintén az adatkezelési réteg frissítését vonja maga után.
5. Technológiai stack
  * Fejlesztői környezet: Visual Studio
  * Programozási nyelv: C#
  * Felhasználói felület: Windows Forms vagy WPF
  * Adatbázis: SQLite vagy JSON fájlok

### Webszerver

### Adatbázis rendszer
1. Adatbázis szerkezete

Az adatbázis egyetlen fő táblából áll, amely a feladatokat tárolja. Ez lehet SQL alapú adatbázis, például SQLite vagy SQL Server Express, attól függően, hogy milyen típusú környezetet használunk.

Táblák:

Feladatok (Tasks) tábla


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

### A program elérése, kezelése
- A programot a Visual Studio-ban lehet lehet elérni ToDoList.snl néven és azon belül a start gomb-ra kell rákattintani vagy az f5 billentyű lenyomásával lehet elindítani.

## 9. Adatbázis terv

## 10. Implementációs terv
      1. Bevezetés
         Ez az implementációs terv a TO-DO List alkalmazás fejlesztésének folyamatát, lépéseit és időkereteit tartalmazza. Célja a hatékony fejlesztés és a zökkenőmentes telepítés biztosítása.
      2. Fejlesztési környezet
         •	IDE: Visual Studio (C#)
         •	.NET verzió: .NET Core 3.1 vagy .NET 5/6
         •	Verziókezelés: Git (GitHub / GitLab)
      3. Fejlesztési lépések
         1.	Követelmények összegyűjtése
            o	A felhasználói igények és funkcionális követelmények áttekintése.
            o	A nem funkcionális követelmények dokumentálása.
         2.	Alkalmazás tervezése
            o	Felhasználói felület (UI) tervezése: Wireframe és prototípus készítése.
            o	Adatmodell kialakítása: Feladatok tárolásához szükséges adatok meghatározása.
         3.	Fejlesztés
            o	UI implementáció:
               	Windows Forms Designer használata az UI elemek (gombok, szövegdobozok, listák) létrehozásához.
            o	Funkcionális logika kódolása:
               	Feladatok hozzáadása, módosítása, törlése, szűrése és megjelölése késznek.
               	Adatok mentése és betöltése fájlba (pl. JSON vagy XML formátumban).
            o	Hibakezelés:
               	Rendszeres hibakezelési megoldások implementálása.
         4.	Tesztelés
            o	Egységtesztek és integrációs tesztek végrehajtása a funkcionális követelményeknek való megfelelés ellenőrzésére.
            o	Felhasználói tesztelés a UI és UX validálására.
         5.	Dokumentáció
            o	Felhasználói kézikönyv elkészítése a program használatához.
            o	Fejlesztői dokumentáció a kód karbantartásához.
         6.	Telepítés
            o	Az alkalmazás fájljainak átmásolása a célgépre, telepítő fájl nélkül.
            o	A rendszer követelményeinek ellenőrzése (pl. .NET keretrendszer).
         7.	Karbantartás és frissítések
            o	A felhasználói visszajelzések és hibajelentések alapján folyamatos fejlesztések és frissítések.


## 11. Tesztterv
   Tesztelés célja
   A cél annak biztosítása, hogy az alkalmazás stabilan és hibamentesen működjön, megfeleljen a felhasználói igényeknek, és hatékonyan kezelje a feladatokat.
   Tesztelendő funkciók
      •	Feladat hozzáadása, módosítása, törlése
      •	Feladatok megjelölése késznek
      •	Feladatok szűrése és rendezése
      •	Értesítések a határidőkről
      •	Adatok mentése és betöltése
      •	Felhasználói felület működése
   Nem funkcionális tesztek
      •	Teljesítmény, stabilitás, felhasználhatóság, hordozhatóság.


### Tesztesetek

 | Teszteset | Elvárt eredmény | 
 |-----------|-----------------| 
 | ... | ... |

### A tesztelési jegyzőkönyv kitöltésére egy sablon:

**Tesztelő:** Vezetéknév Keresztnév

**Tesztelés dátuma:** Év.Hónap.Nap

Tesztszám | Rövid leírás | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
például. Teszt #01 | Regisztráció | A felhasználó az adatok megadásával sikeresen regisztrálni tud  | A felhasználó sikeresen regisztrált | Nem találtam problémát.
... | ... | ... | ... | ...

## 12. Telepítési terv
   Követelmények
      •	Windows operációs rendszer (Windows 10 vagy újabb)
      •	.NET Framework vagy .NET Core telepítve
   Telepítési lépések
      1.	Alkalmazás fájljainak átmásolása:
         o	Másold át az alkalmazás bináris fájljait (EXE, DLL-ek) egy célgépre vagy adott mappába.
      2.	Könyvtárszerkezet beállítása:
         o	Ellenőrizd, hogy a szükséges könyvtárak és fájlok (pl. adatbázis fájlok, konfigurációs fájlok) a megfelelő helyen vannak.
      3.	.NET keretrendszer telepítése (ha szükséges):
         o	Ha a gépen nincs telepítve a megfelelő .NET verzió, telepítsd azt a Microsoft hivatalos oldaláról.
      4.	Az alkalmazás indítása:
         o	Futtasd az alkalmazás EXE fájlját közvetlenül a célgépen.
   Ellenőrzés
      •	Ellenőrizd, hogy az alkalmazás megfelelően működik, és elérhetőek-e az összes funkciók.


## 13. Karbantartási terv
   Hibaelhárítás
      •	Cél: Felhasználói visszajelzések alapján javítani az alkalmazásban felmerülő hibákat, bugokat.
   Megelőző karbantartás
      •	Cél: A szoftver frissítése a biztonság és a teljesítmény optimalizálása érdekében (pl. .NET frissítések).
   Továbbfejlesztés (Enhancements)
      •	Cél: Új funkciók hozzáadása vagy a meglévő funkciók bővítése a felhasználói igények szerint.
   Adaptív karbantartás
      •	Cél: Az alkalmazás módosítása a környezet (új operációs rendszer, platform) változásai miatt.
   Ellenőrzés és tesztelés
      •	Cél: Rendszeres tesztelés az új verziók kiadása előtt, hogy biztosítsuk a stabil működést.

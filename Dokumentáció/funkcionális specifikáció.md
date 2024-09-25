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

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | ...| ... | ... |

## 6. Használati esetek

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

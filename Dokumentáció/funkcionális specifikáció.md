# Funkcionális specifikáció
## 1. Jelenlegi helyzet leírása

## 2. Vágyálomrendszer leírása

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

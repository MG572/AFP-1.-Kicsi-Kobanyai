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
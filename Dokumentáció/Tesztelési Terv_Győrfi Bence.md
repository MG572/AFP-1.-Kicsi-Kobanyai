#### Tesztelő: Győrfi Bence

**Dátum**: 2024. október. 8.

# A tesztelés a tesztelési útmutató alapján történt.

| Tesztszám | Rövid leírás                                     | Várt eredmény                                                             | Eredmény                                                                       | Megjegyzés                       |
|-----------|--------------------------------------------------|---------------------------------------------------------------------------|--------------------------------------------------------------------------------|----------------------------------|
| Teszt #01 | Program indítása                                 | A program elindul és betöltődik a UI.                                   | A program indítása után betöltődnek a megfelelő komponensek és a program használatra kész. | Probléma mentes indulás.        |
| Teszt #02 | Feladat hozzáadása üres mezőkkel                | Figyelmeztető üzenet jelenik meg, hogy a feladat mező üres.             | "Kérlek, add meg a feladatot!" üzenet megjelenik.                          | Probléma mentes.                |
| Teszt #03 | Feladat hozzáadása érvényes adatokkal           | A feladat sikeresen hozzáadódik a listához.                             | A feladat megjelenik a `taskListBox`-ban, és az `originalTaskList`-ban is tárolódik. | Probléma mentes.                |
| Teszt #04 | Keresés működése üres mezővel                   | Az összes feladat újra megjelenik a listában.                           | Minden feladat láthatóvá válik a `taskListBox`-ban.                         | Probléma mentes.                |
| Teszt #05 | Keresés működése érvényes beírással              | Csak a keresési feltételnek megfelelő feladatok jelennek meg.           | Csak a megfelelő feladatok láthatóvá válnak a `taskListBox`-ban.            | Probléma mentes.                |
| Teszt #06 | Kattintás egy feladatra a listában               | A feladat részletei megjelennek a megfelelő mezőkben.                   | A kiválasztott feladat neve, prioritása, dátuma és állapota a mezőkben látható. | Probléma mentes.                |
| Teszt #07 | Keresési feltétel eltávolítása                   | A keresési mező üresítése után az összes feladat újra megjelenik.       | Minden feladat láthatóvá válik a `taskListBox`-ban.                         | Probléma mentes.                |
| Teszt #08 | Feladat törlése                                  | A kiválasztott feladat törlésre kerül.                                  | A feladat eltűnik a `taskListBox`-ból és az `originalTaskList`-ból is.       | Probléma mentes.                |
| Teszt #09 | Program bezárása                                  | Az "Exit" gombra kattintva a program bezáródik.                        | A program az "Exit" gombra kattintva sikeresen bezárja magát.               | Probléma mentes.                |

### Megjegyzések

- Minden teszt sikeresen lefutott, és a program a várt módon működött.
- A felhasználói felület átlátható és könnyen kezelhető.
- A hibakezelés megfelelően van implementálva, figyelmeztető üzenetek segítik a felhasználót.
# Meal Planner

A Meal Planner alkalmazás segítségével a felhasználó egyszerűen megtervezheti napi táplálék-bevitelét. Az alkalmazás azoknak lehet hasznos, akik szeretnének fogyni, tömeget növelni vagy csak egészségesebben étkezni, és ezért fontos nekik a kalória figyelése.

## Szoftver funkciói

### Planner ablak

A planner ablak alatt tudja a felhasználó megtervezni az aznapi táplálék-bevitelét.
Az első listában találhatók az ételeket tartalmazó adatbázis elemei, melyek rendezéséhez a lista feletti lenyíló gomb többféle lehetőséget kínál. Ha kiválasztunk egy ételt, akkor a jobb oldalon megjelenik a teljes neve és a hozzá tartozó adatok. A tápálékterv készítésének többféle módszere van:

1. A felhasználó kiválaszt egy ételt az első listából, majd a lista alatti "Add" gombra kattint, ami felviszi az ételt a "Selected" listába. Ezt a lépést többször is meg lehet ismételni, ameddig a felhasználó jónak látja. Ha valamit el akar távolítani a kiválasztott ételek közül, akkor a "Remove" gombra kattintva megteheti azt. A kiválasztott ételek összesített kalória-mennyisége a listától jobbra látható.

2. Ha a felhasználó nem szeretné maga kiválasztani az ételeket, akkor az alsó, sárga sávban a kívánt kalória és ételmennyiség beállítása után generálhat egy véletlenszerű listát az ételekből. (A generátor nyilván annál jobban működik, minél több étel van az adatbázisban, és minél valósághűbb értékekkel kell dolgoznia)


Miután kész a kiválasztott lista, a "Save Day" gombra kattintva elmenthető a nap az adatbázisba. (Amennyiben üres a lista, úgy nem menti el.)

### Meals ablak

Itt láthatóak az ételek, és az adataik. Ha új ételt szeretnénk hozzáadni, akkor az "Add New" gombra kattintva megtehetjük azt, és a "Save" gombra kattintva elmenthetjük az adatbázisba.

### Progress ablak

Ha vannak elmentett napjaink, akkor az itt lévő diagram megmutatja, hogy miként alakult eddig a napi kalóriamennyiség. Az alatta lévő táblázatban pedig láthatóak a pontos adatok.


> ### Generátor működése
> 1. Az első random étel kiválasztása a listából.
> 2. A kiválasztott étel kalóriájának kivonása a megadott mennyiségből.
> 3. A maradék kalória átlagolása a maradandó étel-adagszámmal.
> 4. Az átlaghoz legközelebb eső ételek megkeresése és listázása.
> (5. Kiírás)

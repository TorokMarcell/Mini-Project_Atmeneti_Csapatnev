## Cél:
#### A rendszer célja, hogy tesztelje és feljessze a felhasználók (legfőképpen diákok) matematikai tudását is szinten tartja azt. Ezt különböző nehézségi szintekkel és korlátlan próbálkozási lehetőségekkel próbáljuk elérni. A feladatok megoldása után egy felhasználó név megadása mellett meg tudják majd figyelni a pontszámaikat, így nyomon követve a fejlődésüket. Emellet az iskolákban minden más közösségi média platformot letiltunk, így is elérve azt, hogy a tanulók figyelmét ne vonja el semmi a tanulástól. Más felhasználók pedig önfejlesztés céljából vennék igénybe a programot, így az ő oldalukról semmilyen korlátozást nem lesz alkalmazva.

## 1. Bevezetés
#### Mai rohanó világunkban a közösségi média megpecsételi fiatal tanulóink életét, illetve az esetlegesen bekövetkező online oktatás is megnehezítené a dolgukat a tanulásban. Iskolánk vezetősége ezért állt elő azzal a brilliáns ötlettel, hogy készítsünk a napközis illetve, rendes tanulók számára oktató jellegű játékokat. Ehhez nem kell mást tenni, mint minden egyéb weboldalt a délutának órákban letiltani az iskola hálózatában (értsük ezalatt a Facebook, Youtube és más egyéb platformokat), és csak a diákok tanítása, fejlesztése céljából készített és telepített programokat engedélyezni.

## 2. Projekt terv
#### A rendszer létrehozásához rendelkezésre álló erőforrások: A felhasználó által használt notebookok/asztali számítógépek melyeknek rendelkezniük kell egy futó opercációs rendszerrel(Windows 7, Windows 10, Linux)

## 3. Résztvevők és főbb szereplők:
- Bálint Ádám: Fő oldal, a program fejlesztése és dizájn,tesztelés.
- Deme Viktor: A program fejlesztése és dizájn, tesztelés.
- Török Marcell: A program fejlesztése és dizájn, tesztelés.
- Katona Bálint: A program fejlesztése és dizájn, tesztelés.
- Czafik Milán: A fejlesztés felülvizsgálása.

## 4. Mérföldkövek:
1.    Feladatok kiosztása megegyezés és tudás szerint.
2.   Dokumentációk, leírások képernyő tervek véglegesítése.
3.  Git repo folyamatos frissítése amikor akármi elkészül.
4.   Folyamatos kapcsolattartás a projektben résztvevőkkel.
5.    Tesztelési folyamatok befejezése.
6.   Felkészülés a projekt bemutatására.
7.  Bemutatás.

## 5. Funkcionális terv
### A program funkcionális leírása:
#### Futtatás után egy kezelőfelület jelenik meg, ahol 3 menüpont fogad. Egy indítás menüpont, egy eredmények menüpont, ahol az eddigi eredményeink nézhetőek meg, illetve egy kilépés menüpont. Az indításra kattintva felugrik egy ablak, ahol el kell döntenie a felhasználónak, hogy mit szeretne gyakorloni (összeadás, kivonás, szorzás, osztás), valamint milyen nehézséggel szeretné azt megtenni (könnyű, közepes, nehéz, vegyes). Miután a felhasználó eldöntötte, mit szeretne gyakorolni, egy másik ablak jelenik meg, rajta egy pont számlálóval, két számmal és egy műveletjellel, egy számlálóval (mely a hátralévő időt mutatja) és 10 feladattal. Ezen kívül a helyes/helytelen megoldások számai is fel van tűntetve (Helyes válasz 1 pont, helytelen 0). Ha az összes feladatot befejeztük, megkapjuk a helyes feladatokért kapott pontszámokat és el tudjuk menteni az eredményünket egy a felhasználó által begépelt névvel.

## 6. Fizikai terv
### Futtatás módja:
- Minden számítógépen lokálisan fut majd
### Futtató környezet:
- .NET Framework
### Elérhető operációs rendszerek:
- Windows 7
- Windows 8
- Windows 8.1
- Windows 10
### Szoftver moduljai:
- A szoftvert két Windows Form Application tesz össze
### Fejlesztői környezet:
- Visual Studio C#

## 7. Teszt terv
### Leírja a teszt típusát, a metodológiáját és a riport készítés módszerét. Emellett meghatározza a teszt elvárásokat, a teszt-esetek elvárt eredményeit, sikerességének kritériumait, a kockázatok kezelését és a hatáskörön kívül eseteket.
### Fejlesztői teszt:
- A fejlesztői tesztelés célja a rendszer alapvető funkcióinak ellenőrzése, a hibakezelés és az alapvető funkciók működésének vizsgálata.
### Prototípus teszt:
- A prototípus tesztelés célja a rendszer már működő moduljainak önálló tesztelése, a modulon belüli hibák azonosításának és kiküszöbölésének érdekében.
### Integrációs teszt:
- Az integrációs teszt célja a rendszer más rendszerekhez történő illesztésének vizsgálata, a több rendszereken keresztül átívelő funkciók tesztelésének érdekében.Az adatmigrációs tesztelés az integrációs teszteléshez tartozik, ennek lényege, hogy a bevezetendő rendszerbe áttöltik azokat az adatokat, amelyekkel a rendszer dolgozni fog és letesztelik a betöltött adatok, illetve az adatokat kezelő funkciók helyességét.
### Elfogadási teszt:
- Az elfogadási teszt (angolul User Acceptance Test) célja a rendszer teljes funkcionalitásának vizsgálata a felhasználók szemszögéből.
### Terheléses teszt:
- A terheléses teszt célja a tervezett kapacitások, valamint a rendelkezésre álló növekedési potenciál meghatározása.
### Go live teszt:
- A go-live teszt egy próbaélesítés, melynek során a korábbi rendszerek továbbra is üzemelnek annak érdekében, hogy az élesítéskor keletkező problémák ne befolyásolják a normál üzemi működést.
### Megbízhatósági teszt:
- A megbízhatósági teszt célja, hogy a rendszerrel elvégezhető feladatokról - lehetőleg mindről -megmutassa, hogy hosszú időn át képesek determinisztikusan és konzisztensen működni adottkörnyezetben. Más aspektusból – alacsonyabb tesztszinten – azt várjuk el egy-egy művelettől, hogyugyanazt az eredményt kapjuk, ha újra és újra végrehajtjuk adott körülmények között.
### Hordozhatósagi teszt:
- A hordozhatósági teszt célja a különböző platformokon működő képes használat(Windows operáiós rendzserek, Linux, Android, IOS)
### Megfelelési teszt:
- A szerződésekben foglaltakat vizsgálja, hogy a projekt minden része megfelel e a szerződött fél kritériumaival.

## 8. Specifikáció
#### A specifikáció (software specification) célja a feladatot megoldó szoftver funkcióinak tisztázása, a rendszerre és a fejlesztésre vonatkozó elvárások megadása feltérképezi a követelményeket felhasználói, valamint fejlesztői szemszögből, lépései: megvalósíthatósági elemzés követelmény megállapítás és elemzéskövetelmény specifikáció eredménye a szoftver követelmény-leírása  Egy rendszer funkcionális követelményei leírják, hogy a rendszernek milyen funkciókkal kell rendelkezni, hogyan kellene működnie 
### Nemfunkcionális követelmények:
- megbízhatóság
- válaszidő
- tárfoglalás
- rugalmasság
- robosztusság
- hordozhatóság

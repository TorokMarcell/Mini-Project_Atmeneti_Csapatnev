| Teszteset               | Elvárt eredmény                                                                                                     | 
|-------------------------|---------------------------------------------------------------------------------------------------------------------| 
| Helytelen adat megadása | A művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy miért és milyen adatok megadásával történhet.|
| Helyes adat megadása    | Megtörténik a művelet.                                                                                              |

Tesztelő: Deme Viktor

Tesztelés dátuma: 2022.október.10.

| Tesztszám | Rövid leírás                                             | Várt eredmény                                                                   | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------------------------------|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | Helytelen adat (betű string) bevitele a válasz mezőbe    | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond. | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond.| Nem találtam problémát.   |
| Teszt #02 | Helytelen adat (karakter char) bevitele a válasz mezőbe  | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond. | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond.| Nem találtam problémát.   |
| Teszt #03 | Helyes adat (int) bevitele a válasz mezőbe  | Művelet végrehajtódik, a program tovább halad az értéknek megfelelően. | Művelet végrehajtódik, a program tovább halad az értéknek megfelelően.| Nem találtam problémát.   |
| Teszt #04 | Helyes adat (int), helytelen végeredmény bevitele  | A művelet végrehajtódik, az eredményként a ,,helytelen" visszajelzést kapjuk. | A művelet végrehajtódik, az eredményként a ,,helytelen" visszajelzést kapjuk.| Nem találtam problémát.   |
| Teszt #05 | Helyes adat (int), helyes végeredmény bevitele  | A művelet végrehajtódik, az eredményként a ,,helyes" visszajelzést kapjuk, a program tovább halad a következő példára. | A művelet végrehajtódik, az eredményként a ,,helyes" visszajelzést kapjuk, a program tovább halad a következő példára.| Nem találtam problémát.   |

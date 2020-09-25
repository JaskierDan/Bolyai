# Assignment 1.

## Feladat

Egészítsd ki a form-okat az index.html fájlban úgy hogy az egyik egy felhasználói profil létrehozásáért legyen felelős míg a másik a már meglévő felhasználók beléptetéséért.
Ennek érdekében hozz létre két php fájlt, az egyik neve legyen signup.php míg a másik legyen login.php. Használd a **header("Location: ")** function-t valamint ne felejtsd el
a POST-ot igénybe venni. A jelszavak legyenek hash-elve. Belépéskor írja ki, hogy "_Sikeres!_" vagy "_Sikertelen!_" a jelszó helyességétől függően.

Minta: [2020.09.11.](https://github.com/JaskierDan/Bolyai/tree/master/2020-2021/2020.09.11./)

### Adatbázis
* Neve: **loginform**
* Tábla neve: **users**
* Oszlopok: **id(_int, primary key, auto increment_), username(_tinytext_), password(_longtext_)**

## Pontozás
* 1 pont - Adatbázis helyes létrehozása
* 3 pont - Form-ok megfelelő kiegészítése
* 3 pont - Lehet létrehozni felhasználót (adatokat el is menti az adatbázisba)
* 3 pont - Felhasználók be tudnak lépni a megadott adataikkal

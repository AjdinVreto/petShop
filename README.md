# RS2 - Seminarski - PetShop

**PetShop** je aplikacija za podršku rada trgovine za kućne ljubimce. Aplikacija omogućava pregled ponude trgovine, obavljanje narudžbi, ocjenjivanje te komentarisanje proizvoda. Aplikacija je podijeljena u dva dijela:
-	desktop aplikacija namijenjena administratorima za upravljanje sadržajem, te uposlenicima za prodaju i
-	mobilna aplikacija namijenjena korisnicima za pregled i kupovinu proizvoda.

## Kredencijali za prijavu   

### Desktop aplikacija

- Administrator

    ```
    Korisnicko ime: admin                     Korisnicko ime: desktop
    Lozinka: test                             Lozinka: test           
    ```
    
- Uposlenik

    ```
    Korisnicko ime: uposlenik
    Lozinka: test           
    ```    

### Mobilna aplikacija

- Klijent

    ```
    Korisnicko ime: mobile              Korisnicko ime: korisnik
    Lozinka: test                       Lozinka: test   
    ```
    

## Pokretanje aplikacija
1. Kloniranje repozitorija

    ```
    git clone https://github.com/AjdinVreto/petShop.git
    ```
2. Otvoriti klonirani repozitorij u konzoli

3. Pokretanje dokerizovanog API-ja i DB-a

    ```
    docker-compose build
    docker-compose up
    ```
    
4. Otvoriti petshop_mobile folder

    ```
    cd petshop_mobile
    ```

5. Dohvatanje dependecy-a

    ```
    flutter pub get
    ```
    
6. Pokretanje mobilne aplikacije

    ```
    flutter run
    ```   
    
7. Pokretanje desktop aplikacije

    ```
    1. Otvoriti solution u Visual Studiu
    2. Desni klik na solution
    3. Set Startup Projects
    4. Multiple startup projects
    5. PetShop.WinUI - Start
    6. OK
    7. CTRL + F5
    ```    

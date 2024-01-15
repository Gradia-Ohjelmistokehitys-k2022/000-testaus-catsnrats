# 02 Refaktorointi

BankAccount luokka sisältää tiedon sekä asiakkaasta, että tämän tilistä. Mitä jos asiakkaalla on useita tilejä? Entä jos asiakas sulkee tilin ja avaa toisen? Tämänhetkinen ratkaisu ei selkeästi ole riittävä. 

## Tehtävä

1. Halkaise Pankkitehtävän BankAccount luokka kahdeksi luokaksi: Asiakas ja Tili (tai BankCustomer ja BankAccount).
2. Huomaa että yhdellä asiakkaalla voi olla useita tilejä. Miten toteutat tämän?
3. Asiakkaalle pitää voida lisätä tilejä ja poistaa tilejä. Lisää tarvittavat metodit.
4. Tarkista että aiemmat yksikkötestit edelleen toimivat ja testaavat edelleen järkeviä asioita.
5. Lisää tarvittavat yksikkötestit joilla tarkistat että ratkaisusi, sekä uudet metodit toimivat.

## Vinkkejä

Muista että Visual Studiossa voit luoda aksessorit (accessors, getters, setters) luokan kentistä (fields) automaattisesti valitsemalla ylävalikosta edit -> refactor -> encapsulate fields.

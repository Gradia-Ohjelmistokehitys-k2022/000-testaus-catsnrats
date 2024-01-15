# Testauksen teoriaa

Ohjelmistokehittäjän tehtävä on tuottaa koodia ja tämä tapahtuu usein hyvin tiukoissa aikarajoissa. Tämän takia kehittäjä ei aina pysty ottamaan kaikkia vaikuttavia tekijöitä huomioon. Tässä avuksi tulee testaajat, joiden tehtävänä on tutkia näitä erilaisia tekijöitä, vuorovaikutuksia ja niiden yhdistelmiä, sekä selvittää minkälaisia ei-toivottuja vaikutuksia niistä voi aiheutua.

Testaajan tehtävä on pyrkiä tunnistamaan ohjelmiston puutteita, ristiriitaisuuksia ja väärinkäsityksiä. Ongelmia voi olla esimerkiksi ohjelmiston koodissa tai suunnittelussa. Jotkut ongelmat voivat myös olla täysin inhimillisten tekijöiden, kuten esimerkiksi automaattisten oletusten, aiheuttamia. Ohjelmistotestauksessa onkin hyvin pitkälti kyse kriittisestä ajattelusta ja sellaisten kysymysten kysymisestä, joilla pyritään selvittämään, miten ohjelmisto saattaisi toimia ei-toivotulla tavalla, tai olla toimimatta kokonaan. 

Ohjelmistotestauksen tehtävä on selvittää mikä ohjelmiston nykytila oikeasti on verrattuna siihen, mitä jokin määrittely sanoo, että sen pitäisi olla ja varmistaa, että tehdään oikeaa tuotetta ja että tuote on tehty oikein. Ohjelmistotestaus on siis vertailua siitä, että onko tuote tehty kuten suunniteltu ja täyttääkö se asiakkaan tarpeet. 


## Ajattele koodia kuin testaaja

Mieti ohjelman toimintaa myös käyttäjän näkökulmasta, ajattele erilaisia ääritapauksia jo ennen kuin alat koodaamaan. 
Lisää tekstiä..


# Testauksen tasot ja tehtäviä
Testaus voidaan jakaa seuraaviin tasoihin

 - Yksikkötestaus, jossa testitapaus rajoittuu yhteen komponenttiin. Tällöin testeissä testataan yksiköitä, osia koodista. Siinä varmistetaan nimenomaan näiden pienien osien oikeellisuus. 

- Integraatiotestaus, jossa testaus liittyy muutamaan komponenttiin ja niiden väliseen toimintaan, eli integraatioon. 

- Järjestelmätestaus, joka on koko järjestelmän kattavaa testausta. Siinä keskitytään koko ohjelmistoon ja sen variaatioihin käytössä. Tätä edeltää kehityksen aikana tehdyt yksikkötestit. 

- Hyväksymistestaus, joka suoritetaan kohdeympäristössä tai sitä simuloiden. 

Edellä mainittu, neljään vaiheeseen jaettu ohjelmistotestaus tunnetaan myös nimellä v-malli.

## V-malli 

Kokonaisuudessa testausprosessiin kuuluu monia vaiheita. Työvaiheita ovat ainakin testauksen suunnittelu, testitapausten luominen, testitapausten suorittaminen, testiajojen tulosten arviointi ja niistä raportointi. 

## Yksikkötestaus

Yksikkötestaus tarkoittaa ohjelmiston pienimmän osan esimerkiksi yhden ohjelman tai ohjelmalohkon toiminnan testaamista. Yksikkötesteillä varmistetaan, että ohjelman pienimmätkin osat toimivat odotetulla tavalla, ja että mahdolliset virhetilanteet on ennakoitu. Kun yksikkötestejä kirjoitetaan ja ajetaan, on tärkeää tarkistella testitapauksen lopputulosta kokonaisvaltaisesti. Yksikkötestaamisen tärkeys ja hyöty tulee näkyviin kehitysprosessin aikana erityisesti silloin, kun koodiin joudutaan tekemään muutoksia.

## Integraatiotestaus

Integraatiotestauksessa testataan monien ohjelman komponenttien yhteistoimintaa. Integraatiotestauksessa yritetään löytää virheitä, jotka eivät tulleet esiin yksikkötesteissä. Testeissä suoritetaan tietynlaisia polkuja, jotka hyödyntävät useita eri yksiköitä tai laajempia komponentteja, ja lopuksi tarkastellaan tuloksia niiden toiminnasta. Kun projekti etenee ja yksiköt valmistuvat, testattavien polkujen määrä lisääntyy ja samalla ne pitenevät. Tällöin on hyvä vaihtaa regressiotestaukseen, eli suoritetaan uudelleen aiemmin suoritettuja testejä, joilla pyritään varmistamaan, että tehdyt muutokset ja lisäykset eivät aiheuta ongelmia aiemmin toteutettujen elementtien toiminnassa. 

## Järjestelmätestaus

Järjestelmätestaus tarkoittaa kokonaisen ohjelmiston testaamista, jossa tarkastellaan vastaako ohjelmisto sille asetettuja vaatimuksia ja käyttötarkoitusta. Järjestelmätestaus tulisi suoritettaa aidossa ympäristössä, johon kuuluvat esimerkiksi käytettävä laitteisto, tietokannat ja ohjelmiston käyttäjät. Järjestelmätestauksessa ohjelmistoa pyritään käyttämään siinä käyttötarkoituksessa ja ympäristössä, johon se on suunniteltu. 

Järjestelmätestausvaiheessa tulisi keskittyä ohjelmiston toiminnan varmistamiseen ja hienosäätöön. Mikäli testaamisen aiemmissa vaiheissa ei ole kiinnitetty tarpeeksi huomiota itse testaamiseen ja virheiden ehkäisyyn, huomataan se yleensä tässä vaiheessa. Ohjelmointivirheiden korjaaminen tässä vaiheessa on yleensä erittäin aikaa vievää ja kallista. Mahdollisten lisäominaisuuksien toteuttaminen jätetään myöhemmäksi. 

## Hyväksymistestaus

Hyväksymistestin tulisi olla lähinnä demonstraatio, jossa osoitetaan, että järjestelmä vastaa vaatimuksia. Hyväksymistestaukselle pyritään selvittämään kriittisten liiketoimintaprosessien toiminnan lisäksi esim. integraatioiden toimivuus, suorituskyky ja mahdolliset virhetilanteet. Hyväksymistestaus perustuu siis pitkälti asiakkaan vaatimuksiin. 

Hyväksymistestauksessa testataan siis kokonaista valmista tuotetta ja testaajina kannattaa käyttää tuotteen loppukäyttäjiä. Testiympäristön tulisi olla myös mahdollisimman lähellä todellista loppukäyttäjän ympäristöä. Hyväksymistestaus on ajallisesti melko lyhyt vaihe, koska sen tarkoituksena on vain osoittaa, että vaatimukset on täytetty. Tässä kohtaa virheiden löytyminen ei ole enää ensisijaisena tavoitteena.  Mikäli tässä vaiheessa löydetään virheitä, voi niiden korjaaminen tulla kalliiksi. Yleensäkin suurten muutosten tekemistä projektin loppuvaiheessa pitää harkita tarkkaan. Muutostarpeet on järkevintä jättää vasta seuraaviin versioihin. 


## Testauksen automatisoiminen
https://resources.github.com/ci-cd/



Lähteet: The Pragmatic Programmer by Davin Thomas and Andrew Hunt, 20th Anniversary Edition

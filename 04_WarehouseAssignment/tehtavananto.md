# Warehouse

Tehtävänäsi on tutustua olemassa olevaan ohjelmakoodiin ja tehdä siihen yksikkötestit. Tee jokaiselle metodille alla olevat testit sekä keksi jokaiselle metodille kaksi omaa testiä. Koita miettiä laajasti erilaisia testitapauksia.

## Alla esimerkkejä mahdollisista yksikkötesteistä:

AddToStock:

- Lisää esine, jolla on määränä kunnollinen positiivinen arvo.
- Lisää esine, jolla on määränä arvo nolla.
- Lisää esine, jolla on negatiivinen arvo.
- Lisää esine, jolla on mielestäsi kohtuuttoman suuri arvo.

InStock:

- Tarkista onko esinettä varastossa positiivinen määrä (esim. datarown:n avulla).
- Tarkista onko varastossa esine määrällä nolla.
- Tarkasta voiko esinettä olla varastossa negatiivinen määrä.

TakeFromStock:

- Ota oikeanlainen määrä esineitä varasosta.
- Ota viimeinen esine varastosta.
- Ota isompi määrä kuin varastossa on tavaraa.
- Ota varastosta negatiivinen määrä.
- Ota varastosta tavara, jota ei ole olemassa.
- Ota varastosta nolla esinettä.

StockCount:

- Tarkista esineiden lukumäärä esineeltä, jota on positiviinen määrä.
- Tarkista esineiden määrä, joita on nolla kappaletta.
- Tarkista esineiden lukumäärä, joita on negatiivinen määrä.

## Funktionaaliset testit
Tee omia testejä, joilla varmistat, että asiat toimivat yhdessä. Alla esimerkkejä:

- Tee testi, joka testaa, että jos samaa esinettä lisätään uudestaan, niin esineitä on oikea määrä.
- Tee testi, jossa lisäät varastoon esineen ja varmista, että liian isolla määrällä metodi heittää poikkeuksen.
- Tee testi, jossa lisäät esineen varastoon, katsot, että esine on varastossa, poistat esineen ja varmistat, että kaikki meni oikein.


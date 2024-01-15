# 01 MS Test Pankki

## Ms Test - Yksikkötestaus

Yksikkötestauksella tarkoitetaan lähdekoodiin kuuluvien yksittäisten osien kuten luokkien ja niiden tarjoamien metodien testaamista. Luokkien ja metodien rakenteen suunnittelussa käytettävän ohjesäännön — jokaisella metodilla ja luokalla tulee olla yksi selkeä vastuu — noudattamisen tai siitä poikkeamisen huomaa testejä kirjoittaessa. Mitä useampi vastuu metodilla on, sitä monimutkaisempi testi on. Jos laaja sovellus on kirjoitettu yksittäiseen metodiin, on testien kirjoittaminen sitä varten erittäin haastavaa ellei jopa mahdotonta. Vastaavasti, jos sovellus on pilkottu selkeisiin luokkiin ja metodeihin, on testienkin kirjoittaminen suoraviivaista.

## Tehtävä 1

1. Tee alla olevan linkin ohjeiden mukaan pankkisovellus ja siihen testi. Varmista että ymmärrät mitä kopioimasi koodi tekee. Korjaa lopuksi ohjeiden mukaan koodiin tahallisesti kirjoitettu virhe.
2. Credit-metodia ei testata lainkaan. Lisää yksikkötesti joka tarkistaa että Credit-metodi toimii oletetulla tavalla.

## Tehtävä 2

3. Toistaiseksi esitellyt testit ovat ns. hyvän päivän testejä (fair weather tests). Ne testaavat metodien toimintaa kun syötteet ovat kunnossa. Mitä jos vaikkapa Debit-funktiota kutsutaankin negatiivisella saldolla. Funktion pitäisi heittää keskeytys tässä tilanteessa. Kirjoita yksikkötesti joka yrittää syöttää negatiivisen saldon Debit funktiolle ja tarkistaa, että funktio heittää ArgumentOutOfBounds keskeytyksen.

Vinkki: Etsi esimerkkiä "Assert.ThrowsException"-tarkistuksesta.

Linkki:
https://docs.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019




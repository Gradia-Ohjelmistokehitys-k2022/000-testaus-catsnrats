# 03 Funktionaalinen testaus

Olemme tähän mennessä kirjoittaneet pankkitehtävään yksikkötestejä. Yksikkötesteillä pidetään huoli siitä että yksittäiset funktiot/metodit/aliohjelmat toimivat kuten oletetaan. Nyt siirrymme laajempien kokonaisuuksien testaamiseen.
Funktionaalisilla testeillä tarkistetaan että ohjelman toiminnot toimivat suunnitellulla tavalla. Ne testaavat siis useampien metodien toimintaa, sekä olioiden tilojen (siis olioiden sisältämän datan) toimintaa jonkin toiminnon suhteen. Toiminto on tyypillisesti jokin käyttäjän tai toisen järjestelmän tai järjestelmän osan tekemä esim. "Uusi asiakas avaa käyttö- ja säästötilit." tai "Asiakas siirtää rahaa toisen asiakkaan tilille."

## Tehtävä

Asiakkaan pitää voida siirtää rahaa tililtä toiselle.

1. Luo tarvittava metodi joka mahdollistaa rahansiirron tililtä toiselle. Huomaa että rahansiirrot kohdistuvat tililtä tilille. Mieti ja perustele tulisiko rahansiirtometodin olla BankAccount-olion osa, vai staattinen BankAccount-luokan osa? Ts. onko tilinsiirtofunktio muotoa
	public void LahetaRahaa(BankAccount toinentili)
	vai muotoa
	public static void SiirraRahaa(BankAccount lahtotili, BankAccount kohdetili, double siirtoSumma)

2. Luo rahansiirtofunktiollesi yksikkötesti(t).

3. Luo lisäksi funktionaalinen testi/testit jo(t)ka testaa(vat) koko asiakkaan polun tilin avaamisesta aina rahan siirtämiseen toisen asiakkaan tilille.

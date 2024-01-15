# TODO-listan toiminnot ja niiden testaaminen

Pojektista löydät TodoList- ja TodoTask luokat sekä ohjelman pääohjelman. Tutustu ohjelmakoodiin ja sen toimintoihin. Tee olemassa oleville metodeille vähintään kolme yksikkötestiä metodia kohti. Kolme on hyvä nyrkkisääntö ja alku testaukselle, mutta mieti toimintaa aikaisemman opitun perusteella useasta eri kulmasta. Jos ohjelma ei toimi oikein, niin jatkokehitä luokkia ja metodien toimintaa. Esimerkiksi nyt ohjelman TodoTask-recordissa on kolme ominaisuutta TaskDescription, Id ja IsCompleted. Hyvässä todo-apissa on varmasti muitakin tietoja, joten kehitä recordia tarpeen mukaan tai muuta se tarpeen vaatiessa luokaksi! Alla on valmiina oleva koodi, jota olisi syytä jatkokehittää.
```c#
public record TodoTask(string TaskDescription) // ota selvää recordin toiminnasta
    {
        public int Id { get; init; } //init muuttaa arvon niin, että sitä ei voi muuttaa jälkeenpäin.
        public bool IsCompleted { get; init; } //Onko init järkevä IsCompleteded kentän arvoksi?
        // mitä muuta tänne olisi tarpeen lisätä? Olisivatko deadline, tehtävän kuvaus ym. hyödyllisiä.


```

Myös projektin metodit ovat alttiita kaikenlaisille virhetilanteille.

```c#
        public void AddItemToList(TodoTask item)
        {
            _taskCounter++;
            _tasks.Add(item with { Id = _taskCounter});

        }

        public void RemoveItemFromList(TodoTask item)
        {
            if (_tasks.Contains(item))
            {
                _tasks.Remove(item with { Id = _taskCounter-- });

            }

        }

        public void CompleteItem(int id)
        {
            var item = _tasks.First(x => x.Id == id);
            RemoveItemFromList(item);
        }

```
## Tee metodeille tarvittavat testit. Alta löydät ideoita ja vaatimuksia.

 1. AddItemToList(TodoTask item)-metodin mahdolliset testit:
    - Lisää yksi tehtävä listaan onnistuneesti.
    - Lisää useampi tehtävä listaan. Kasvaako laskuri oikein?
    - Lisää tehtäviä eri arvoilla.
    - Tehtävä, jossa on erikoismerkkejä.
    - Mitä tapahtuu, jos lista on tyhjä?
    - Voiko tehtävä/itemi olla tyhjä?
    - Listassa on jo valmiita arvoja.
    - Voiko listan maksimi ylittyä?
  
2. public void RemoveItemFromList(TodoTask item)-metodin mahdolliset testit:
    - Poista tehtävä listasta. Toimiiko laskuri oikein?
    - Poista tehtävä tyhjästä listasta.
    - Poista viimeinen tehtävä listasta.
    - Poista tietty tehtävä listasta.
    - Poista tehtävä, jota ei ole olemassa.
    - Poista useampi tehtävä peräkkäin.

  
3. public void CompleteItem(int id)-metodin mahdolliset testit:
     - Merkitse tehtävä tehdyksi id:n perusteella. 
     - Merkitse listan viimeinen tehtävä tehdyksi.
     - Merkitse tehtävä, jota ei ole olemassa tehdyksi.

Keksi lisää omia testejä!




// See https://aka.ms/new-console-template for more information

using System;

namespace MathOperations 
{
    // sisältää laskutoimitukset joita Tests-luokan testimetodit testaa
    public class Calculations
    {
        public static void Main()
        {
            KayttajanSyote();
        }
        static void KayttajanSyote()
        {
            // Tehtävän 1.2 (AAA). Käyttäjän syötteen testaamisen osa.            
            // arrange
            string? uLuku;
            int luku1;
            Console.WriteLine("Anna kokonaisluku: ");
            uLuku = Console.ReadLine();
            luku1 = Convert.ToInt32(uLuku);
            if (luku1 > 100) // päättää ohjelman jos ehto ei toteudu
            {
                Console.WriteLine("Annoit liian suuren luvun.");
                return;
            }
            // act
            double tulos = Calculations.Eksponentti(luku1);
            // demo assert
            Console.WriteLine($"Tulos: {tulos}");
            Console.WriteLine(tulos == 100 ? "Test pass" : "Test failed");
        }

        // Tehtävä 1.1 toiminto
        public static int VahennaLuvut(int a, int b)
        {
            return a - b;
        }

        // Tehtävä 1.2 metodi
        public static double Eksponentti(int a)
        {
            return Math.Pow(a, 2);
        }

        // Tehtävä 1.3 metodi
        public static double SquareRoot(int number)
        {
            // Negatiivisen luvun tarkistus
            if (number < 0)
            {
                throw new ArgumentException("Syötteen pitää olla positiivinen luku.");
            }

            return Math.Sqrt(number);
        }

        // Tehtävän 2.1 metodi
        public static double PieninLuku(List<double> luvut)
        {
            if (luvut == null || luvut.Count == 0) // onko lista null tai tyhjä
            {
                throw new ArgumentException("Lista ei voi olla tyhjä tai 'null'.");
            }

            double pienin = luvut[0]; // alustaa muuttujan 'pienin' listan luvut eka luvulla

            foreach (var luku in luvut) // looppi käy listan luvut läpi ja...
            {
                if (luku < pienin) // ...tarkistaa onko luku pienempi listalla jo olevaa lukua ja päivittää muuttujan 'pienin'
                {
                    pienin = luku;
                }
            }
            return pienin; // iteroinnin jälkeen palauttaa pienimmän arvon
        }

        // Tehtävän 2.2 metodi
        public static int SuurinLuku(List<int> luvut)
        {
            int suurin = luvut[0];

            foreach (var luku in luvut)
            {
                if (luku > suurin)
                {
                    suurin = luku;
                }
            }
            return suurin;
        }

        // Tehtävän 2.3. metodi
        public static float LukujenKeskiarvo(List<float> luvut)
        {
            float summa = 0;

            foreach (var luku in luvut) // kasvattaa summaa
            {
                summa += luku;                
            }
            return summa / luvut.Count; // jakaa summan luvut listan elementtien määrällä
        }
    }    
}
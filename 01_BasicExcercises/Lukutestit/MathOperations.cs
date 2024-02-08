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
            // Tehtävän 1.1 (AAA). Käyttäjän syötteen testaamisen osa.            
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
    }    
}
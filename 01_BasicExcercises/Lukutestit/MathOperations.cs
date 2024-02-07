// See https://aka.ms/new-console-template for more information

using System;

namespace MathOperations 
{
    // sisältää laskutoimitukset joita Tests-luokan testimetodit testaa
    public class Calculations 
    {
        public static void Main()
        {
            // Tehtävä 1.1 muuttujat
            int luku1 = 42;
            int luku2 = 10;
            int tulos = VahennaLuvut(luku1, luku2);
            Console.WriteLine($"Erotus: {luku1} - {luku2} = {tulos}");        
        }

        // Tehtävä 1.1 toiminto
        public static int VahennaLuvut(int a, int b)
        {
            return a - b;
        }
    }    
}
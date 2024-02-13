using MathOperations;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MS_Test
{
    [TestClass]
    public class CalculusTest
    {
        [TestMethod]
        public void VahennaLuvut_Testi()// Teht. 1.1 ensimm‰inen testi
        {
            // arrange
            int luku1 = 42;
            int luku2 = 10;
            // act
            int tulos = Calculations.VahennaLuvut(luku1, luku2);
            // assert
            Assert.AreEqual(32, tulos, "Erotus on v‰‰rin, pit‰isi olla 32");
        }
        [TestMethod]
        public void VahennaLuvut_NegaTesti() // Teht. 1.1 toinen testi erotukselle
        {
            // arrange
            int luku1 = 10;
            int luku2 = 42;
            // act
            int tulos = Calculations.VahennaLuvut(luku1, luku2);
            // assert
            Assert.AreEqual(-32, tulos, "Erotus on v‰‰rin, pit‰isi olla -32");        
        }
        [TestMethod]
        public void VahennaLuvut_NonPar() // Teht. 1.1 kolmas testi NotEequal
        {
            // arrange
            int luku1 = (-10);
            int luku2 = 42;
            // act
            int tulos = Calculations.VahennaLuvut(luku1, luku2);
            // assert            
            Assert.AreNotEqual(0, tulos, "Erotuksen pit‰isi olla -52");
        }
        // ### Teht‰v‰n 1.2 testit ### //
        [TestMethod]        
        public void Eksponentti()
        {
            // arrange
            int luku1 = 10;
            int luku2 = 8; // <= 2^3
            // act
            double tulos1 = Calculations.Eksponentti(luku1);
            double tulos2 = Calculations.Eksponentti(luku2);            
            // assert
            Assert.AreNotEqual(10, tulos1, $"Luvun {luku1} ei pit‰isi olla 2^n");
            Assert.AreEqual(64, tulos2, $"Luvun {tulos2} pit‰isi olla 2^3");
        }
        // ### Teht‰v‰n 1.3 testit ### //
        [TestMethod]
        public void Neliojuuritesti_Positiivinen()
        {
            // Arrange
            int number = 9;
            // Act
            double result = Calculations.SquareRoot(number);
            // Assert
            Assert.AreEqual(3, result, "9:n neliˆjuuri pit‰isi olla 3.");
        }
        [TestMethod]
        public void TestSquareRoot_Zero()
        {
            // Arrange
            int number = 0;
            // Act
            double result = Calculations.SquareRoot(number);
            // Assert
            Assert.AreEqual(0, result, "0:n neliˆjuuri pit‰isi olla 0.");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareRoot_NegativeNumber()
        {
            // Arrange
            int number = -1;
            // Act and Assert (Expecting an ArgumentException)
            double result = Calculations.SquareRoot(number);
        }

        // ### Teht‰v‰n 2.1 testit ### //
        [TestMethod]
        public void PieninPosLukuTesti()
        {
            // Arrange
            List<double> luvut = new List<double> { 5.0, 3.0, 8.0, 1.0, 7.0 };
            // Act
            double tulos = Calculations.PieninLuku(luvut);
            // Assert
            Assert.AreEqual(1.0, tulos, "Pienin luku pit‰isi olla 1.0.");
        }
        [TestMethod]
        public void PieninNegLukuTesti()
        {
            // Arrange
            List<double> luvut = new List<double> { -5.0, -3.0, -8.0, -1.0, -7.0 };
            // Act
            double tulos = Calculations.PieninLuku(luvut);
            // Assert
            Assert.AreEqual(-8.0, tulos, "Pienin luku pit‰isi olla -8.0.");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullListaTesti()
        {
            // Arrange
            List<double> luvut = null;
            // Act and Assert (Expecting an ArgumentException)
            double result = Calculations.PieninLuku(luvut);
        }

        // ### Teht. 2.2 testit ### //
        [TestMethod]
        public void SuurinPosLukuTesti()
        {
            // Arrange
            List<int> luvut = new List<int> { 1, 2, 3, 4, 8, 16 };
            // Act
            int tulos = Calculations.SuurinLuku(luvut);
            // Assert
            Assert.AreEqual(16, tulos, "Luvun pit‰isi olla 16.");
        }
        [TestMethod]
        public void SuurinNegLukuTesti() // "suurin" => l‰hinn‰ nollaa
        {
            // Arrange
            List<int> luvut = new List<int> { -16, -24, -32, -40, -48, -56 };
            // Act
            int tulos = Calculations.SuurinLuku(luvut);
            // Assert
            Assert.AreNotEqual(-24, tulos, "Luvun ei pit‰isi olla -24");
        }
        [TestMethod]
        public void SuurinKahdellaJaollinenLukuTesti()
        {
            // arrange
            List<int> luvut = new List<int> { 3, 4, 5, 6, 10, 20, 150, 225 };
            // act
            int tulos = Calculations.SuurinLuku(luvut);
            // assert
            if (tulos % 2 == 0)
            {
                Console.WriteLine($"{tulos} on kahdella jaollinen");
            }
            else 
            {
                Console.WriteLine($"{tulos} ei ole kahdella jaollinen.");
            }
        }

        /// ### Teht. 2.3 testit ### ///
        [TestMethod]
        public void PositiivistenKeskiarvo()
        {
            // Arrange
            List<float> luvut = new List<float> { 5.0f, 3.0f, 8.0f, 1.0f, 7.0f };
            // Act
            float tulos = Calculations.LukujenKeskiarvo(luvut);
            // Assert
            Assert.AreEqual(4.8f, tulos, "Keskiarvon kuuluisi olla 4.8.");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LaskeKeskiarvo_NullTesti()
        {
            // Arrange
            List<float> luvut = null;

            // Act and Assert (Expecting an ArgumentException)
            float tulos = Calculations.LukujenKeskiarvo(luvut);
        }
        [TestMethod]
        public void NegatiivistenKeskiarvo()
        {
            // Arrange
            List<float> luvut = new List<float> { -5.0f, -3.0f, -8.0f, -1.0f, -7.0f };

            // Act
            float tulos = Calculations.LukujenKeskiarvo(luvut);

            // Assert
            Assert.AreEqual(-4.8f, tulos, "Keskiarvon kuuluisi olla -4.8.");
        }
    }
}
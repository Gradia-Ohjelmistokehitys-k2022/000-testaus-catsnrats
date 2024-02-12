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
    }
}
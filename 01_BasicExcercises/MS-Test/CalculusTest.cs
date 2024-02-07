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
    }
}
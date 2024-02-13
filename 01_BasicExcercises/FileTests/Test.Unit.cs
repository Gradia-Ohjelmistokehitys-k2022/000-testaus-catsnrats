using TestFiles;

namespace FileTests
{
    [TestClass]
    public class TestUnit
    {
        [TestMethod]
        public void ReadFile_ReturnsListOfSettings_IfFileIsNotEmpty()
        {
            // arrange
            List<string> systemConfig = new List<string>();
            string testDir = "D:\\TestiKansio";
            string path = "\\TestiFilu.txt"; // solutionin aseman juuressa, mikäli haluaisi käyttää pelkkää 'pathia' ilman kansiota
            // act            
            //systemConfig = File.ReadLines(path).ToList(); // lukee rivit D:n juuren TestiFilu.txt:sta listaan
            systemConfig = FileOperations.ReadFile(systemConfig, testDir, path);            
            // assert
            Assert.IsTrue(systemConfig.Count > 0);
        }
        [TestMethod]
        public void IsFileEmptyTest()
        {
            // arrange
            List<string> tiedosto = new List<string>();
            string path = "\\TestiFilu.txt";
            // act
            tiedosto = File.ReadLines(path).ToList();
            // assert
            Assert.IsNotNull(tiedosto);
            Assert.IsTrue(tiedosto.Count > 0, $"Tiedoston {path} ei pitäisi olla tyhjä");
        }
    }
}
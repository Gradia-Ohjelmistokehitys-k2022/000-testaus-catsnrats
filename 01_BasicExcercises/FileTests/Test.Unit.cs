using TestFiles;

namespace FileTests
{
    [TestClass]
    public class TestUnit
    {
        [TestMethod]
        public void ReadFile_ReturnsListOfSettings_IfFileIsNotEmpty() // 1. testi
        {
            // arrange
            List<string> fileContent = new List<string>();
            string testDir = "C:\\Windows";
            string path = "\\system.ini";
            // act             
            fileContent = FileOperations.ReadFile(fileContent, testDir, path);            
            // assert
            Assert.IsTrue(fileContent.Count > 0); // onko tiedostossa > 0 "elementti�"
        }
        [TestMethod]
        public void IsFileEmptyTest() // 2. testi: tiedoston pit�isi sis�lt�� merkkej�. Melkein sama kuin testi 1. Ei k�yt� FileOperations-luokan ReadFile metodia.
        {
            // arrange
            List<string> tiedosto = new List<string>();
            string path = "\\TestiFilu.txt"; // tiedosto aseman juuressa
            // act
            tiedosto = File.ReadLines(path).ToList();
            // assert
            Assert.IsNotNull(tiedosto);
            Assert.IsTrue(tiedosto.Count > 0, $"Tiedoston {path} ei pit�isi olla tyhj�");
        }
        [TestMethod]
        public void ReadFile_ThrowsFileNotFoundException_WhenFileDoesNotExist() // 3. testi: tiedostoa ei pit�isi olla olemassa
        {
            // arrange
            List<string> fileContent = new List<string>();
            string testDir = "D:\\TestiKansio";
            string nonExistentFileName = "\\NonExistentFile.txt"; // olematon tiedosto

            // act & assert
            Assert.ThrowsException<System.IO.FileNotFoundException>(() => // lambda-lauseke kutsuu ReadFile funktiota
            {
                fileContent = FileOperations.ReadFile(fileContent, testDir, nonExistentFileName);
            }, $"Expected FileNotFoundException for file {nonExistentFileName}"); // poikkeus odotettu
        }
        [TestMethod]
        public void ReadFile_ReturnEmptyList_WhenFileIsEmpty() // 4. testi: Tiedoston kuuluu olla tyhj�.
        {
            // arrange
            List<string> fileContent = new List<string>();
            string testDir = "D:\\TestiKansio";
            string testFile = "\\TestiFilu.txt";
            string path = System.IO.Path.Combine(testDir, testFile);
            // act
            fileContent = FileOperations.ReadFile(fileContent, testDir, testFile);
            // Lis�tty tarkistus tiedoston luvun ajalle, koska poimi "elementin" tyhj�st� tiedostosta. Muokattu FileOperations-luokkaakin.
            Console.WriteLine($"Tiedoston elementit: {fileContent.Count}");
            Console.WriteLine($"Tiedoston sis�lt�: {string.Join(", ", fileContent)}");
            // assert
            Assert.IsNotNull(fileContent);
            Assert.AreEqual(0, fileContent.Count, $"Tiedoston {path} pit�isi olla tyhj�.");
        }
    }
}
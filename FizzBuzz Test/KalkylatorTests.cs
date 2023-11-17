using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]
        public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException()
        {

            // Arrange
            int randomNummer = 0;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }
        [TestMethod]
        [DataRow("0")]
        public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException2(string output)
        {
            // Arrange
            int randomNummer = 0;

            // Act

            StringWriter sw = new StringWriter();
            Console.SetOut(sw); // Omdirigera konsoloutputen till StringWriter
            Kalkylator.FizzBuzzKalkyl2(randomNummer);
            string result = sw.ToString().Trim(); // Hämta den fångade konsoloutputen och trimma bort eventuella extra mellanslag eller radbrytningar


            // Assert
            Assert.AreEqual(output, result);

        }



    }
}
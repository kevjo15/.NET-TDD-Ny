using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]
        public void N�r_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException()
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
        public void N�r_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException2(string output)
        {
            // Arrange
            int randomNummer = 0;

            // Act

            StringWriter sw = new StringWriter();
            Console.SetOut(sw); // Omdirigera konsoloutputen till StringWriter
            Kalkylator.FizzBuzzKalkyl2(randomNummer);
            string result = sw.ToString().Trim(); // H�mta den f�ngade konsoloutputen och trimma bort eventuella extra mellanslag eller radbrytningar


            // Assert
            Assert.AreEqual(output, result);

        }

        [TestMethod]
        public void TestFizzBuzzKalkylMedInput_WithValidNumber_ShouldPrintFizzBuzz()
        {
            // Arrange
            string userInput = "15";
            string expectedOutput = "FizzBuzz";

            // Omdirigera konsoloutputen till en StringWriter
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Kalkylator.FizzBuzzKalkylMedInput(userInput);

                // H�mta den f�ngade konsoloutputen och trimma bort eventuella extra mellanslag eller radbrytningar
                string result = sw.ToString().Trim();

                // Assert
                Assert.AreEqual(expectedOutput, result);
            }
        }

        [TestMethod]
        public void TestFizzBuzzKalkylMedInput_WithNonNumber_ShouldThrowArgumentException()
        {
            // Arrange
            string userInput = "abc";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => Kalkylator.FizzBuzzKalkylMedInput(userInput));
        }

    }
}
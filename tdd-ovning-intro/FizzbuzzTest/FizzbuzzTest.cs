using Fizzbuzz;

namespace FizzbuzzTest
{
    public class FizzbuzzTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(6, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "Fizzbuzz")]
        [TestCase(7, "7")]
        public void Devide3By5(int numberToCompare, string stringToComapre)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var expectedResult = calculator.DivideBy3And5(numberToCompare);

            // Assert
            Assert.AreEqual(stringToComapre, expectedResult);
        }

        [Test]
        [TestCase("6", "Fizz")]
        [TestCase("16", "Something went wrong.")]
        [TestCase("hej", "Invaild input.")]
        public void NumberIsNumberFizzBuzzOrFizzbuzz(string number, string stringToCompare)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var expectedResult = calculator.NumberIsNumberFizzBuzzOrFizzbuzz(number);

            // Assert
            Assert.AreEqual(expectedResult, stringToCompare);
        }

        // Skriv en funktion som tar användarinput och skriver ut det numret, baserat på samma scenarier som
        // beskrivs ovan. - Om användarinmatning inte är ett nummer, släng ett undantag med
        // meddelandet: "{inputNumber} är inte ett nummer".
        // public void ChooseANumber(string input)
        // try if input = 1 return "You chose number {userInput}.
        //catch if string is not a number.
        // Testet ska kolla om jag tar en nummer eller inte.

        [Test]
        [TestCase("hej")]
        public void IsUserInputANumber_IfNotThrowException(string inputNumber)
        {
            // Arrange
            var calculator = new Calculator();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.UserChooseANumber(inputNumber));
        }
    }
}
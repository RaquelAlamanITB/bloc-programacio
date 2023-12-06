using Modules;

namespace ModulesTest
{
    [TestClass]
    public class MethodsTests
    {
        [TestMethod]
        public void ComparePow_Return_True()
        {
            // Arrange
            int baseNum = 2, exp = 3;

            // Act
            int result = BasicMethods.PowNumber(baseNum, exp);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void ToUpper_WhenUpperIsTrue_Return_Uppercase()
        {
            // Arrange
            bool upper = true;
            string text = "text de prova";

            // Act
            string result = BasicMethods.ToUpper(upper, text);

            // Assert
            Assert.AreEqual("TEXT DE PROVA", result);
        }

        [TestMethod]
        public void ToUpper_WhenUpperIsFalse_Return_Lowercase()
        {
            // Arrange
            bool upper = false;
            string text = "text de prova";

            // Act
            string result = BasicMethods.ToUpper(upper, text);

            // Assert
            Assert.AreEqual("text de prova", result);
        }

        [TestMethod]
        public void NomDelMes_WithValidMonth_ReturnCorrectName()
        {
            // Arrange
            int validMonth = 3; 

            // Act
            string result = BasicMethods.NomDelMes(validMonth);

            // Assert
            Assert.AreEqual("Març", result);
        }

        [TestMethod]
        public void NomDelMes_WithInvalidMonth_ReturnInvalidMessage()
        {
            // Arrange
            int invalidMonth = 13; 

            // Act
            string result = BasicMethods.NomDelMes(invalidMonth);

            // Assert
            Assert.AreEqual("Valor invàlid", result);
        }
    }
}
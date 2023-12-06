using Project;

namespace ProjectTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void IsPositive_InputGreaterThanZero_ReturnsTrue()
        {
            // Arrange: declarem i inicialitzem el valor límit del test
            int num = 5;

            // Act: invoquem el mètode a validar
            bool result = Validate.IsPositive(num);

            // Assert: verifica que es retorna cert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsNegative_InputGreaterThanZero_ReturnsFalse()
        {
            // Arrange: declarem i inicialitzem el valor límit del test
            int num = -5;

            // Act: invoquem el mètode a validar
            bool result = Validate.IsPositive(num);

            // Assert: verifica que es rep fals
            Assert.IsFalse(result);
        }
    }
}
using Project;

namespace ValidateTesting
{
    [TestClass]
    public class ValidateTests
    {
        [TestMethod]
        public void UserAgeMinorFive_ReturnsOnlyName()
        {
            //Arrange
            string userName = "Juan";
            string expected = $"Hola {userName}!";

            //Act
            string result = Validate.PrintMessage(userName);

            //Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void UserAgeBetweenFive18_ReturnsNameMessage()
        {
            //Arrange
            bool userMinor = true;
            string userName = "Juan";
            string expected = $"Hola {userName}!En ser menor d’edat, necessites autorització signada.";

            //Act
            string result = Validate.PrintMessage(userMinor, userName);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void UserAgeBetweenFive18_ReturnsNameMessageKO()
        {
            //Arrange
            bool userMinor = false;
            string userName = "Juan";
            string expected = $"Hola {userName}!En ser menor d’edat, necessites autorització signada.";

            //Act
            string result = Validate.PrintMessage(userMinor, userName);

            //Assert
            Assert.AreNotEqual(expected, result);
        }
    }
}
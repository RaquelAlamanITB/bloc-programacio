using Solutions;

namespace SolucionsTests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void TestValidateNatural()
        {
            StringWriter sw = new();
            Console.SetOut(sw);
            Solution.Validate(1);

            string expected = "És natural";
            Assert.AreEqual(expected, sw.ToString().Trim());
        }

        [TestMethod]
        public void TestValidateNoNatural()
        {
            StringWriter sw = new();
            Console.SetOut(sw);
            Solution.Validate(-1);

            string expected = "No és natural";
            Assert.AreEqual(expected, sw.ToString().Trim());
        }

        [TestMethod]
        public void TestValidateZeroNoNatural()
        {
            StringWriter sw = new();
            Console.SetOut(sw);
            Solution.Validate(0);

            string expected = "És natural";
            Assert.AreNotEqual(expected, sw.ToString().Trim());
        }
    }
}
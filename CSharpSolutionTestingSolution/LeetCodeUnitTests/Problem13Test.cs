namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem13Test
    {
        [TestMethod]
        //Arrange
        [DataRow("III", 3)]
        [DataRow("LVIII", 58)]
        [DataRow("MCMXCIV", 1994)]
        /// <param name="s">string of roman numbers to convert to integer</param>
        /// <param name="expected">expected 's' roman numerals converted to an integer</param>
        public void TestRomanToInt(string s, int expected)
        {
            //Act
            int actual = Problem13.RomanToInt(s);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

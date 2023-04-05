namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem12Test
    {
        [TestMethod]
        //Arrange
        [DataRow(3, "III")]
        [DataRow(58, "LVIII")]
        [DataRow(1994, "MCMXCIV")]
        /// <param name="num">integer to convert to roman numerals in string format</param>
        /// <param name="expected">expected 'num' integer in roman numeral format</param>
        public void TestIntToRoman(int num, string expected)
        {
            //Act
            string actual = Problem12.IntToRoman(num);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

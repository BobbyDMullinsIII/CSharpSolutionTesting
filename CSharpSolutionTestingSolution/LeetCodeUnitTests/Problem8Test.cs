namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem8Test
    {
        [TestMethod]
        //Arrange
        [DataRow("42", 42)]
        [DataRow("   -42", -42)]
        [DataRow("4193 with words", 4193)]
        /// <param name="s">input string to convert to integer</param>
        /// <param name="expected">expected integer from input string clamped to 32-bit</param>
        public void TestMyAtoi(string s, int expected)
        {
            //Act
            int actual = Problem8.MyAtoi(s);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

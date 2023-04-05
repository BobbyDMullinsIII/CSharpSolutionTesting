namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem3Test
    {
        [TestMethod]
        //Arrange
        [DataRow("abcabcbb", 3)]
        [DataRow("bbbbb", 1)]
        [DataRow("pwwkew", 3)]
        /// <param name="s">input string to find longest substring without repeating characters</param>
        /// <param name="expected">expected substring length</param>
        public void TestLengthOfLongestSubstring(string s, int expected)
        {
            //Act
            int actual = Problem3.LengthOfLongestSubstring(s);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

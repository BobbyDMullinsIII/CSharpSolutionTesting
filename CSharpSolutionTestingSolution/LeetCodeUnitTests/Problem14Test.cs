namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem14Test
    {
        [TestMethod]
        //Arrange
        [DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
        [DataRow(new string[] { "dog", "racecar", "car" }, "")]
        /// <param name="strs">array of strings to find longest common prefix for</param>
        /// <param name="expected">expected string of longest common prefix between all values in 'strs' array</param>
        public void TestLongestCommonPrefix(string[] strs, string expected)
        {
            //Act
            string actual = Problem14.LongestCommonPrefix(strs);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

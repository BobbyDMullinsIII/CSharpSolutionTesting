namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem6Test
    {
        [TestMethod]
        //Arrange
        [DataRow("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [DataRow("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [DataRow("A", 1, "A")]
        /// <param name="s">string to convert</param>
        /// <param name="numRows">number of rows that zigzag pattern uses</param>
        /// <param name="expected">expected string after zigzag conversion</param>
        public void TestConvert(string s, int numRows, string expected)
        {
            //Act
            string actual = Problem6.Convert(s, numRows);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

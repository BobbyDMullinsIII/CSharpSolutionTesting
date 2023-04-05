namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem9Test
    {
        [TestMethod]
        //Arrange
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(10, false)]
        /// <param name="x">input integer to check if palindrome</param>
        /// <param name="expected">expected whether 'x' is a palindrome number</param>
        public void TestIsPalindrome(int x, bool expected)
        {
            //Act
            bool actual = Problem9.IsPalindrome(x);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

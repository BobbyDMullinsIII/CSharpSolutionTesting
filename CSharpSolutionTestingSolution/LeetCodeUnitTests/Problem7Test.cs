namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem7Test
    {
        [TestMethod]
        //Arrange
        [DataRow(123, 321)]
        [DataRow(-123, -321)]
        [DataRow(120, 21)]
        /// <param name="x">integer to reverse</param>
        /// <param name="expected">expected reversed integer</param>
        public void TestReverseSimple(int x, int expected)
        {
            //Act
            int actual = Problem7.ReverseSimple(x);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        //Arrange
        [DataRow(123, 321)]
        [DataRow(-123, -321)]
        [DataRow(120, 21)]
        /// <param name="x">integer to reverse</param>
        /// <param name="expected">expected reversed integer</param>
        public void TestReverseFasterSmaller(int x, int expected)
        {
            //Act
            int actual = Problem7.ReverseFasterSmaller(x);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

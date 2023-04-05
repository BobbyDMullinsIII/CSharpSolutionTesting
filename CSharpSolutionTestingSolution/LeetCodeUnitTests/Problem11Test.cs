namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem11Test
    {
        [TestMethod]
        //Arrange
        [DataRow(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [DataRow(new int[] { 1, 1 }, 1)]
        /// <param name="height">integer array to determine what two points can hold the most water or area</param>
        /// <param name="expected">expected largest area between two indexes that can "hold the most water" (or area)</param>
        public void TestMaxAreaBruteForce(int[] height, int expected)
        {
            //Act
            int actual = Problem11.MaxAreaBruteForce(height);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        //Arrange
        [DataRow(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [DataRow(new int[] { 1, 1 }, 1)]
        /// <param name="height">integer array to determine what two points can hold the most water or area</param>
        /// <param name="expected">expected largest area between two indexes that can "hold the most water" (or area)</param>
        public void TestMaxAreaEfficient(int[] height, int expected)
        {
            //Act
            int actual = Problem11.MaxAreaEfficient(height);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem1Test
    {
        [TestMethod]
        //Arrange
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] {3, 3}, 6, new int[] { 0, 1 })]
        /// <param name="nums">input array to search</param>
        /// <param name="target">input target sum</param>
        /// <param name="expected">expected array of two integer's indices whos sum equals target</param>
        public void TestTwoSumBruteForce(int[] nums, int target, int[] expected)
        {
            //Act
            int[] actual = Problem1.TwoSumBruteForce(nums, target);

            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        //Arrange
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        /// <param name="nums">input array to search</param>
        /// <param name="target">input target sum</param>
        /// <param name="expected">expected array of two integer's indices whos sum equals target</param>
        public void TestTwoSumEfficient(int[] nums, int target, int[] expected)
        {
            //Act
            int[] actual = Problem1.TwoSumEfficient(nums, target);

            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
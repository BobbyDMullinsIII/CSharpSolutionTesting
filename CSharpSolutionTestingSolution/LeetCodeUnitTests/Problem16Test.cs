namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem16Test
    {
        [TestMethod]
        //Arrange
        [DataRow(new int[] { -1, 2, 1, -4 }, 1, 2)]
        [DataRow(new int[] { 0, 0, 0 }, 1, 0)]
        /// <param name="nums">array of ints to search for triplets that is closest to 'target'</param>
        /// <param name="target">value to calculate triplet closest to</param>
        /// <param name="expected">expected sum of the triplet that is closest to 'target' from the 'nums' array</param>
        public void TestThreeSumClosest(int[] nums, int target, int expected)
        {
            //Act
            int actual = Problem16.ThreeSumClosest(nums, target);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

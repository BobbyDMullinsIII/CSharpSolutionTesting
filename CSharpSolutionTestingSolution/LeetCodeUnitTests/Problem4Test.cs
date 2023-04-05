namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem4Test
    {
        [TestMethod]
        //Arrange
        [DataRow(new int[] { 1, 3 }, new int[] { 2 }, 2.0)]
        [DataRow(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        /// <param name="nums1">first input array</param>
        /// <param name="nums2">second input array</param>
        /// <param name="expected">expected median of the merged nums1|nums2 array</param>
        public void TestFindMedianSortedArrays(int[] nums1, int[] nums2, double expected)
        {
            //Act
            double actual = Problem4.FindMedianSortedArrays(nums1, nums2);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

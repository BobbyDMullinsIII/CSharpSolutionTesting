namespace LeetCodeUnitTests
{
    [TestClass]
    public class Problem15Test
    {
        [TestMethod]
        //Arrange
        //[DataRow(new int[] { -1, 0, 1, 2, -1, -4 }, )]
        //[DataRow(new int[] { 0, 1, 1 }, )]
        //[DataRow(new int[] { 0, 0, 0 }, )]
        /// <param name="nums">array of ints to search for triplets that equal zero</param>
        /// <param name="expected">expected IList of ILists that contain all triplet combinations from 'nums' array that equal zero</returns>
        public void TestThreeSumSlow()
        {
            //Arrange
            int[] nums1 = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] nums2 = new int[] { 0, 1, 1 };
            int[] nums3 = new int[] { 0, 0, 0 };

            List<List<int>> expected1 = new()
            {
                new List<int>() { -1, 0, 1 },
                new List<int>() { -1, -1, 2 }
            };

            List<List<int>> expected2 = new();

            List<List<int>> expected3 = new()
            {
                new List<int>() { 0, 0, 0 }
            };


            //Act
            IList<IList<int>> tempActual1 = Problem15.ThreeSumSlow(nums1);
            List<List<int>> actual1 = new();
            foreach (List<int> l in tempActual1)
            {
                actual1.Add(new List<int>() { l[0], l[1], l[2] });
            }

            IList<IList<int>> tempActual2 = Problem15.ThreeSumSlow(nums2);
            List<List<int>> actual2 = new();
            foreach (List<int> l in tempActual2)
            {
                actual2.Add(new List<int>() { l[0], l[1], l[2] });
            }

            IList<IList<int>> tempActual3 = Problem15.ThreeSumSlow(nums3);
            List<List<int>> actual3 = new();
            foreach (List<int> l in tempActual3)
            {
                actual3.Add(new List<int>() { l[0], l[1], l[2] });
            }

            //Assert
            CollectionAssert.AreEqual(actual1[0], expected1[0]);
            CollectionAssert.AreEqual(actual1[1], expected1[1]);
            CollectionAssert.AreEqual(actual2, expected2);
            CollectionAssert.AreEqual(actual3[0], expected3[0]);
        }

        [TestMethod]
        //Arrange
        //[DataRow(new int[] { -1, 0, 1, 2, -1, -4 }, )]
        //[DataRow(new int[] { 0, 1, 1 }, )]
        //[DataRow(new int[] { 0, 0, 0 }, )]
        /// <param name="nums">array of ints to search for triplets that equal zero</param>
        /// <param name="expected">expected IList of ILists that contain all triplet combinations from 'nums' array that equal zero</returns>
        public void TestThreeSumFast()
        {
            //Arrange
            int[] nums1 = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] nums2 = new int[] { 0, 1, 1 };
            int[] nums3 = new int[] { 0, 0, 0 };

            List<List<int>> expected1 = new()
            {
                new List<int>() { -1, 0, 1 },
                new List<int>() { -1, -1, 2 }
            };

            List<List<int>> expected2 = new();

            List<List<int>> expected3 = new()
            {
                new List<int>() { 0, 0, 0 }
            };


            //Act
            IList<IList<int>> tempActual1 = Problem15.ThreeSumFast(nums1);
            List<List<int>> actual1 = new();
            foreach (List<int> l in tempActual1)
            {
                actual1.Add(new List<int>() { l[0], l[1], l[2] });
            }

            IList<IList<int>> tempActual2 = Problem15.ThreeSumFast(nums2);
            List<List<int>> actual2 = new();
            foreach (List<int> l in tempActual2)
            {
                actual2.Add(new List<int>() { l[0], l[1], l[2] });
            }

            IList<IList<int>> tempActual3 = Problem15.ThreeSumFast(nums3);
            List<List<int>> actual3 = new();
            foreach (List<int> l in tempActual3)
            {
                actual3.Add(new List<int>() { l[0], l[1], l[2] });
            }

            //Assert
            CollectionAssert.AreEqual(actual1[0], expected1[0]);
            CollectionAssert.AreEqual(actual1[1], expected1[1]);
            CollectionAssert.AreEqual(actual2, expected2);
            CollectionAssert.AreEqual(actual3[0], expected3[0]);
        }
    }
}

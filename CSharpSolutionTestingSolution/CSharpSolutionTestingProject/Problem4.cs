///////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem4.cs
//  Description:        Problem4 class for testing solutions to the Median of Two Sorted Arrays problem
//  Authors:            Bobby Mullins
//  Created:            Friday, February 25, 2023 | (2023-02-25)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Median of Two Sorted Arrays problem methods
    /// </summary>
    public class Problem4
    {
        /// <summary>
        /// Solution for Median of Two Sorted Arrays problem
        /// </summary>
        /// <param name="nums1">first input array</param>
        /// <param name="nums2">second input array</param>
        /// <returns>median of the merged nums1|nums2 array</returns>
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            //Variables
            double median;
            int[] mergedArray;
            int arrayLength;
            bool oddLength = false;

            //Merge arrays, sort merged array, and store length in variable
            mergedArray = nums1.Concat(nums2).ToArray();
            Array.Sort(mergedArray);
            arrayLength = mergedArray.Length;

            //Makes oddLength variable true if array is calculated to be odd in length
            if(arrayLength % 2 != 0)
            {
                oddLength = true;
            }

            //Different calculations for odd or even length
            if (oddLength == true)
            {
                //Calculation for odd length
                median = mergedArray[(arrayLength + 1) / 2 - 1];
            }
            else
            {
                //Calculation for even length
                int tempNum = mergedArray[arrayLength / 2 - 1] + mergedArray[arrayLength / 2];
                median = tempNum / 2.0d;
            }

            //Return calculated median of merged array
            return median;

        }//end FindMedianSortedArrays()

    }//end Problem4 class
}

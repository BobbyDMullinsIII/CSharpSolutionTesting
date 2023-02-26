///////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          MedianTwoSortedArraysStatic.cs
//  Description:        MedianTwoSortedArraysStatic class for testing solutions to the Median of Two Sorted Arrays problem
//  Authors:            Bobby Mullins
//  Created:            Friday, February 25, 2023 | (2023-02-10)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutionTestingProject
{
    /// <summary>
    ///  Class for Median of Two Sorted Arrays problem methods
    /// </summary>
    internal class MedianTwoSortedArraysStatic
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

            //Merge arrays and sort merged array
            mergedArray = nums1.Concat(nums2).ToArray();
            Array.Sort(mergedArray);



            return median;

        }//end FindMedianSortedArrays()

    }//end MedianTwoSortedArraysStatic
}

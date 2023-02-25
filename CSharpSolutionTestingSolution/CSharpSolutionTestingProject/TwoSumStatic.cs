///////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   CSharpSolutionTestingProjectSolution/CSharpSolutionTestingProject
//  File Name:          TwoSumStatic.cs
//  Description:        TwoSumStatic class for testing solutions to the TwoSum problem
//  Authors:            Bobby Mullins
//  Created:            Friday, February 10, 2023 | (2023-02-10)
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
    ///  Class for testing static methods and functions
    /// </summary>
    internal class TwoSumStatic
    {
        /// <summary>
        /// Brute force solution for TwoSum problem
        /// </summary>
        /// <param name="nums">input array to search</param>
        /// <param name="target">input target sum</param>
        /// <returns>array of indices within nums array containing integer sum equal to target</returns>
        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            int i, j; //loop variables

            for (i = 0; i < nums.Length; i++)
            {
                for (j = 0; j < nums.Length; j++)
                {
                    if (i != j) //do not compare if same index
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }

            return new int[] { 0, 0 };
        }//end TwoSumBruteForce()

        /// <summary>
        /// More efficient solution for TwoSum problem (might not be the best)
        /// </summary>
        /// <param name="nums">input array to search</param>
        /// <param name="target">input target sum</param>
        /// <returns>array of indices within nums array containing integer sum equal to target</returns>
        public static int[] TwoSumEfficient(int[] nums, int target)
        {


            return new int[] { 0, 0 };
        }//end TwoSumEfficient()

    }//end StaticTesting
}

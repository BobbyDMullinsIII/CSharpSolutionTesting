﻿/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem1.cs
//  Description:        Problem1 class for testing solutions to the TwoSum problem
//  Authors:            Bobby Mullins
//  Created:            Friday, February 10, 2023 | (2023-02-10)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace CSharpSolutionTestingProject
{
    /// <summary>
    ///  Class for Two Sum problem methods
    /// </summary>
    internal class Problem1
    {
        /// <summary>
        /// Brute force solution for TwoSum problem
        /// </summary>
        /// <param name="nums">input array to search</param>
        /// <param name="target">input target sum</param>
        /// <returns>array of indices within 'nums' array containing integer sum equal to target</returns>
        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            //Double for loop to iterate through each value and compare to every other value
            //(will result in comparisons with the same indices duplicating a few times)
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j) //do not compare if same index
                    {
                        //Check if equal to target
                        if (nums[i] + nums[j] == target)
                        {
                            //Returns indices if two separate indices to equal target are found
                            return new int[] { i, j };
                        }
                    }
                }
            }

            //Will only return this if two separate indices equaling target are not found
            return new int[] { 0, 0 };

        }//end TwoSumBruteForce()

        /// <summary>
        /// More efficient solution for TwoSum problem (might not be the best)
        /// </summary>
        /// <param name="nums">input array to search</param>
        /// <param name="target">input target sum</param>
        /// <returns>array of indices within 'nums' array containing integer sum equal to target</returns>
        public static int[] TwoSumEfficient(int[] nums, int target)
        {
            //Variables
            int i; //loop variable
            Dictionary<int, int> dict = new(); //dictionary (hashmap equivalent)

            //loop through array only one time using dictionary
            for (i = 0; i < nums.Length; i++)
            {
                int indiceOneVal = nums[i];
                int indiceTwoVal = target - indiceOneVal;

                //Check if equal to target
                if (dict.TryGetValue(indiceTwoVal, out int index))
                {
                    //returns indices if two separate indices to equal target are found
                    return new[] { index, i };
                }

                dict[indiceOneVal] = i;
            }

            //Will only return this if two separate indices equaling target are not found
            return new int[] { 0, 0 };

        }//end TwoSumEfficient()

    }//end Problem1 class
}

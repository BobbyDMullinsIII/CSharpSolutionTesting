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

            //double for loop to iterate through each value and compare to every other value
            //(will result in comparisons with the same indices duclicating a few times)
            for (i = 0; i < nums.Length; i++)
            {
                for (j = 0; j < nums.Length; j++)
                {
                    if (i != j) //do not compare if same index
                    {
                        //Check if equal to target
                        if (nums[i] + nums[j] == target)
                        {
                            //returns indices if two separate indices to equal target are found
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
        /// <returns>array of indices within nums array containing integer sum equal to target</returns>
        public static int[] TwoSumEfficient(int[] nums, int target)
        {
            int i; //loop variable
            Dictionary<int, int> dict = new Dictionary<int, int>(); //dictionary (hashmap equivalent)

            //loop through array only one time using dictionary
            for (i = 0; i < nums.Length; i++)
            {
                int indiceOne = nums[i];
                int indiceTwo = target - indiceOne;

                //Check if equal to target
                if (dict.TryGetValue(indiceTwo, out int index))
                {
                    //returns indices if two separate indices to equal target are found
                    return new[] { index, i };
                }

                dict[indiceOne] = i;
            }

            //Will only return this if two separate indices equaling target are not found
            return new int[] { 0, 0 };

        }//end TwoSumEfficient()

    }//end StaticTesting
}

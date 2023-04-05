/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem16.cs
//  Description:        Problem16 class for testing solutions to the Three Sum Closest problem
//  Authors:            Bobby Mullins
//  Created:            Wednesday, March 29, 2023 | (2023-03-29)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Three Sum Closest problem methods
    /// </summary>
    public class Problem16
    {
        //Problem 16
        //Method for running ThreeSumClosest solution
        public static void RunProblem16()
        {
            //Main variables
            int[] nums = new int[] { -1, 2, 1, -4 };
            int target = 2;
            int closeSum;

            //Execute Solution
            closeSum = Problem16.ThreeSumClosest(nums, target);

            //Solution printed out to console
            Console.WriteLine(closeSum);

        }//end RunProblem16()

        /// <summary>
        /// Solution for Three Sum problem
        /// </summary>
        /// <param name="nums">array of ints to search for triplets that is closest to 'target'</param>
        /// <param name="target">value to calculate triplet closest to</param>
        /// <returns>sum of the triplet that is closest to 'target' from the 'nums' array</returns>
        public static int ThreeSumClosest(int[] nums, int target)
        {
            int closestInt = int.MaxValue; //Value from a triplet within 'nums' that is closest to 'target'
            int pointer1;                  //First pointer for the closest triplet
            int pointer2;                  //Second pointer for the closest triplet
            int tempSum;                   //Temporary calculated sum for current while loop iteration triplet

            //Sort and go through entire array (length minus two due to triplet calculation)
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //Pointers given values for iteration
                //(Will close as while loop goes on)
                pointer1 = i + 1;
                pointer2 = nums.Length - 1;

                //Calculates closest sum for each while loop iteration and saves it if it is closer than current closestSum value
                while (pointer1 < pointer2)
                {
                    //Calculates triplet sum and compares it to the target sum
                    tempSum = nums[i] + nums[pointer1] + nums[pointer2];
                    if (Math.Abs(target - tempSum) < Math.Abs(target - closestInt))
                    {
                        closestInt = tempSum;
                    }

                    //Determines whether to move first or second pointer
                    //(Will bring pointers closer together either way)
                    if (tempSum <= target)
                    {
                        pointer1++;
                    }
                    else
                    {
                        pointer2--;
                    }
                }
            }
            
            //Returns value of triplet that had closest sum to the 'target' value
            return closestInt;

        }//end ThreeSumClosest()

    }//end Problem16 class
}

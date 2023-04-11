/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem18.cs
//  Description:        Problem18 class for testing solutions to the Four Sum problem
//  Authors:            Bobby Mullins
//  Created:            Saturday, April 1, 2023 | (2023-04-01)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Four Sum problem methods
    /// </summary>
    public class Problem18
    {
        //Problem 18
        //Method for running ThreeSum solution
        public static void RunProblem18()
        {
            //Main variables
            int[] nums = new int[] { 1, 4, 45, 6, 10, 12 };
            int target = 8;
            IList<IList<int>> quadruplets;

            //Execute Solution
            //quadruplets = Problem18.FourSumSlow(nums, target);
            quadruplets = Problem18.FourSumFast(nums, target);

            //Solution printed out to console
            foreach (var sublist in quadruplets)
            {
                foreach (var obj in sublist)
                {
                    Console.Write(obj + ",");
                }
                Console.WriteLine();
            }

        }//end RunProblem18()

        /// <summary>
        /// Slow Solution for Four Sum problem
        /// </summary>
        /// <param name="nums">array of ints to search for quadruplets that is closest to 'target'</param>
        /// <param name="target">value to calculate quadruplets closest to</param>
        /// <returns>sum of the quadruplets that is closest to 'target' from the 'nums' array</returns>
        public static IList<IList<int>> FourSumSlow(int[] nums, int target)
        {
            List<List<int>> workList = new();   //Working list of quadruplet lists
            int length = nums.Length;           //Store length in single variable to prevent multiple length lookups

            //Quadruple nested for loop for searching 'nums' array for quadruplets that equal 'target'
            for (int i = 0; i < length - 3; i++)
            {
                for (int j = i + 1; j < length - 2; j++)
                {
                    for (int k = j + 1; k < length - 1; k++)
                    {
                        for (int l = k + 1; l < length; l++)
                        {
                            //If the quadruplet equals 'target', sort it, and add it to the final 'returnList'
                            if (nums[i] + nums[j] + nums[k] + nums[l] == target)
                            {
                                List<int> tempList = new() { nums[i], nums[j], nums[k], nums[l] };
                                tempList.Sort();
                                workList.Add(tempList);
                            }
                        }
                    }
                }
            }

            //Makes all arrays within 'workList' distinct
            workList = workList.GroupBy(x => string.Join(",", x)).Select(x => x.First().ToList()).ToList();

            List<IList<int>> returnList = new(); //List of lists to return
            foreach (List<int> list in workList)
            {
                returnList.Add(new List<int>() { list[0], list[1], list[2], list[3] });
            }

            //Return list of quadruplets from 'nums' that equal 'target'
            return returnList;

        }//end FourSumSlow()

        /// <summary>
        /// Fast Solution for Four Sum problem (DOES NOT WORK CURRENTLY FOR SOME REASON!!!)
        /// </summary>
        /// <param name="nums">array of ints to search for quadruplets that is closest to 'target'</param>
        /// <param name="target">value to calculate quadruplets closest to</param>
        /// <returns>sum of the quadruplets that is closest to 'target' from the 'nums' array</returns>
        public static IList<IList<int>> FourSumFast(int[] nums, int target)
        {
            List<List<int>> workList = new();   //Working list of quadruplet lists
            int length = nums.Length;           //Store length in single variable to prevent multiple length lookups

            int k, l;

            Array.Sort(nums);   //Sort array to allow for 'k' and 'l' pointers to function

            //Double for loop to act as basis for quadruplets calculation
            for (int i = 0; i < length - 3; i++)
            {
                for (int j = i + 1; j < length - 2; j++)
                {
                    //Start pointers indexes away from the absolute end indexes of the array
                    k = j + 1;
                    l = length - 1;

                    //Will continue until 'k' and 'l' pointers meet somehwere in the middle of 'nums' array
                    while (k < l)
                    {
                        //Adds quadruplet to list if it equals target
                        if (nums[i] + nums[j] + nums[k] + nums[l] == target)
                        {
                            List<int> tempList = new() { nums[i], nums[j], nums[k], nums[l] };
                            tempList.Sort();
                            workList.Add(tempList);

                            //Brings both pointers closer to each other
                            k++;
                            l--;
                        }
                        else
                        {
                            //Brings 'k' pointer closer to the right if quadruplet is less than target
                            if (nums[i] + nums[j] + nums[k] + nums[l] < target)
                            {
                                k++;
                            }
                            //Brings 'l' pointer closer to the left if quadruplet is more than target
                            else
                            {
                                l--;
                            }
                        }
                    }
                }
            }

            //Makes all arrays within 'workList' distinct
            workList = workList.GroupBy(x => string.Join(",", x)).Select(x => x.First().ToList()).ToList();

            List<IList<int>> returnList = new(); //List of lists to return
            foreach (List<int> list in workList)
            {
                returnList.Add(new List<int>() { list[0], list[1], list[2], list[3] });
            }

            //Return list of quadruplets from 'nums' that equal 'target'
            return returnList;

        }//end FourSumFast()

    }//end Problem18 class
}

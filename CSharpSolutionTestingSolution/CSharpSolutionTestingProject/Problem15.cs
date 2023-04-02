/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem15.cs
//  Description:        Problem15 class for testing solutions to the Three Sum problem
//  Authors:            Bobby Mullins
//  Created:            Wednesday, March 29, 2023 | (2023-03-29)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Three Sum problem methods
    /// </summary>
    internal class Problem15
    {
        /// <summary>
        /// Solution for Three Sum problem
        /// </summary>
        /// <param name="nums">array of ints to search for triplets that equal zero</param>
        /// <returns>IList of ILists that contain all triplet combinations from 'nums' array that equal zero</returns>
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            int x;                               //Third value in a triplet to check
            HashSet<int> tempSet;                //Temporary HashSet for triplet comparison
            List<IList<int>> returnList = new(); //List of lists to return

            //Go through entire array (length minus two due to triplet calculation)
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //Create new HashSet for this iteration
                tempSet = new HashSet<int>();

                //Iterate one ahead of i in current for loop iteration
                for (int j = i + 1; j < nums.Length; j++)
                {
                    //Calculate triplet
                    x = 0 - (nums[i] + nums[j]);

                    //If the HashSet contains the 'x' value equivalent, add to the triplet return list
                    if (tempSet.Contains(x))
                    {
                        List<int> tempList = new() { x, nums[i], nums[j] };
                        tempList.Sort();

                        //Statements for checking if triplet is duplicate of already existing triplet within returnList
                        if (returnList.Count == 0)
                        {
                            returnList.Add(tempList);
                        }
                        else
                        {
                            bool duplicate = false;
                            foreach (List<int> l in returnList.Cast<List<int>>())
                            {
                                if (tempList.SequenceEqual(l))
                                {
                                    duplicate = true;
                                }
                            }

                            if(duplicate == false)
                            {
                                returnList.Add(tempList);
                            }
                        }
                    }
                    //Else, add it to the HashSet for this run
                    else
                    {
                        tempSet.Add(nums[j]);
                    }
                }
            }

            //Returns list of lists of triplets that equal '0'
            return returnList;

        }//end ThreeSum()

    }//end Problem15 class
}

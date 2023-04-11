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

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Three Sum problem methods
    /// </summary>
    public class Problem15
    {
        //Problem 15
        //Method for running ThreeSum solution
        public static void RunProblem15()
        {
            //Main variables
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets;

            //Execute Solution
            //triplets = Problem15.ThreeSumSlow(nums);
            triplets = Problem15.ThreeSumFast(nums);

            //Solution printed out to console
            foreach (var sublist in triplets)
            {
                foreach (var obj in sublist)
                {
                    Console.Write(obj + ",");
                }
                Console.WriteLine();
            }

        }//end RunProblem15()

        /// <summary>
        /// Slow Solution for Three Sum problem
        /// </summary>
        /// <param name="nums">array of ints to search for triplets that equal zero</param>
        /// <returns>IList of ILists that contain all triplet combinations from 'nums' array that equal zero</returns>
        public static IList<IList<int>> ThreeSumSlow(int[] nums)
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
                            //Checks if current triplet is a duplicate of one already within 'returnList'
                            bool duplicate = false;
                            foreach (List<int> l in returnList.Cast<List<int>>())
                            {
                                if (tempList.SequenceEqual(l))
                                {
                                    duplicate = true;
                                }
                            }

                            //Adds current triplet if it is not a duplicate 
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

        }//end ThreeSumSlow()

        /// <summary>
        /// Fast(er) Solution for Three Sum problem
        /// </summary>
        /// <param name="nums">array of ints to search for triplets that equal zero</param>
        /// <returns>IList of ILists that contain all triplet combinations from 'nums' array that equal zero</returns>
        public static IList<IList<int>> ThreeSumFast(int[] nums)
        {
            List<List<int>> workList = new();   //Working list of triplet lists

            //Go through entire array (length minus two due to triplet calculation)
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //Create new HashSet for this iteration
                HashSet<int> tempSet = new(); //Temporary HashSet for triplet comparison

                //Iterate one ahead of i in current for loop iteration
                for (int j = i + 1; j < nums.Length; j++)
                {
                    //Calculate triplet
                    int x = 0 - (nums[i] + nums[j]); //Third value in a triplet to check

                    //If the HashSet contains the 'x' value equivalent, add to the triplet return list
                    if (tempSet.Contains(x))
                    {
                        List<int> tempList = new() { x, nums[i], nums[j] };
                        tempList.Sort();
                        workList.Add(tempList);
                    }
                    //Else, add it to the HashSet for this run
                    else
                    {
                        tempSet.Add(nums[j]);
                    }
                }
            }

            //Makes all arrays within 'workList' distinct
            workList = workList.GroupBy(x => string.Join(",", x)).Select(x => x.First().ToList()).ToList();

            List<IList<int>> returnList = new(); //List of lists to return
            foreach (List<int> list in workList)
            {
                returnList.Add(new List<int>() { list[0], list[1], list[2] });
            }

            //Returns list of lists of triplets that equal '0'
            return returnList;

        }//end ThreeSumFast()

    }//end Problem15 class
}

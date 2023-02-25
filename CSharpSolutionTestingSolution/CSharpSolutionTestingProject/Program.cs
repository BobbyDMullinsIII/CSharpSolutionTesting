/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   CSharpSolutionTestingProjectSolution/CSharpSolutionTestingProject
//  File Name:          Driver.cs
//  Description:        Main driver for program
//  Authors:            Bobby Mullins
//  Created:            Friday, February 10, 2023 | (2023-02-10)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace CSharpSolutionTestingProject
{
    /// <summary>
    ///  Driver class for starting program
    /// </summary>
    internal static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestTwoSum();
        }

        //Method for testing TwoSum solution
        public static void TestTwoSum()
        {
            //Main variables
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] returnArray = TwoSumStatic.TwoSumBruteForce(nums, target); //Brute force method
            //More efficient method


            //Solution printed out to console
            returnArray.ToList().ForEach(i => Console.WriteLine(i.ToString()));
        }

    }//end Driver class

}//end CSharpSolutionTestingProject namespace
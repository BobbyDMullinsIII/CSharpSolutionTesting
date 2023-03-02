﻿/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Driver.cs
//  Description:        Main driver for program
//  Authors:            Bobby Mullins
//  Created:            Friday, February 10, 2023 | (2023-02-10)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using LeetCodeProject;
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
            //RunTwoSum();
            //RunMedianTwoSortedArrays();
            RunReverseInteger();
        }

        //Method for running TwoSum solution
        public static void RunTwoSum()
        {
            //Main variables
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] returnArray;

            //Execute solution
            //returnArray = TwoSumStatic.TwoSumBruteForce(nums, target); //Brute force method
            returnArray = TwoSumStatic.TwoSumEfficient(nums, target); //More efficient method

            //Solution printed out to console
            returnArray.ToList().ForEach(i => Console.WriteLine(i.ToString()));

        }//end RunTwoSum()

        //Method for running MedianTwoSortedArrays solution
        public static void RunMedianTwoSortedArrays()
        {
            //Main variables
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };
            double median;

            //Execute solution
            median = MedianTwoSortedArraysStatic.FindMedianSortedArrays(nums1, nums2);

            //Solution printed out to console
            Console.WriteLine(median);

        }//end RunMedianTwoSortedArrays()

        //Method for running MedianTwoSortedArrays solution
        public static void RunReverseInteger()
        {
            //Main variables
            int x = 123;
            int reversedNumber;

            //Execute Solution
            reversedNumber = Reverse32BitIntegerStatic.Reverse(x);

            //Solution printed out to console
            Console.WriteLine(reversedNumber);

        }//end RunReverseInteger()

    }//end Driver class

}//end CSharpSolutionTestingProject namespace
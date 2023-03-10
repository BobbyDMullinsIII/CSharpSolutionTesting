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
            RunZigzagConversion();
        }

        //Problem 1
        //Method for running TwoSum solution
        public static void RunTwoSum()
        {
            //Main variables
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            //Execute solution
            //int[] returnArray = TwoSumStatic.TwoSumBruteForce(nums, target); //Brute force method
            int[] returnArray = TwoSumStatic.TwoSumEfficient(nums, target); //More efficient method

            //Solution printed out to console
            returnArray.ToList().ForEach(i => Console.WriteLine(i.ToString()));

        }//end RunTwoSum()

        //Problem 3
        //Method for running LongestSubstringWithoutRepeat solution
        public static void RunLengthOfLongestSubstring()
        {
            //Main variables
            string s = "abcabcbb";

            //Execute solution
            int substrLength = LongestSubstringWithoutRepeatStatic.LengthOfLongestSubstring(s);

            //Solution printed out to console
            Console.WriteLine(substrLength);

        }//end RunLengthOfLongestSubstring()

        //Problem 4
        //Method for running MedianTwoSortedArrays solution
        public static void RunMedianTwoSortedArrays()
        {
            //Main variables
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };

            //Execute solution
            double median = MedianTwoSortedArraysStatic.FindMedianSortedArrays(nums1, nums2);

            //Solution printed out to console
            Console.WriteLine(median);

        }//end RunMedianTwoSortedArrays()

        //Problem 6
        //Method for running ZigzagConversion solution

        public static void RunZigzagConversion()
        {
            //Main variables
            string s = "PAYPALISHIRING";
            int numRows = 3;

            //Execute solution
            string converted = ZigzagConversionStatic.Convert(s, numRows);

            //Solution printed out to console
            Console.WriteLine(converted);

        }//end RunZigzagConversion

        //Problem 7
        //Method for running MedianTwoSortedArrays solution
        public static void RunReverseInteger()
        {
            //Main variables
            int x = 123;

            //Execute Solution
            //reversedNumber = Reverse32BitIntegerStatic.ReverseSimple(x); //Simpler solutioin
            int reversedNumber = Reverse32BitIntegerStatic.ReverseFasterSmaller(x);//Slightly faster and more space efficient solution

            //Solution printed out to console
            Console.WriteLine(reversedNumber);

        }//end RunReverseInteger()

        //Problem 8
        //Method for running my atoi
        public static void RunMyAtoi()
        {
            //Main variables
            string s = "4193 with words";

            //Execute Solution
            int newInt = StringToIntegerAtoiStatic.MyAtoi(s);

            //Solution printed out to console
            Console.WriteLine(newInt);

        }//end RunMyAtoi()

        //Problem 9
        //Method for running my atoi
        public static void RunPalindrome()
        {
            //Main variables
            int x = 121;

            //Execute Solution
            bool isPalindrome = PalindromeNumber.IsPalindrome(x);

            //Solution printed out to console
            Console.WriteLine(isPalindrome);

        }//end RunPalindrome()

    }//end Driver class

}//end CSharpSolutionTestingProject namespace
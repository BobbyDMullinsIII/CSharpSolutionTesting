/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
            RunProblem11();
        }

        //Problem 1
        //Method for running TwoSum solution
        public static void RunProblem1()
        {
            //Main variables
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] returnArray;

            //Execute solution
            //returnArray = Problem1.TwoSumBruteForce(nums, target); //Brute force method
            returnArray = Problem1.TwoSumEfficient(nums, target); //More efficient method

            //Solution printed out to console
            returnArray.ToList().ForEach(i => Console.WriteLine(i.ToString()));

        }//end RunProblem1()

        //Problem 2
        //Method for running AddTwoNumbers solution
        public static void RunProblem2()
        {
            //Main variables
            ListNode l1 = new();
            ListNode l2 = new();
            ListNode lSum;

            //Execute solution
            lSum = Problem2.AddTwoNumbers(l1, l2);

            //Solution printed out to console
            //lSum.ToList().ForEach(i => Console.WriteLine(i.ToString()));

        }//end RunProblem2()

        //Problem 3
        //Method for running LongestSubstringWithoutRepeat solution
        public static void RunProblem3()
        {
            //Main variables
            string s = "abcabcbb";
            int substringLength;

            //Execute solution
            substringLength = Problem3.LengthOfLongestSubstring(s);

            //Solution printed out to console
            Console.WriteLine(substringLength);

        }//end RunProblem3()

        //Problem 4
        //Method for running MedianTwoSortedArrays solution
        public static void RunProblem4()
        {
            //Main variables
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };
            double median;

            //Execute solution
            median = Problem4.FindMedianSortedArrays(nums1, nums2);

            //Solution printed out to console
            Console.WriteLine(median);

        }//end RunProblem4()

        //Problem 5
        //Method for running LongestPalindromicSubstring solution
        public static void RunProblem5()
        {
            //Main variables
            string s = "babad";
            string LPS;

            //Execute solution
            LPS = Problem5.LongestPalindrome(s);

            //Solution printed out to console
            Console.WriteLine(LPS);

        }//end RunProblem5()

        //Problem 6
        //Method for running ZigzagConversion solution
        public static void RunProblem6()
        {
            //Main variables
            string s = "PAYPALISHIRING";
            int numRows = 3;
            string converted;

            //Execute solution
            converted = Problem6.Convert(s, numRows);

            //Solution printed out to console
            Console.WriteLine(converted);

        }//end RunProblem6

        //Problem 7
        //Method for running MedianTwoSortedArrays solution
        public static void RunProblem7()
        {
            //Main variables
            int x = 123;
            int reversedNumber;

            //Execute solution
            //reversedNumber = Problem7.ReverseSimple(x); //Simpler solution
            reversedNumber = Problem7.ReverseFasterSmaller(x);//Slightly faster and more space efficient solution

            //Solution printed out to console
            Console.WriteLine(reversedNumber);

        }//end RunProblem7()

        //Problem 8
        //Method for running my atoi solution
        public static void RunProblem8()
        {
            //Main variables
            string s = "42";
            int newInt;

            //Execute solution
            newInt = Problem8.MyAtoi(s);

            //Solution printed out to console
            Console.WriteLine(newInt);

        }//end RunProblem8()

        //Problem 9
        //Method for running PalindromeNumber solution
        public static void RunProblem9()
        {
            //Main variables
            int x = 121;
            bool isPalindrome;

            //Execute solution
            isPalindrome = Problem9.IsPalindrome(x);

            //Solution printed out to console
            Console.WriteLine(isPalindrome);

        }//end RunProblem9()


        //Problem 10
        //Method for running RegularExpressionMatching solution
        public static void RunProblem10()
        {
            //Main variables
            string s = "aa";
            string p = "a";
            bool matches;

            //Execute solution
            matches = Problem10.IsMatch(s, p);

            //Solution printed out to console
            Console.WriteLine(matches);

        }//end RunProblem10()

        //Problem 11
        //Method for running ContainerWithMostWater solution
        public static void RunProblem11()
        {
            //Main variables
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int maxArea;

            //Execute Solution
            //maxArea = Problem11.MaxAreaBruteForce(height); //Brute force method
            maxArea = Problem11.MaxAreaEfficient(height); //More efficient method

            //Solution printed out to console
            Console.WriteLine(maxArea);

        }//end RunProblem11()

    }//end Driver class

}//end CSharpSolutionTestingProject namespace
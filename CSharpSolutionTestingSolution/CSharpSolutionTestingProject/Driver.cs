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
            RunMaxAreaWater();
        }

        //Problem 1
        //Method for running TwoSum solution
        public static void RunTwoSum()
        {
            //Main variables
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] returnArray;

            //Execute solution
            //returnArray = TwoSumStatic.TwoSumBruteForce(nums, target); //Brute force method
            returnArray = Problem1.TwoSumEfficient(nums, target); //More efficient method

            //Solution printed out to console
            returnArray.ToList().ForEach(i => Console.WriteLine(i.ToString()));

        }//end RunTwoSum()

        //Problem 3
        //Method for running LongestSubstringWithoutRepeat solution
        public static void RunLengthOfLongestSubstring()
        {
            //Main variables
            string s = "abcabcbb";
            int substrLength;

            //Execute solution
            substrLength = Problem3.LengthOfLongestSubstring(s);

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
            double median;

            //Execute solution
            median = Problem4.FindMedianSortedArrays(nums1, nums2);

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
            string converted;

            //Execute solution
            converted = Problem6.Convert(s, numRows);

            //Solution printed out to console
            Console.WriteLine(converted);

        }//end RunZigzagConversion

        //Problem 7
        //Method for running MedianTwoSortedArrays solution
        public static void RunReverseInteger()
        {
            //Main variables
            int x = 123;
            int reversedNumber;

            //Execute Solution
            //reversedNumber = Reverse32BitIntegerStatic.ReverseSimple(x); //Simpler solutioin
            reversedNumber = Problem7.ReverseFasterSmaller(x);//Slightly faster and more space efficient solution

            //Solution printed out to console
            Console.WriteLine(reversedNumber);

        }//end RunReverseInteger()

        //Problem 8
        //Method for running my atoi
        public static void RunMyAtoi()
        {
            //Main variables
            string s = "4193 with words";
            int newInt;

            //Execute Solution
            newInt = Problem8.MyAtoi(s);

            //Solution printed out to console
            Console.WriteLine(newInt);

        }//end RunMyAtoi()

        //Problem 9
        //Method for running my atoi
        public static void RunPalindrome()
        {
            //Main variables
            int x = 121;
            bool isPalindrome;

            //Execute Solution
            isPalindrome = Problem9.IsPalindrome(x);

            //Solution printed out to console
            Console.WriteLine(isPalindrome);

        }//end RunPalindrome()

        //Problem 11
        //Method for running my atoi
        public static void RunMaxAreaWater()
        {
            //Main variables
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int maxArea;

            //Execute Solution
            //maxArea = ContainerWithMostWaterStatic.MaxAreaBruteForce(height); //Brute force method
            maxArea = Problem11.MaxAreaEfficient(height); //More efficient method

            //Solution printed out to console
            Console.WriteLine(maxArea);

        }//end RunMaxAreaWater()

    }//end Driver class

}//end CSharpSolutionTestingProject namespace
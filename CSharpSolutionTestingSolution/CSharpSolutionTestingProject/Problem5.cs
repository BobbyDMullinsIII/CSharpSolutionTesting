/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem5.cs
//  Description:        Problem5 class for testing solutions to the Longest Palindromic Substring problem
//  Authors:            Bobby Mullins
//  Created:            Sunday, March 5 2023 | (2023-03-05)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Longest Palindromic Substring problem methods
    /// </summary>
    public class Problem5
    {
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

        /// <summary>
        /// Solution for Longest Palindromic Substring problem
        /// </summary>
        /// <param name="s">string to check for palindomic substring</param>
        /// <returns>longest palindromic substring within 's' string</returns>
        public static string LongestPalindrome(string s)
        {
            //If string is null or empty or only has one character, return itself
            if (string.IsNullOrEmpty(s) == true || s.Length == 1)
            { return s; }

            

            return "";

        }//end LongestPalindrome()

    }//end Problem5 class
}

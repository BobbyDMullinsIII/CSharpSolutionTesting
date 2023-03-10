/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          LongestPalindromicSubstringStatic.cs
//  Description:        LongestPalindromicSubstringStatic class for testing solutions to the Longest Palindromic Substring problem
//  Authors:            Bobby Mullins
//  Created:            Sunday, March 5 2023 | (2023-03-05)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Longest Palindromic Substring problem methods
    /// </summary>
    internal static class LongestPalindromicSubstringStatic
    {
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

    }//end LongestPalindromicSubstringStatic class
}

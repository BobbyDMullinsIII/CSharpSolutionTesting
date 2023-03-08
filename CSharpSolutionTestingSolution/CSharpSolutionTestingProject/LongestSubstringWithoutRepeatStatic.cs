﻿/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          LongestSubstringWithoutRepeatStatic.cs
//  Description:        LongestSubstringWithoutRepeatStatic class for testing solutions to the Longest Substring Without Repeating Characters problem
//  Authors:            Bobby Mullins
//  Created:            Sunday, March 5, 2023 | (2023-03-05)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Longest Substring Without Repeating Characters problem methods
    /// </summary>
    internal static class LongestSubstringWithoutRepeatStatic
    {
        /// <summary>
        /// Solution for Longest Substring Without Repeating Characters problem
        /// </summary>
        /// <param name="s">input string to find subtring</param>
        /// <returns>length of the longest substring without repeating characters in 's' string</returns>
        public static int LengthOfLongestSubstring(string s)
        {
            string checkStr = "";  //String to check against for duplicate characters
            int substrLength = -1; //Length of largest substring without repeating characters

            //Invalid Input Checks
            //If string 's' is null or empty or has a length of 0, return 0
            if (string.IsNullOrEmpty(s) == true || s.Length == 0)
            { return 0; }

            //If string 's' has a length of 1, return 1
            if(s.Length == 1)
            { return 1; }

            //Go through each character in string 's'
            for (int i = 0; i < s.Length ; i++)
            {
                //If a repeating character is found, reset checkStr
                if (checkStr.Contains(s[i]) == true)
                {
                    checkStr = checkStr[(checkStr.IndexOf(s[i]) + 1)..];
                }

                //Add currently checked character in string to the checkStr
                checkStr += s[i];

                //If the current checkStr is larger than the stored substrLength, set substrLength to checkStr length
                if (checkStr.Length > substrLength)
                {
                    substrLength = checkStr.Length;
                }
            }

            //Return final max substring without repeating characters length
            return substrLength;

        }//end LengthOfLongestSubstring()

    }//end LongestSubstringWithoutRepeatStatic class
}

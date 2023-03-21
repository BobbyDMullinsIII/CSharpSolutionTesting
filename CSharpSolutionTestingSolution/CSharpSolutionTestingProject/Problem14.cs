﻿/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem14.cs
//  Description:        Problem14 class for testing solutions to the Longest Common Prefix problem
//  Authors:            Bobby Mullins
//  Created:            Sunday, March 19, 2023 | (2023-03-19)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Drawing;

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Longest Common Prefix problem methods
    /// </summary>
    internal class Problem14
    {
        /// <summary>
        /// Solution for Longest Common Prefix problem
        /// </summary>
        /// <param name="strs">array of strings to find longest common prefix for</param>
        /// <returns>string of longest common prefix between all values in 'strs' array</returns>
        public static string LongestCommonPrefix(string[] strs)
        {
            int i = 0; //Counting variable for while loop

            //Sort array and find smallest length from beginning and end strings
            Array.Sort(strs);
            int end = Math.Min(strs[0].Length, strs[^1].Length);

            //Count until 'i' is at location of end of common prefix between all strings
            while (i < end && strs[0][i] == strs[^1][i])
            { i++; }

            //Return calculated common prefix
            return strs[0][..i];

        }//end LongestCommonPrefix()

    }//end Problem14 class
}

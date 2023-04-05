///////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem12.cs
//  Description:        Problem12 class for testing solutions to the Regular Expression Matching problem
//  Authors:            Bobby Mullins
//  Created:            Sunday, March 12 2023 | (2023-03-12)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Regular Expression Matching problem methods
    /// </summary>
    public class Problem10
    {
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

        /// <summary>
        /// Solution for Regular Expression Matching problem
        /// </summary>
        /// <param name="s">input string to use regular expression on</param>
        /// <param name="p">regular expression (regex) patten to use on string</param>
        /// <returns>whether or not the string 's' matches the regular expression pattern 'p'</returns>
        public static bool IsMatch(string s, string p)
        {
            return true;

        }//end IsMatch()

    }//end Problem10 class
}

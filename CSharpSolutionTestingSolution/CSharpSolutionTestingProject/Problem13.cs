/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem13.cs
//  Description:        Problem13 class for testing solutions to the Roman to Integer problem
//  Authors:            Bobby Mullins
//  Created:            Sunday, March 19, 2023 | (2023-03-19)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Roman to Integer problem methods
    /// </summary>
    public class Problem13
    {
        //Problem 13
        //Method for running RomantoInteger solution
        public static void RunProblem13()
        {
            //Main variables
            string s = "MCMXCIV";
            int convertInt;

            //Execute Solution
            convertInt = Problem13.RomanToInt(s);

            //Solution printed out to console
            Console.WriteLine(convertInt);

        }//end RunProblem13()

        /// <summary>
        /// Solution for Roman to Integer problem
        /// </summary>
        /// <param name="s">string of roman numbers to convert to integer</param>
        /// <returns>'s' roman numerals converted to an integer</returns>
        public static int RomanToInt(string s)
        {
            int finalInt = 0; //Final converted integer to return

            //Dictionary of symbols and values for roman numeral to integer conversion
            Dictionary<string, int> symVals = new()
            {
                ["I"]  = 1,
                ["IV"] = 4,
                ["V"]  = 5,
                ["IX"] = 9,
                ["X"]  = 10,
                ["XL"] = 40,
                ["L"]  = 50,
                ["XC"] = 90,
                ["C"]  = 100,
                ["CD"] = 400,
                ["D"]  = 500,
                ["CM"] = 900,
                ["M"]  = 1000
            };

            //Have to replace these because "edge" cases will not convert correctly without a lot of calculation
            //This makes it simpler
            s = s.Replace("IV", "IIII");
            s = s.Replace("IX", "VIIII");
            s = s.Replace("XL", "XXXX");
            s = s.Replace("XC", "LXXXX");
            s = s.Replace("CD", "CCCC");
            s = s.Replace("CM", "DCCCC");

            //Go through each value within the string and convert into integer representation
            for (int i = 0; i < s.Length; i++)
            {
                //Add each converted integer to final total number
                finalInt += symVals[char.ToString(s[i])];
            }

            //Return final converted number
            return finalInt;
            
        }//end RomanToInt()

    }//end Problem13 class
}

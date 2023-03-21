/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem12.cs
//  Description:        Problem12 class for testing solutions to the Integer to Roman problem
//  Authors:            Bobby Mullins
//  Created:            Sunday, March 19, 2023 | (2023-03-19)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Integer to Roman problem methods
    /// </summary>
    internal class Problem12
    {
        /// <summary>
        /// Solution for Integer to Roman problem
        /// </summary>
        /// <param name="num">integer to convert to roman numerals in string format</param>
        /// <returns>'num' integer in roman numeral format</returns>
        public static string IntToRoman(int num)
        {
            int i = 12;               //Highest index of both symbols and values arrays
            string romanNumeral = ""; //Final roman numeral as string to return

            //Dictionary of symbols and values for roman numeral to integer conversion
            Dictionary<int, string> valSyms = new()
            {
                [1] = "I",
                [4] = "IV",
                [5] = "V",
                [9] = "IX",
                [10] = "X",
                [40] = "XL",
                [50] = "L",
                [90] = "XC",
                [100] = "C",
                [400] = "CD",
                [500] = "D",
                [900] = "CM",
                [1000] = "M"
            };

            //Goes through each order of magnitude (correct word?) within the roman numerals
            //until input number is finally equal to 0
            while (num > 0)
            {
                int tempNum = num / valSyms.ElementAt(i).Key;
                num %= valSyms.ElementAt(i).Key;

                //While temporary number is higher than 0
                //Go through each conversion within the 'valSyms' dictionary and add them to final 'romanNumeral'
                while (tempNum != 0)
                {
                    tempNum--;
                    romanNumeral += valSyms.ElementAt(i).Value;
                }

                i--;
            }

            //Return final converted roman numeral
            return romanNumeral;

        }//end IntToRoman()

    }//end Problem12 class
}

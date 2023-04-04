/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem8.cs
//  Description:        Problem8 class for testing solutions to the String To Integer (Atoi) problem
//  Authors:            Bobby Mullins
//  Created:            Friday, March 3, 2023 | (2023-03-03)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for String To Integer (Atoi) problem methods
    /// </summary>
    public class Problem8
    {
        /// <summary>
        /// Solution for String To Integer (Atoi) problem
        /// </summary>
        /// <param name="s">input string to convert to integer</param>
        /// <returns>integer from input string clamped to 32-bit</returns>
        public static int MyAtoi(string s)
        {
            int pointer = 0;        //Where the pointer in the string currently is
            string numString = "";  //String to build from 's' input       

            //Removes all leading and trailing whitespace (even though constraints just use leading spaces as whitespace)
            s = s.Trim();

            //Invalid Input Checks
            //If string is null or empty after removing all leading and/or trailing whitespace, return 0
            if(string.IsNullOrEmpty(s) == true)
            { return 0; }

            //If both the first and second characters in the string are not a digit, return 0
            if (char.IsDigit(s[0]) == false)
            {
                if(s.Length == 1)
                { return 0; }

                if(char.IsDigit(s[1]) == false)
                { return 0; }

                //If the first character is not a negative sign or positive sign, return 0
                if (s[0] != '-' && s[0] != '+')
                {
                    return 0;
                }
            }

            //Increments pointer forward if a plus or negative exists
            if (s[pointer] == '-' || s[pointer] == '+')
            {
                //Make 'numString' start with negative sign is in front of number if within 's'
                if (s[pointer] == '-')
                {
                    numString += '-';
                }

                pointer++; //Increment pointer to next position for digits
            }

            //While the pointer is on a digit, add to the 'numString'
            while(char.IsDigit(s[pointer]) == true)
            {
                numString += s[pointer];
                pointer++;

                if(pointer == s.Length)
                {
                    break;
                }
            }

            //Check if number is valid and fits within sign 32-bit range
            if (int.TryParse(numString, out int newInt) == true)
            {
                return newInt;
            }
            //Clamp number if outside of signed 32-bit range
            else
            {
                //If negative, return min value, else return max value 
                if (numString[0] == '-')
                {
                    return int.MinValue;
                }
                else
                {
                    return int.MaxValue;
                }
            }

        }//end MyAtoi()

    }//end Problem8 class
}

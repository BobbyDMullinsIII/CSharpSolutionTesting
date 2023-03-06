/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          PalindromeNumber.cs
//  Description:        PalindromeNumber class for testing solutions to the Palindrome Number problem
//  Authors:            Bobby Mullins
//  Created:            Saturday, March 4, 2023 | (2023-03-04)
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
    ///  Class for Palindrome Number problem methods
    /// </summary>
    internal static class PalindromeNumber
    {
        /// <summary>
        /// Solution for Palindrome Number problem
        /// </summary>
        /// <param name="x">input integer to check if palindrome</param>
        /// <returns>whether or not 'x' is a palindrome number</returns>
        public static bool IsPalindrome(int x)
        {
            int n = x;
            int tempNum;
            int finalNum = 0;

            //Will loop until 'n' equals zero after going through each "digit" in 'x'
            while (n > 0)
            {
                tempNum = n % 10; //Modulo n by 10 for temp num each loop
                finalNum = (finalNum * 10) + tempNum;
                n /= 10; //Go down to next "digit" in 'x' number for next loop
            }

            //If the final looped number is equal to the initial 'x' integer, 'x' is a palindrome
            if(finalNum == x)
            {
                return true;
            }
            //Else 'x' is not a palindrome
            else
            {
                return false;
            }

        }//end IsPalindrome()

    }//end PalindromeNumber class
}

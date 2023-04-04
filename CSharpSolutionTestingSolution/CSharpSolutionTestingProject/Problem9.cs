/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem9.cs
//  Description:        Problem9 class for testing solutions to the Palindrome Number problem
//  Authors:            Bobby Mullins
//  Created:            Saturday, March 4, 2023 | (2023-03-04)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Palindrome Number problem methods
    /// </summary>
    public class Problem9
    {
        /// <summary>
        /// Solution for Palindrome Number problem
        /// </summary>
        /// <param name="x">input integer to check if palindrome</param>
        /// <returns>whether 'x' is a palindrome number</returns>
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

    }//end Problem9 class
}

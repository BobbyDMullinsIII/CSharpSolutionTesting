﻿/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem7.cs
//  Description:        Problem7 class for testing solutions to the Reverse Integer class problem
//  Authors:            Bobby Mullins
//  Created:            Wednesday, March 1, 2023 | (2023-03-01)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Reverse Integer problem methods
    /// </summary>
    public class Problem7
    {
        //Problem 7
        //Method for running MedianTwoSortedArrays solution
        public static void RunProblem7()
        {
            //Main variables
            int x = 123;
            int reversedNumber;

            //Execute solution
            //reversedNumber = Problem7.ReverseSimple(x); //Simpler solution
            reversedNumber = Problem7.ReverseFasterSmaller(x);//Slightly faster and more space efficient solution

            //Solution printed out to console
            Console.WriteLine(reversedNumber);

        }//end RunProblem7()

        /// <summary>
        /// Simple solution for Reverse Integer problem
        /// </summary>
        /// <param name="x">integer to reverse</param>
        /// <returns>reverse of integer 'x'(unless goes over 32-bit integer limit, then returns 0)</returns>
        public static int ReverseSimple(int x)
        {
            //Variables
            List<char> charList = new();
            charList.AddRange(x.ToString());

            //Removes negative sign (first char) for the time being if number is negative
            if (x < 0)
            {
                charList.RemoveAt(0);
            }

            charList.Reverse(); //Reverse number

            //Adds negative sign back in if number is negative
            if (x < 0)
            {
                charList.Insert(0, '-');
            }

            //Check if number is valid and did not overflow or underflow
            if (int.TryParse(string.Concat(charList), out int reverseInt) == true)
            {
                return reverseInt;
            }
            else
            {
                return 0; //Returns 0 if underflow or overflow occurred
            }

        }//end ReverseSimple()

        /// <summary>
        /// Faster and more space efficient solution for Reverse Integer problem
        /// </summary>
        /// <param name="x">integer to reverse</param>
        /// <returns>reverse of integer 'x'(unless goes over 32-bit integer limit, then returns 0)</returns>
        public static int ReverseFasterSmaller(int x)
        {
            //Variables
            string strNum = x.ToString();

            //If x is a positive number
            if (x >= 0)
            {
                char[] charArray = strNum.ToCharArray(); //Convert string to char array
                Array.Reverse(charArray);                //Reverse number characters
                strNum = new string(charArray);          //Convert back to string
            }
            //If x is a negative number
            else
            {
                strNum = strNum[1..];                    //Removes negative sign (first char) for the time being
                char[] charArray = strNum.ToCharArray(); //Convert string to char array
                Array.Reverse(charArray);                //Reverse number characters
                strNum = new string(charArray);          //Convert back to string
                strNum = strNum.Insert(0, "-");          //Adds negative sign back into string number
            }

            //Return calculated reversed 32-bit integer, return 0 if overflow or underflow occurs
            if (int.TryParse(strNum, out int reverseInt) == true)
            {
                return reverseInt;
            }
            else
            {
                return 0;
            }

        }//end ReverseFasterSmaller()

    }//end Problem7 class
}

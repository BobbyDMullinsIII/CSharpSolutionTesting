///////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Reverse32BitIntegerStatic.cs
//  Description:        Reverse32BitIntegerStatic class for testing solutions to the Reverse Integer class problem
//  Authors:            Bobby Mullins
//  Created:            Wednesday, March 1, 2023 | (2023-03-01)
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
    ///  Class for Reverse Integer problem methods
    /// </summary>
    internal class Reverse32BitIntegerStatic
    {
        /// <summary>
        /// Solution for Reverse Integer problem
        /// </summary>
        /// <param name="x">integer to reverse</param>
        /// <returns>reverse of integer 'x'(unless goes over 32-bit integer limit, then returns 0)</returns>
        public static int Reverse(int x)
        {
            //Variables
            char[] charArray = x.ToString().ToCharArray();

            //If x is a positive number
            if (x >= 0)
            {
                Array.Reverse(charArray); //Reverse number characters
            }
            //If x is a negative number
            else
            {
                charArray = charArray[1..];        //Removes negative sign (first char) for the time being
                Array.Reverse(charArray);          //Reverse number characters
                charArray = String.Insert(0, "-"); //Adds negative sign back into string number
            }

            //Return calculated reversed 32-bit integer, return 0 if overflow or underflow occurs
            if (int.TryParse(charArray, out int reverseInt) == true)
            {
                return reverseInt;
            }
            else
            {
                return 0;
            }

        }//end Reverse()

    }//end Reverse32BitIntegerStatic
}

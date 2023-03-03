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
using System.Collections;
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
            List<char> charList = new();
            charList.AddRange(x.ToString());

            //Removes negative sign (first char) for the time being if number is negative
            if (x < 0)
            {
                charList.RemoveAt(0);
            }

            charList.Reverse(); //Reverse number

            //Adds negative sign back in if number ws negative
            if (x < 0)
            {
                charList.Insert(0, '-');
            }

            //Check if number is valid and did not overflow or underflow
            if (int.TryParse(String.Concat(charList), out int reverseInt) == true)
            {
                return reverseInt;
            }
            else
            {
                return 0; //Returns 0 if underflow or overflow occurredx
            }

        }//end Reverse()

    }//end Reverse32BitIntegerStatic
}

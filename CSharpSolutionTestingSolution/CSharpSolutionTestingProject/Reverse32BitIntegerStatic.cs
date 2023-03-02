﻿///////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Reverse32BitIntegerStatic.cs
//  Description:        Reverse32BitIntegerStatic class for testing solutions to the Reverse Integer class problem
//  Authors:            Bobby Mullins
//  Created:            Friday, March 1, 2023 | (2023-03-01)
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

        }//end Reverse()

    }//end Reverse32BitIntegerStatic
}

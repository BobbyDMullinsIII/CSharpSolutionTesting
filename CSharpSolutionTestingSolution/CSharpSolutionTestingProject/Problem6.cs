/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem6.cs
//  Description:        Problem6 class for testing solutions to the Zigzag Conversion problem
//  Authors:            Bobby Mullins
//  Created:            Sunday, March 5 2023 | (2023-03-05)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Zizzag Conversion problem methods
    /// </summary>
    public class Problem6
    {
        //Problem 6
        //Method for running ZigzagConversion solution
        public static void RunProblem6()
        {
            //Main variables
            string s = "PAYPALISHIRING";
            int numRows = 3;
            string converted;

            //Execute solution
            converted = Problem6.Convert(s, numRows);

            //Solution printed out to console
            Console.WriteLine(converted);

        }//end RunProblem6

        /// <summary>
        /// Solution for Zigzag Conversion problem
        /// </summary>
        /// <param name="s">string to convert</param>
        /// <param name="numRows">number of rows that zigzag pattern uses</param>
        /// <returns>string after zigzag conversion using 's' string with 'numRows' number of rows</returns>
        public static string Convert(string s, int numRows)
        {
            //If string is null or empty, only has one character, or the rows is equal to 1, return itself
            if (string.IsNullOrEmpty(s) == true || s.Length == 1 || numRows == 1)
            { return s; }

            char[] charArray;    //Array of characters for return value (strings dont allow modification of specific character indexes)
            int indexStr = 0;    //Index of string 's' pointer
            int indexRow = 0;    //Index of row pointer
            bool nextRow = true; //Whether or not the indexStr should go the next row down

            //Set character array to string length and loop through each string character for each iteration
            charArray = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                charArray[i] = s[indexStr];

                //Stay on current row if nextRow is false
                if (nextRow == false)
                {
                    indexStr += (indexRow * 2);
                }
                //Add number of rows 'numRows' to calculation if nextRow is true
                else
                {
                    indexStr += (numRows - indexRow - 1) * 2;
                }

                //Invert 'nextRow' if 'indexRow' pointer is not zero
                if (indexRow != 0)
                {
                    nextRow = !nextRow;
                }

                //If 'indexStr' is larger than the actual length of 's'
                //Go to top row by setting 'nextRow' to true and setting the pointers accordingly
                if (indexStr >= s.Length)
                {
                    indexRow++; //Increase row pointer to next row if the 'indexStr' pointer has gone outside of the string
                    nextRow = true;
                    indexStr = indexRow;

                    //If the 'indexRow' pointer is equal to 1 below the number of rows in the zigzag conversion, reset it
                    if (indexRow == (numRows - 1))
                    {
                        indexRow = 0;
                    }
                }
            }

            //Convert final charArray to string and return
            return new string(charArray);

        }//end Convert()

    }//end Problem6() class
}

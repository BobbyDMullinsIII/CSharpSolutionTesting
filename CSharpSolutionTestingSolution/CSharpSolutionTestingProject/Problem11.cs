/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem11.cs
//  Description:        Problem11 class for testing solutions to the Container With Most Water problem
//  Authors:            Bobby Mullins
//  Created:            Saturday, March 11 2023 | (2023-03-11)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Container With Most Water problem methods
    /// </summary>
    public class Problem11
    {
        /// <summary>
        /// Brute force solution for Container With Most Water problem
        /// </summary>
        /// <param name="height">integer array to determine what two points can hold the most water or area</param>
        /// <returns>largest area between two indexes that can "hold the most water" (or area)</returns>
        public static int MaxAreaBruteForce(int[] height)
        {
            int xVal;        //Value for area calculation (x is length between indices)
            int yVal;        //Value for area calculation (y is height of smaller index in current calculation)
            int area;        //Area of current calculation
            int maxArea = 0; //Maximum calculated area

            //Compares each index to each other with two for loops (Can result in some duplicate calculations)
            for (int i = 0; i < height.Length; i++) 
            {
                for (int j = 0; j < height.Length; j++)
                {
                    //Will not calculate area with and index against itself
                    if ( i != j )
                    {
                        xVal = Math.Abs(i - j);
                        yVal = Math.Min(height[i], height[j]);
                        area = xVal * yVal;

                        maxArea = Math.Max(maxArea, area);
                    }
                }
            }

            //Returns final calculated max area
            return maxArea;

        }//end MaxAreaBruteForce()

        /// <summary>
        /// More efficient solution for Container With Most Water problem
        /// </summary>
        /// <param name="height">integer array to determine what two points can hold the most water or area</param>
        /// <returns>largest area between two indexes that can "hold the most water" (or area)</returns>
        public static int MaxAreaEfficient(int[] height)
        {
            int i = 0;                 //Starts at the beginning of 'height' array
            int j = height.Length - 1; //Starts at the end of 'height' array
            int area;                  //Area of current calculation
            int maxArea = 0;           //Maximum calculated area

            //Will not result in duplicate calculations, unlite brute force method
            while (i < j)
            {
                //Compares 'area' of current calculation with the 'maxArea' calculated so far
                area = Math.Min(height[i], height[j]) * (j - i);
                maxArea = Math.Max(maxArea, area);

                //Brings i and j closer if their current indexes are of differing heights
                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            //Returns final calculated max area
            return maxArea;

        }//end MaxAreaEfficient()

    }//end Problem11 class
}

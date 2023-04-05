/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          Problem2.cs
//  Description:        Problem2 class for testing solutions to the Add Two Numbers problem
//  Authors:            Bobby Mullins
//  Created:            Wednesday, March 1, 2023 | (2023-03-01)
//  Copyright:          N/A
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LeetCodeProject
{
    /// <summary>
    ///  Class for Add Two Numbers problem methods
    /// </summary>
    public class Problem2
    {
        //Problem 2
        //Method for running AddTwoNumbers solution
        public static void RunProblem2()
        {
            //Main variables
            ListNode l1 = new();
            ListNode l2 = new();
            ListNode lSum;

            //Execute solution
            lSum = Problem2.AddTwoNumbers(l1, l2);

            //Solution printed out to console
            //lSum.ToList().ForEach(i => Console.WriteLine(i.ToString()));

        }//end RunProblem2()

        /// <summary>
        /// Solution for AddTwoNumbers problem
        /// </summary>
        /// <param name="l1">First ListNode representation of number to add</param>
        /// <param name="l2">Second ListNode representation of number to add</param>
        /// <returns>ListNode of l1 and l2 list nodes added together as numbers</returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //Variables
            ListNode sumNode = new();



            //Returns sum as ListNode
            return sumNode;

        }//end AddTwoNumbers

    }//end Problem2 class
}

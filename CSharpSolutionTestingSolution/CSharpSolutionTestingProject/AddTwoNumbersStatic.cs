/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Solution/Project:   LeetCodeSolution/LeetCodeProject
//  File Name:          AddTwoNumbersStatic.cs
//  Description:        AddTwoNumbersStatic class for testing solutions to the Add Two Numbers problem
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
    ///  Class for Add Two Numbers problem methods
    /// </summary>
    internal static class AddTwoNumbersStatic
    {
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

    }//end AddTwoNumbersStatic class

    //Definition for singly-linked list. (Provided by LeetCode)
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

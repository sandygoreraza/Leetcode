﻿using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System;

namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {


/*  Given an array of integers nums and an integer targetNumber, return indices of the two numbers such that they add up to targetNumber.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.




Example 1:

Input: nums = [2, 7, 11, 15], target = 9
Output: [0, 1]
Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3, 2, 4], target = 6
Output: [1, 2]
Example 3:

Input: nums = [3, 3], target = 6
Output: [0, 1] */


            /*******Solution*******/

            /****THE SOLUTION WAS TESTED USING 63 TEST CASES FROM Letcode****/

            AddingArray addingArray = new AddingArray();

            int[] testArray = { 2, 5, 5, 11 };
            int targetNumber = 10;
           
           Console.WriteLine(string.Join(",", addingArray.TwoSum(testArray, targetNumber)));

            Console.ReadLine();

        }
    }
}

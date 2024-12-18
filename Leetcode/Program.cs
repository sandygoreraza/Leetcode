using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System;

namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*NO AI WAS USED. HONEST TESTS. TESTING MY SKILLS AS AN EXPERIENCED SENIOR DEVELOPER */

            /****THE SOLUTION WAS TESTED USING 63 TEST CASES FROM Letcode****/

            /**** For Brief explanation for each scenario / Challenge please check each classes ****/

            /**** Challenge 1  Two Sum from Array ****/
            TwoSumArray twoSumArray = new TwoSumArray();

            int[] testArray = { 2, 5, 5, 11 ,12,13};
            int targetNumber = 25;
           
           Console.WriteLine($"" + string.Join(",", twoSumArray.TwoSum(testArray, targetNumber)) + "\n");


            /**** Challenge 2 - Best Time to Buy and Sell Stock II ****/
            BestTimeBuySellStock bestTimeBuySellStock = new BestTimeBuySellStock();

            int[] testPrices = { 7, 1, 5, 3, 6, 4 };
            int expectedProfit = 7;

            Console.WriteLine($"Expected profit is {expectedProfit} from Array [{string.Join(",", testPrices)}]" + "\n");




            /**** Challenge 3 - Remove Duplicates from Sorted Array ****/
            RemoveDuplicatesSortedArray removeDuplicatesSortedArray = new RemoveDuplicatesSortedArray();


            int[] testSortedArray = { 1, 1, 2 , 3, 3 , 4, 5 };
            int[] expectedArray = { 1, 2,3,4,5 };

            Console.WriteLine($"Sorted array with Duplicates : [{string.Join(",", testSortedArray)}] expected array : [{string.Join(",", expectedArray)}]");








            Console.ReadLine();

        }
    }
}

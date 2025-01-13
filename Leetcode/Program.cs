namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /**** Challenge 1  Two Sum from Array ****/
             Console.ForegroundColor = ConsoleColor.White;
             Console.WriteLine($"Challenge 1  Two Sum from Array : \n");
             TwoSumArray twoSumArray = new TwoSumArray();

             int[] testArray = { 2, 5, 5, 11, 12, 13 };
             int targetNumber = 25;

             Console.WriteLine($"[" + string.Join(",", twoSumArray.TwoSum(testArray, targetNumber)) + "]\n");


            /**** Challenge 2 - Best Time to Buy and Sell Stock II ****/
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine($"Challenge 2 - Best Time to Buy and Sell Stock II : \n");
             BestTimeBuySellStock bestTimeBuySellStock = new BestTimeBuySellStock();

             int[] testPrices = { 7, 1, 5, 3, 6, 4 };
             int expectedProfit = 6;

             Console.WriteLine($"Expected profit is {expectedProfit} from Array [{string.Join(",", testPrices)}]" + "\n");




            /**** Challenge 3 - Remove Duplicates from Sorted Array ****/
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.WriteLine($"Challenge 3 - Remove Duplicates from Sorted Array : \n");
             RemoveDuplicatesSortedArray removeDuplicatesSortedArray = new RemoveDuplicatesSortedArray();


             int[] testSortedArray = { 1, 1, 2, 3, 3, 4, 5 };
             int[] expectedArray = { 1, 2, 3, 4, 5 };

             Console.WriteLine($"Sorted array with Duplicates : [{string.Join(",", testSortedArray)}] expected array : [{string.Join(",", expectedArray)}]\n");




            ///Challenge 4 - Rotate array challenge
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Challenge 4 - Rotate array challenge: \n");



            int[] testRotateArray = { -1, -100, 3, 99 };

            int k = 21;

            RotateArrayQuick rotateArray = new RotateArrayQuick();
            rotateArray.Rotate(testRotateArray, k);



            Console.ReadLine();

        }
    }
}

# Leetcode  challenges

**Check out code challenges done on Leetcode plateform. More than 63 test cases were used for all the challenges below**


**Disclaimer:**  These challenges were done without using an AI .Honest Solutions provided to my best ability 


- [x] Challenge 1 - Two Sum from Array
- [x] Challenge 2 - Remove Duplicates from Sorted Array
- [x] Challenge 3 - Best Time to Buy and Sell Stock II

<details open>

<summary> **Challenge 1 - Two Sum from Array**</summary>

### Two Sum

Challenge title :Two Sum


Scenario :

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 10^4
-109 <= nums[i] <= 10^9
-109 <= target <= 10^9
Only one valid answer exists.
 

```C#
    public class TwoSumArray
    {


        public int[] TwoSum(int[] nums, int target)
        {


            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
             

                    for (int j = i+1; j < nums.Length ; j++)
                    {
                        
                        sum = nums[i] + nums[j];
                 
                        if (sum == target)
                        {

                            int[] newIndices = { i, j };

                            return newIndices;
                        }

                    }

               

            }

            return new int[0];
        }

    }
```

</details>




<details>

<summary>**Challenge 2 - Remove Duplicates from Sorted Array**</summary>

### Remove Duplicates from Sorted Array

Challenge title :Remove Duplicates from Sorted Array


Scenario :

Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
Return k.
Custom Judge:

The judge will test your solution with the following code:

int[] nums = [...]; // Input array
int[] expectedNums = [...]; // The expected answer with correct length

int k = removeDuplicates(nums); // Calls your implementation

assert k == expectedNums.length;
for (int i = 0; i < k; i++) {
    assert nums[i] == expectedNums[i];
}
If all assertions pass, then your solution will be accepted.

 

Example 1:

Input: nums = [1,1,2]
Output: 2, nums = [1,2,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
Example 2:

Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
 

Constraints:

1 <= nums.length <= 3 * 10^4
-100 <= nums[i] <= 10^0
nums is sorted in non-decreasing order.
 
 

```C#
      internal class RemoveDuplicatesSortedArray
    {

        public int RemoveDuplicates(int[] nums)
        {


            if (nums.Length == 0) return 0;

            int uniqueIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[uniqueIndex])
                {
                    uniqueIndex++;
                    nums[uniqueIndex] = nums[i];
                }

            }

            return uniqueIndex + 1;

        }



    }
```

</details>



<details>

<summary>**Challenge 3 - Best Time to Buy and Sell Stock II**</summary>

### Best Time to Buy and Sell Stock II

Challenge title : Best Time to Buy and Sell Stock II


Scenario :

You are given an integer array prices where prices[i] is the price of a given stock on the ith day.

On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can buy it then immediately sell it on the same day.

Find and return the maximum profit you can achieve.

 

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 7
Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
Total profit is 4 + 3 = 7.
Example 2:

Input: prices = [1,2,3,4,5]
Output: 4
Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4.
Total profit is 4.
Example 3:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: There is no way to make a positive profit, so we never buy the stock to achieve the maximum profit of 0.
 

Constraints:

1 <= prices.length <= 3 * 10^4
0 <= prices[i] <= 10^4

 
 

```C#
  internal class BestTimeBuySellStock
    {

        public int MaxProfit(int[] prices)
        {

          
            int lastIndex = prices.Length - 1;
            int profits = 0;

            for (int i = 0; i < prices.Length; i++)
            {



                if (i + 1 <= lastIndex)
                {

                    if (prices[i] < prices[i + 1])
                    {

                        profits += prices[i + 1] - prices[i];

                    }


                }

                continue;


            }

            return profits;


        }


    } 
```

</details>

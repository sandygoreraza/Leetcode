# Leetcode  challenges

*** Check out code challenges done on Leetcode plateform ***
*** Disclaimer :  These challenges were done without using an AI .Honest Solutions provided to my best ability ***

<details open>

<summary>[x] ** Challenge 1 - Two Sum from Array **</summary>

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

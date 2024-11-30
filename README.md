# Leetcode  challenges
```
Code block
```# Intuition

<!-- Simple code solution for the below description. -->

 
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

 

# Approach


# Complexity
 
An algorithm that is less than O(n2) time complexity?
 
![Screenshot](https://myoctocat.com/assets/images/base-octocat.svg)
![alt text](https://github.com/sandygoreraza/Leetcode/blob/master/runtime.png?raw=true)

![screenshot](runtime.png)



- Space complexity:
<!-- Add your space complexity here, e.g. $$O(n)$$ -->


Below is the summary of the code written
# Code
```csharp []
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
              // Console.WriteLine(nums[i]);

                    //int start = (i == 0) ? 1 : 0;

                    for (int j = i+1; j < nums.Length ; j++)
                    {
                        
                        sum = nums[i] + nums[j];
                   // Console.WriteLine($"i element {nums[i]} adding j element {nums[j]} : sum is => {sum}");
                        if (sum == target)
                        {

                            int[] newindices = { i, j };

                            return newindices;
                        }

                    }

               

            }

            return new int[0];

    }
}
```

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class RotateArrayQuick
    {

        public void Rotate(int[] nums, int k)
        {
            int elementsCount = nums.Length;
            int steps = k;
            
            k %= elementsCount; // Handle cases where k > elementsCount

            if (k == 0 || elementsCount <= 1) return; // No rotation needed for these cases


            int[] toLeftShift = new int[k];
            int[] toRightShift = new int[nums.Length - k];
            int sPosition = elementsCount - k;
            int rshiftIndex = nums.Length - toRightShift.Length;
            int startingIndex = 0;
            int[] tempNumsArray = new int[nums.Length];
            
            for (int i = 0; i < nums.Length; i++)
            {
                tempNumsArray[i] = nums[i];

            }


            Console.WriteLine($"Initial array :[" + string.Join(",", tempNumsArray) + "]\n");

            Console.WriteLine($"If K = {steps} , then :\n");

            for (int i = 0; i < toLeftShift.Length; i++)
            {
           
                    toLeftShift[startingIndex++] = tempNumsArray[sPosition++];
            
            }



            for (int j = 0; j < toRightShift.Length; j++)
            {
            
                    toRightShift[j] = tempNumsArray[j];
         
            }

            for(int l = 0; l < toLeftShift.Length; l++)
            {
                nums[l] = toLeftShift[l];
            }

            for(int r = 0; r < toRightShift.Length ; r++)
            {
                nums[rshiftIndex++] = toRightShift[r];
            }


            Console.WriteLine($"Final Result (after swapping using {steps} k steps)    : [" + string.Join(",", nums) + "]\n");
           // Console.WriteLine($"To right Shift results    : [" + string.Join(",", toRightShift) + "]\n");




        }

        }
}

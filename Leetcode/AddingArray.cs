namespace Leetcode
{
    public class AddingArray
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
}

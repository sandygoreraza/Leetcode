using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class SingleNumberSearch
    {

        public int SingleNumber(int[] nums)
        {

            Array.Sort(nums);
            int? occurance = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {


                for (int j = 0; j <= nums.Length - 1; j++)
                {

                    if (nums[i] == nums[j])
                    {
                        occurance++;


                    }

                    if (occurance == 2)
                    {

                        occurance = 0;
                        break;
                    }



                }

                if (occurance == 1)
                {

                    return nums[i];
                }





            }




            return 0;
        }


    }
}

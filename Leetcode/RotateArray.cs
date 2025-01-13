using System;


namespace Leetcode
{
    internal class RotateArray
    {



        public void Rotate(int[] nums, int k)
        {
            int elementsCount = nums.Length;
            int lastIndex = nums.Length - 1;
            k %= elementsCount; // Handle cases where k > elementsCount

            if (k == 0 || elementsCount <= 1) return; // No rotation needed for these cases

            int[] arrayHolderD = new int[k];




            int sStart = 0, steps = 1;

            int counter = elementsCount - 1;





            int[] tempNumsArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                tempNumsArray[i] = nums[i];

            }


            Console.WriteLine($"Initial array :[" + string.Join(",", tempNumsArray) + "]\n");

            Console.WriteLine($"If K = {k} , then :\n");

            Console.WriteLine($"#### Swap array #####\n");





            if (lastIndex != 0)
            {

                for (int j = 0; j < k; j++)
                {

                    if (j == 0)
                    {
                        nums[j] = tempNumsArray[lastIndex];

                    }

                    if (j == 1)
                    {
                        nums[0] = tempNumsArray[lastIndex - 1];
                        nums[j] = tempNumsArray[lastIndex];

                    }

                    // swip array ,shift position then add
                    else if (j > 1)
                    {




                        for (int r2 = 0; r2 < j; r2++)
                        {

                            arrayHolderD[r2 + 1] = nums[r2];

                        }
                        arrayHolderD[0] = tempNumsArray[lastIndex - j];


                        for (int r3 = 0; r3 <= arrayHolderD.Length - 1; r3++)
                        {
                            nums[r3] = arrayHolderD[r3];
                        }


                    }



                    //////
                    for (int b = j + 1; b <= counter; b++)
                    {
                        nums[b] = tempNumsArray[sStart];
                        //if(b > 0) { arrayHolderC[b - 1] = 0; }

                        sStart++;
                    }


                    Console.WriteLine($"Step {steps}  : [" + string.Join(",", nums) + "]\n");
                    if (j > k - 2)
                    {
                        counter--;
                    }

                    sStart = 0;
                    steps++;


                }





            }



            Console.WriteLine($"Final result  : [" + string.Join(",", nums) + "]\n");

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class MinimumAbsoluteDifferenceInAnArray
    {
        public MinimumAbsoluteDifferenceInAnArray()
        {
            int[] arr = { -59, - 36, - 13, 1, - 53 ,- 92, - 2, - 96, - 54, 75 };
            //int[] arr = { 3,-7,0 };

            Array.Sort(arr);

            int min = Math.Abs(arr[0] - arr[1]);

          

            for (int i = 0; i < arr.Length-1; i++)
            {         
                    int result = Math.Abs(arr[i] - arr[i+1]);

                    if (min > result)
                    {
                        min = result;
                    }
            }


            Console.WriteLine(min);

        }
    }
}

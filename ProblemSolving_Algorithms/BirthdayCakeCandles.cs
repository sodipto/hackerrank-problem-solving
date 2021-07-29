using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class BirthdayCakeCandles
    {
        public BirthdayCakeCandles(int[]arr)
        {

            int max = arr[0];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }

            }

            for (int i = 0; i < arr.Length; i++)
            {

                if (max == arr[i])
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}

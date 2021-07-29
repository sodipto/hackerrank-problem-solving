using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class DivisibleSumPairs
    {
        public DivisibleSumPairs(int k,int[]ar)
        {
            int count = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j =i+1; j < ar.Length; j++)
                {
                    int result = ar[i] + ar[j];
                    if (result % k== 0)
                    {
                        count++;
                    }
                }

            }

            Console.WriteLine(count);

        }
    }
}

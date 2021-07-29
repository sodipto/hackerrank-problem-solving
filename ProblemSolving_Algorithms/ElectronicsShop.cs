using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class ElectronicsShop
    {
        public ElectronicsShop(int[] keyboards, int[] drives, int b)
        {

            int result = -1;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] <= b && keyboards[i] + drives[j]>result)
                    {
                        result = keyboards[i] + drives[j];
                 
                    }

                }
            }

            Console.WriteLine(result);

        }
    }
}

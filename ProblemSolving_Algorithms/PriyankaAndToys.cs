using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class PriyankaAndToys
    {
        public PriyankaAndToys(List<int> w)
        {
            w.Sort();
            int containerCount = 1;
            int m = 0;

            for (int i = 0; i < w.Count; i++)
            {
                if (w[i] > w[m] + 4)
                {
                    containerCount++;
                    m = i;
                }
            }

            Console.WriteLine(containerCount);
        }
    }
}

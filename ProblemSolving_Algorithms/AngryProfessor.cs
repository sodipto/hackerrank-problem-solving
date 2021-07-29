using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class AngryProfessor
    {
        public AngryProfessor(int k, int[] a)
        {
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 0)
                {
                    count++;

                }

            }

            if (count >= k)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

        }
    }
}

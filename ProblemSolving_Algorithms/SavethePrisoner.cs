using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class SavethePrisoner
    {
        public SavethePrisoner(int n, int m, int s)
        {
            // 1st way solve
            //int result = (s + m - 1) % n;



            // 2nd way
            if (n > m)
            {
                int result = (n%m)+s;
                Console.WriteLine(result);

            }

            else
            {
               

                if (m%n==0)
                {
                    Console.WriteLine(n); 
                }
                else
                {
                    int result = (m % n) + s - 1;
                    Console.WriteLine(result);
                }
                

            }

       

        }
    }
}

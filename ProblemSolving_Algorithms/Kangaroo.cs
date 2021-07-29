using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class Kangaroo
    {
        public Kangaroo(int x1, int v1, int x2, int v2)
        {

            if((x2>x1) && (v2 > v1))
            {
                Console.WriteLine("NO");
            }

            else
            {
                if ((v1!=v2) &&(x2-x1)%(v1-v2)==0)
                {
                    Console.WriteLine("Yes");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }

        }
    }
}

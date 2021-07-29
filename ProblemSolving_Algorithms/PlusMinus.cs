using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class PlusMinus
    {
        public PlusMinus(int[] arr)
        {
            decimal neg = 0;
            decimal pos = 0;
            decimal zero = 0;

            int ratio = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {

                    neg++;
                }

                if (arr[i]> 0)
                {

                    pos++;
                }

                if (arr[i]== 0)
                {

                    zero++;
                }

               




            }

        

            Console.WriteLine(string.Format("{0:0.000000}", pos/ratio));
            Console.WriteLine(string.Format("{0:0.000000}", neg/ratio));
            Console.WriteLine(string.Format("{0:0.000000}", zero/ratio));

        }
    }
}

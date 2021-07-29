using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class MiniMaxSum
    {
        public MiniMaxSum(int[]arr)
        {
            long Arraysum = 0;
      
            long maxvalue = arr.Max(); //array max value return
            long minvalue = arr.Min(); //array min value return

            for (int i = 0; i < arr.Length; i++)
            {
                Arraysum += arr[i];
                
            }
            Console.WriteLine("{0} {1}", Arraysum - maxvalue, Arraysum - minvalue);

        }
    }
}

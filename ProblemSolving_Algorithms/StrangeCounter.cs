using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class StrangeCounter
    {
        long result;
        public StrangeCounter(long t)
        {
            
            long counter = 3;
            long time = 1;
            while (time < t)
            {
                time = time + counter;
                counter = 2 * counter;
                if (time == t)
                {
                  result =counter;
                }
                else if (time > t)
                {
                  result=time - t;
                }
            }

            Console.WriteLine(result);



        }


    
  }
}

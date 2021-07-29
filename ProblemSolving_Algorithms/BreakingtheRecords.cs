using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class BreakingtheRecords
    {
        public BreakingtheRecords()
        {
            int[] scores = new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 }; //{12,24,10,24}; //{ 10, 5 ,20 ,20, 4, 5, 2, 25, 1 };   
            int maximum = 0;
            int minimum = 0;
            int max = 0;
            int min= 0;

            List<int> res = new List<int>();

            for (int i = 0; i < scores.Length; i++)
            {
                if (i == 0)
                {
                    maximum = scores[i];
                    minimum = scores[i];
                }
                else
                {
                    if (scores[i] > maximum)
                    {
                        max++;
                        maximum = scores[i];
                        minimum = minimum;
                    }
                    else if(maximum== scores[i])
                    {

                    }
                    else
                    {
                        if (scores[i] < minimum)
                        {
                            min++;
                            maximum = maximum;
                            minimum = scores[i];
                        }

                    }
                }
            }
            res.Add(max);
            res.Add(min);
            //Console.WriteLine("max:" + max);
            //Console.WriteLine("min:" + min);
            Console.WriteLine(res.ToArray());
        }
    }
}

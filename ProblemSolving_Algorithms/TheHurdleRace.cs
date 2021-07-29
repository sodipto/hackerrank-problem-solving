using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class TheHurdleRace
    {
        public TheHurdleRace(int k, int[] height)
        {
            int result = 0;
            int max = 0;

            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] - k > 0) 
                {
                    result = height[i] - k;

                    if (result > max)
                    {
                        max = result;
                    }

                }


            }

           Console.WriteLine(max);
                
        }
    }
}

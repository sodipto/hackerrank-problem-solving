using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class Intro_toTutorial_Challenges
    {
        public Intro_toTutorial_Challenges(int[]arr,int v)
        {
            //int[] arr = { 1, 4, 5, 7, 9, 12 };
            //int v = 4;
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == v)
                {
                    result = i;
                }

            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class GradingStudents
    {
        public GradingStudents(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                if(grades[i]>=38 && grades[i] % 5 > 2)
                {
                    grades[i] = grades[i] + (5 - (grades[i] % 5));

                }

                Console.WriteLine(grades[i]);

            }
        }
    }
}

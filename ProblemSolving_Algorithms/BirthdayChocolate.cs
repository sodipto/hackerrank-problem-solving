using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class BirthdayChocolate
    {
        public BirthdayChocolate()
        {
            List<int> s = new List<int>() { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 }; // {1, 2, 1, 3, 2};

            int day = 18;
            int m = 7;
            int count = 0;
            if (s.Count==1)
            {
                count = 1;
            }
            else
            {
                for (int i = 0; i < s.Count-(m-1); i++)
                {
                        if (s.Skip(i).Take(m).Sum() == day)
                        {
                            count++;
                        }
                }
            }
            
            Console.WriteLine(count);
        }
    }
}

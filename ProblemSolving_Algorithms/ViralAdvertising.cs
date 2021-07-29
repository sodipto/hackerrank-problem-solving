using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class ViralAdvertising
    {
        public ViralAdvertising(int n)
        {
            decimal people = 5;
            int totalPeople = 0;
           
            for (int i = 0; i <n; i++)
            {
                people = Math.Floor(people / 2);
                totalPeople =(int) (totalPeople + people);
                people = (int)(people * 3);

            }

            Console.WriteLine(totalPeople);
        }
    }
}

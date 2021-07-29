using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class BeautifulDaysattheMovies
    {

        public BeautifulDaysattheMovies(int i, int j, int k)
        {
            int number, reversedNumber = 0, remainder;
            int count = 0;
            int day;
            for (int m = i; m <= j; m++)
            {

                number=i;

                while (number != 0)
                {
                    remainder = number % 10;
                    reversedNumber = reversedNumber * 10 + remainder;
                    number /= 10;
                }

                day = Math.Abs(number - reversedNumber) / k;

                if (day%2 == 0)
                {
                    count++;
                }

            }

            Console.WriteLine(count);


        }
    }
}

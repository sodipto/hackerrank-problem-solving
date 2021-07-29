using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class DayoftheProgrammer
    {
        public DayoftheProgrammer()
        {
            int year = 1918;

            string date;
            if (year == 1918)
            {
                date = string.Format("26.09.{0}", year); //2018 year feruary 14 days so 14+12=26
            }           
            else if ((year<=1917 && year % 4 == 0) || (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                date = string.Format("12.09.{0}", year);
            }
            else
            {
                date = string.Format("13.09.{0}", year);
            }
            Console.WriteLine(date);

        }
    }
}

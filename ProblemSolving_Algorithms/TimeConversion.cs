using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class TimeConversion
    {
        public TimeConversion(string Time)
        {
            var time = DateTime.Parse(Time);

            Console.WriteLine(time.ToString("HH:mm:ss"));

        }
    }
}

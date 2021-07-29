using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class FindDigits
    {
        public FindDigits(int n)
        {
            var result=n.ToString().ToCharArray().Select(s => char.GetNumericValue(s)).Count(c => n % c == 0);
            Console.WriteLine(result);
        }
    }
}

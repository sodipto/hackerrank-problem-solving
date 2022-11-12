using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class MissingNumbers
    {
        public MissingNumbers(List<int> arr, List<int> brr)
        {
            var missingNumbers = new List<int>();
            foreach (var number in brr)
            {
                if (arr.Contains(number))
                    arr.Remove(number);
                else
                    missingNumbers.Add(number);
            }

            missingNumbers = missingNumbers.Distinct().ToList();
            missingNumbers.Sort();

            Console.WriteLine(string.Join(" ", missingNumbers));
        }
    }
}
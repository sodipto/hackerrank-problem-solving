using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class MaxMIn
    {
        public MaxMIn()
        {
            var arr = new List<int> { 100, 2, 3, 4, 10, 20, 30, 40, 100, 1 };
            //var arr = new List<int> {6327,571,6599,479,7897,9322,4518,571,6677,7432,815,6920,4329,4104,7775,5708,7991,5802,8619,6053,7539,7454,9000,3267,6343,7165,4095,439,5621,4095,153,
            //    1948,1018,6752,8779,5267,2426,9649,2190,9103,7081,3006,2376,7762,3462,151,3471,1453,2305,8442
            //};

            int k = 4;
            int result = int.MaxValue;
            arr.Sort();

            // Find minimum value among
            // all K size subarray.
            for (int i = 0; i <= arr.Count - k; i++)
            {
                Console.WriteLine(string.Format("{0}-{1}={2}", arr[i + k - 1], arr[i], arr[i + k - 1] - arr[i]));
                result = Math.Min(result, arr[i + k - 1] - arr[i]);
                //Console.WriteLine(c);
                //c++;
            }

            //arr.Sort();
            //arr = arr.Take(k).ToList();
            //var res = arr.Max() - arr.Min();

            Console.WriteLine(result);
        }

    }
}

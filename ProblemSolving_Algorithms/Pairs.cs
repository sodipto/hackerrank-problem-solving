using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class Pairs
    {
        public Pairs()
        {
            var arr = new List<int> { 1, 5, 3, 4, 2 };
            int k = 2;

            int count = 0;

            //time out

            //arr = arr.OrderByDescending(x => x).ToList();
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    for (int j = i + 1; j < arr.Count; j++)
            //    {
            //        int result = arr[i] - arr[j];
            //        if (result == k)
            //            count++;
            //    }
            //}

            var list = new HashSet<int>(arr);
            foreach (var item in list)
            {
                var val = item - k;
                if (list.Contains(val))
                    count += 1;
            }


            Console.WriteLine(count);
        }
    }
}

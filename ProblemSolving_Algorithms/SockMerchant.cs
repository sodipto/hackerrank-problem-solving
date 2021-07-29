using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class SockMerchant
    {
        public SockMerchant()
        {
            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20};
            List<int> d = new List<int>();

            var PairList = ar.GroupBy(x => x)
               .Where(g => g.Count() > 1)
               .Select(y => new { Element = y.Key, Counter = y.Count() })
               .ToList();

            foreach (var item in PairList)
            {
                if (item.Counter%2 == 0)
                {
                    d.Add(item.Counter);
                }
                else
                {
                    d.Add(item.Counter-1);
                }
            }


            Console.WriteLine(d.Sum()/2);

        }
    }
}

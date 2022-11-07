using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class MigratoryBirds
    {
        public MigratoryBirds(List<int> arr)
        {
            var list = arr.GroupBy(x => x).Select(x => new { key = x.Key, val = x.Count() })
                .OrderBy(x => x.key).ToList();

            var item= list.Max(x => x.val);
            var key = list.FirstOrDefault(x => x.val == item).key;

            Console.WriteLine(key);
        }
    }
}

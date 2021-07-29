using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class CamelCase
    {
        public CamelCase(string s)
        {

            //another way
            //int count = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (char.IsUpper(s[i]))
            //    {
            //        count++;
            //    }
            //}

            int count = s.Count(c => char.IsUpper(c));

            //iF begain first char always small so count+1
            Console.WriteLine(count);
        }
    }
}

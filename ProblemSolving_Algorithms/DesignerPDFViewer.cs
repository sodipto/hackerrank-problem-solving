using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class DesignerPDFViewer
    {
        public DesignerPDFViewer()
        {
            List<int> data = new List<int>();
            List<int> filterList = new List<int>();

            IDictionary<int, char> dict = new Dictionary<int, Char>();
            for (char c = 'a'; c <= 'z'; c++)
            {
                int key = c - 'a' + 1;
                dict.Add(key, c);
            }

            int[] h = new int[] { 1, 3, 1, 3, 1, 4, 1, 3 ,2, 5 ,5, 5, 5, 5, 5 ,5, 5, 5, 5, 5, 5, 5 ,5, 5, 5, 7 }; //{ 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            string word = "zaba";
            //string word = "abc";

            var wordAry = word.ToCharArray();
            int Lenght = word.Length;

            foreach (var item in dict)
            {
                foreach (var ch in wordAry)
                {
                    if (item.Value == ch)
                    {
                        data.Add(item.Key);
                    }
                }
               
            }
            //for array position value get 
            foreach (var item in data)
            {
                var position = h[item - 1];
                filterList.Add(position);
            }

            int Result = filterList.Max()*1* Lenght;

            Console.WriteLine(Result);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class BonAppetit
    {
        public BonAppetit(int[] bill, int k, int b)
        {
            // i use array when i list use this code use
            /*
            bill.RemoveAt(k);
            int actual = bill.Sum() / 2;

            if (actual == b)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(b - actual);
          */
            int sum = 0;
            int actual;
            int result = 0;
            for (int i = 0; i < bill.Length; i++)
            {
                sum += bill[i];

            }

            actual = ((sum - bill[k]) / 2);

            if (b > actual)
            {
                result = b - actual;
                Console.WriteLine(result);
            }

            if (b == actual)
            {
                Console.WriteLine("Bon Appetit");
            }

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class LibraryFine
    {
        public LibraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int fine;
            if (y1 > y2)
            {
                fine = 10000;
            }
                
            else if (m1 > m2 && y1 == y2)
            {
                fine = 500 * (m1 - m2);
            }
                
            else if (d1 > d2 && m1 == m2 && y1 == y2)
            {
                fine = 15 * (d1 - d2);
            }

            else
            {
                fine = 0;
            }
              
          
            Console.WriteLine(fine);

        }
    }
}

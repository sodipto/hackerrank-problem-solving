using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class CatAndMouse
    {
        public CatAndMouse(int x, int y, int z)
        {
            string msg = "";

            if (Math.Abs(x-z)>Math.Abs(y-z))
            {
                msg = "Cat B";
            }

            else if (Math.Abs(x - z) < Math.Abs(y - z))
            {

                msg = "Cat A";
            }

            else
            {
                
                msg = "Mouse C";

            }

            Console.WriteLine(msg);

        }
    }
}

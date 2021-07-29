using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class StrongPassword
    {
        public StrongPassword(string password )
        {
           // string password = "E!%Z@";

            var match = password.Any(ch => !char.IsLetterOrDigit(ch));
            var uppercase = password.Count(x =>char.IsUpper(x));
            var lowercase = password.Count(x => char.IsLower(x));
            var Digit = password.Count(x => char.IsDigit(x));
            var length = password.Length;


            int count = 0;

            if (uppercase == 0)
            {
                count++;
            }

            if (lowercase == 0)
            {
                count++;

            }

            if (Digit == 0)
            {
                count++;

            }

            if (!match)
            {
                count++;


            }

            if (count + length < 6)
            {
                count = count + 6 - (count + length);


            }

            Console.WriteLine(count);


            //Console.WriteLine(password.Length);
        }
    }
}

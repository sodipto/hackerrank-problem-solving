using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    public class DiagonalDifference
    {
       public  static int diagonalDifference(int[,]arr)
        {
            int LeftD = 0;
            int RightD = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j= 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        LeftD += arr[i,j];
                    }


                    if (i+j== arr.GetLength(0)-1)
                    {
                        RightD += arr[i, j];
                    }

                }

            }

            int result = Math.Abs(LeftD - RightD);

            return result;
        }
    }
}

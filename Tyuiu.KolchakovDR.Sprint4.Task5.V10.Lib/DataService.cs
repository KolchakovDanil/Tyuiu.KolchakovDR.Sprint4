using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KolchakovDR.Sprint4.Task5.V10.Lib
{
    public class DataService : ISprint4Task5V10
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        res += matrix[i, j];
                    }
                }
            }

            return res;
        }
    }
}

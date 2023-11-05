using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KolchakovDR.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            
            int maxval = 0;

            for (int i = 3; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i,j] > maxval)
                    {
                        maxval = array[i, j];
                    }
                }
            }
            return maxval;
        }
    }
}

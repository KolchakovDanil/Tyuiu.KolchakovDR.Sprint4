using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KolchakovDR.Sprint4.Task1.V10.Lib
{
    public class DataService : ISprint4Task1V10
    {
        public int Calculate(int[] array)
        {

            int multiArray = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 1 && array[i] <= 8 && array[i] % 2 != 0)
                    multiArray *= array[i];
            }
            return multiArray;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KolchakovDR.Sprint4.Task2.V23.Lib
{
    public class DataService : ISprint4Task2V23
    {
        public int Calculate(int[] array)
        {
            int multiArray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 3 && array[i] <= 8 && array[i] % 2 == 0)
                    multiArray += array[i];
            }
            return multiArray;
        }
    }
}

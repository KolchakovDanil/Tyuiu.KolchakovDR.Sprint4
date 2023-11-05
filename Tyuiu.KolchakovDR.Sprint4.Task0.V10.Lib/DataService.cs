using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KolchakovDR.Sprint4.Task0.V10.Lib
{
    public class DataService : ISprint4Task0V10
    {
        public int GetSumOddArrEl(int[] array)
        {
            int[] Array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Array[i] % 2 != 0)
                    sum += Array[i];
            }
            return sum;
        }
    }
}

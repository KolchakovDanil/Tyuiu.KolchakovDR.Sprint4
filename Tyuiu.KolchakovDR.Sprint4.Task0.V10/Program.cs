using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint4.Task0.V10.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint4.Task0.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
                4,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Одномерные массивы (статический ввод)",
                0,
                10,
                "Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных элементов массива.  {9, 8, 7, 9, 5, 4, 3, 2, 3, 7}");
            thg.printHeader();

            DataService ds = new DataService();

            int[] Array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

            Console.WriteLine("Исходный масситв: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
            thg.printFooter();
            int array = ds.GetSumOddArrEl(Array);
            Console.WriteLine("Ризультурующий масситв: " + array);
            Console.ReadLine();


        }
    }
}

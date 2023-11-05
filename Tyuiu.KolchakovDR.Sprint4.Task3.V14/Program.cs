using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint4.Task3.V14.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint4.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
        4,
        "Колчаков Д. Р.",
        "ИИПб-23-2",
        "Двумерные массивы. (статический ввод)",
        3,
        14,
        "Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 2 до 7. Найдите максимальный элемент в четвертой строке массива.");
            thg.printHeader();

            Console.WriteLine("Массив: ");
            Console.WriteLine("{3, 2, 3, 3, 5},");
            Console.WriteLine("{2, 3, 3, 7, 3},");
            Console.WriteLine("{7, 5, 2, 7, 3},");
            Console.WriteLine("{4, 2, 7, 5, 2},");
            Console.WriteLine("{3, 5, 4, 2, 6}.");
            Console.WriteLine();

            DataService ds = new DataService();

            int[,] array = new int[5, 5]
            {
                {3, 2, 3, 3, 5},
                {2, 3, 3, 7, 3},
                {7, 5, 2, 7, 3},
                {4, 2, 7, 5, 2},
                {3, 5, 4, 2, 6}
            };

            thg.printFooter();
            int res = ds.Calculate(array);
            Console.WriteLine("Максимальный элемент в четвертой строке массива: " + res);

            Console.ReadLine();
        }
    }
}

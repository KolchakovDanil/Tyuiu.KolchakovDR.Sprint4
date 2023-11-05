using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint4.Task1.V10.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint4.Task1.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
                    4,
                    "Колчаков Д. Р.",
                    "ИИПб-23-2",
                    "Одномерные массивы. (ввод с клавиатуры)",
                    1,
                    10,
                    "Дан одномерный целочисленный массив на 11 элементов заполненный значениями с клавиатуры в диапазоне от 1 до 8 подсчитать произведение нечетных элементов массива.  С клавиатуры: 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5");
            thg.printHeader();

            DataService ds = new DataService();

            int len = 11;

            Console.WriteLine("Количество элементов массива: " + len);
            

            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите значение " + i + " элеменета массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            thg.printFooter();

            int res = ds.Calculate(array);
            Console.WriteLine("Ответ: " + res);
            Console.ReadLine();
        }
    }
}

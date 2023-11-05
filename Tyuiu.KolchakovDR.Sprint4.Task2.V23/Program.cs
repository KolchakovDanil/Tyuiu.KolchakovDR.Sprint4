using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint4.Task2.V23.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint4.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
        4,
        "Колчаков Д. Р.",
        "ИИПб-23-2",
        "Одномерные массивы. (генератор случайных чисел)",
        2,
        23,
        "Дан одномерный целочисленный массив на 15 элементов заполненный случайными в диапазоне от 3 до 8 подсчитать сумму четных элементов массива.");
            thg.printHeader();

            DataService ds = new DataService();
            Random rnd = new Random();
            
            int len = 15;
            Console.WriteLine("Количество элементов массива: " + len);


            int[] array = new int[len];
            for (int i = 0; i <= len-1; i++)
            {
                array[i] = rnd.Next(3, 8);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            thg.printFooter();

            int res = ds.Calculate(array);
            Console.WriteLine("Cумма четных элементов массива = " + res);
            Console.ReadLine();
        }
    }
}

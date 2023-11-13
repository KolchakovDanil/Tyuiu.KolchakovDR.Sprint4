using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint4.Task6.V5.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint4.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            TaskHG thg = new TaskHG(
            4,
            "Колчаков Д. Р.",
            "ИИПб-23-2",
            "Класс Array",
            6,
            5,
            "Написать программу, которая считает количество элементов массива, длина которых равна 8.");
            thg.printHeader();

            var planet = new string[] {"Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун"};
            
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= planet.Length - 1; i++)
            {
                Console.WriteLine(planet[i]);
            }
            thg.printFooter();

            int res = ds.Calculate(planet);
            Console.WriteLine("Количество элементов, длина которых равна 8: " + res);
            Console.ReadKey();
        }
    }
}

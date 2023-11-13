using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KolchakovDR.Sprint4.Task6.V5.Lib
{
    public class DataService : ISprint4Task6V5
    {
        public int Calculate(string[] array)
        {
            string[] planet = Array.FindAll(array, x => x.Length == 8);
            return planet.Length;
        }
    }
}

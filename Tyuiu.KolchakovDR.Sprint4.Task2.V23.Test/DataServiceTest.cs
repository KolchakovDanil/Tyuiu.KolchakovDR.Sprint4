using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint4.Task2.V23.Lib;

namespace Tyuiu.KolchakovDR.Sprint4.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5, 1, 2, 3, 4 }; // 6+8+4+4+4=26
            int res = ds.Calculate(array);
            int Waitarray = 26;
            Assert.AreEqual(Waitarray, res);
        }
    }
}

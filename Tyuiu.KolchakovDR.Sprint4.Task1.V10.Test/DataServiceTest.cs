using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint4.Task1.V10.Lib;

namespace Tyuiu.KolchakovDR.Sprint4.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5 };
            int res = ds.Calculate(array);
            int Waitarray = 1125;
            Assert.AreEqual(Waitarray, res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint4.Task7.V3.Lib;

namespace Tyuiu.KolchakovDR.Sprint4.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];
            string str = "27182818";

            int res = ds.Calculate(n, m, str);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}

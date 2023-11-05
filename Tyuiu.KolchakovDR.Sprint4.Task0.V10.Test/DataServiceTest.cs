using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint4.Task0.V10.Lib;

namespace Tyuiu.KolchakovDR.Sprint4.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int res = ds.GetSumOddArrEl(array);
            int Waitarray = 43;
            Assert.AreEqual(Waitarray, res);

        }
    }
}

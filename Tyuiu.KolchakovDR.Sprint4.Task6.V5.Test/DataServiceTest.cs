using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint4.Task6.V5.Lib;

namespace Tyuiu.KolchakovDR.Sprint4.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var planet = new string[] { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };
            int res = ds.Calculate(planet);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint6.Task0.V20.Lib;

namespace Tyuiu.ShunanovKE.Sprint6.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            double res = ds.Calculate(x);
            double wait = 4;
            Assert.AreEqual(res, wait);
        }
    }
}

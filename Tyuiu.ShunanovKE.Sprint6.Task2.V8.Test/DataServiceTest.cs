using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint6.Task2.V8.Lib;

namespace Tyuiu.ShunanovKE.Sprint6.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 1, end = 3;
            double[] res = ds.GetMassFunction(start, end);
            double[] wait = { 1.82, 3.55, 6.99 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}

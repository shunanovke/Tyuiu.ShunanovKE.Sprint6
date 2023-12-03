using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint6.Task1.V10.Lib;

namespace Tyuiu.ShunanovKE.Sprint6.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 1, stop = 3;
            double[] res = ds.GetMassFunction(start, stop);
            double[] wait = { -0.75, 4.55, 12.23 };
            CollectionAssert.AreEqual(wait,res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint6.Task3.V28.Lib;

namespace Tyuiu.ShunanovKE.Sprint6.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtrx = { { 1, 2, 3, 4, 5 },
                            { 1, 2, 3, 4, 5 },
                            { 1, 2, 3, 4, 5 },
                            { 1, 2, 10, 4, 5 },
                            { 1, 2, 3, 4, 5 }};
            int[,] wait = { { 1, 2, 3, 4, 5 },
                            { 1, 2, 3, 4, 5 },
                            { 1, 2, 3, 4, 5 },
                            { 1, 0, 0, 0, 5 },
                            { 1, 2, 3, 4, 5 }};
            CollectionAssert.AreEqual(wait, ds.Calculate(mtrx));
        }
    }
}

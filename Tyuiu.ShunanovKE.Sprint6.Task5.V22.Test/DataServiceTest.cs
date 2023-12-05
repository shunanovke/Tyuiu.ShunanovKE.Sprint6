using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint6.Task5.V22.Lib;
using System.IO;

namespace Tyuiu.ShunanovKE.Sprint6.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V22.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = {12, 12.89, 35, 13.83, 12.76, 8.86 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

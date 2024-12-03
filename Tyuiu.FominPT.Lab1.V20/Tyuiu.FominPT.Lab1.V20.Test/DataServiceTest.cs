using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FominPT.Lab1.V20.Lib;


namespace Tyuiu.FominPT.Lab1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethodCalculateFirst()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double a = 1;
            double wait = 18.692;
            var res = ds.CalculateFirst(x, y, a);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethodCalculateSecond()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double a = 1;
            double wait = 22.578;
            var res = ds.CalculateSecond(x, y, a);
            Assert.AreEqual(wait, res);
        }
    }
}

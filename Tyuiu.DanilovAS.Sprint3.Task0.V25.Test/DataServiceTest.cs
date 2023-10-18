using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint3.Task0.V25.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startvalue = 1;
            int stopvalue = 14;
            int value = 5;

            double wait = 0.69;
            double res = ds.GetSumSeries(value,startvalue,stopvalue);
            Assert.AreEqual(wait, res);

        }
    }
}

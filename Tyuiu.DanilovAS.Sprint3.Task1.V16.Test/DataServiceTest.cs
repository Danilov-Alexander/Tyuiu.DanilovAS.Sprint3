using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint3.Task1.V16.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataSerivce ds = new DataSerivce();
            double value = 0.7;
            int startvalue = 1;
            int stopvalue = 15;
            double wait = 15.63;
            double res = ds.GetSumSeries(value, startvalue, stopvalue);

            Assert.AreEqual(wait, res);

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint3.Task3.V25.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();
            string value = ": kjhgfuu gujut dtuu";
            char ch = 'u';
            int res = ds.GetMinCharCount(value, ch);
            int wait = 2;

            Assert.AreEqual(wait, res);



        }
    }
}

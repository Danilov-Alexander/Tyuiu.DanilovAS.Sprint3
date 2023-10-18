using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DanilovAS.Sprint3.Task1.V16.Lib
{
    public class DataSerivce : ISprint3Task1V16
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumseries = 1;
            while (startValue < stopValue)
            {
                sumseries += (Math.Pow(value, 2) * Math.Sin(startValue) + 1);
                startValue++;
            }
            return Math.Round(sumseries,3);
        }
    }
}

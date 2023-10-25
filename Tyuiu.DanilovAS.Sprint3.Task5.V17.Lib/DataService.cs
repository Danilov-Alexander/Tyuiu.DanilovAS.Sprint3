using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DanilovAS.Sprint3.Task5.V17.Lib
{
    public class DataService: ISprint3Task5V17
    {
        // Math.Sin(k) + Math.Pow(x,2);
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumseries = 0;
            int i, k;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sumseries += Math.Sin(k) + Math.Pow(x, 2);
                }
            }
                

            return Math.Round(sumseries,3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DanilovAS.Sprint3.Task4.V15.Lib
{
    public class DataService : ISprint3Task4V15
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double sp = 1;

            for (x = -5; x <= 5; x++)
            {
                if (x == 0)
                {
                    continue;
                }


                sp *= (((Math.Sin(x) + x) / x) + 0.75);

            }
            return Math.Round(sp,3);
        }
    }
}

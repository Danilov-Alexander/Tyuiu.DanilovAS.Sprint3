﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DanilovAS.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumseries = 0;
            int i;

            for (i = startValue; i <= stopValue; i++)
            {
                sumseries += Math.Pow(4 / (1 + Math.Pow(value, i)), i);
            }

            return Math.Round(sumseries,3);
        }
    }
}

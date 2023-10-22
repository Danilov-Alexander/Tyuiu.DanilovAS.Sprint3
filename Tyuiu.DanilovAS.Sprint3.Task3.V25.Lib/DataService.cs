using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DanilovAS.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            // u = char(item) value - строка

            int temp = 0;
            int count = 0;

            foreach(char ch in value)
            {
                if (ch == 'u')
                {  
                    count++;
                }

                else
                {
                    count = 0;
                }

                if (count == 2)
                {
                    temp++;
                }
            } 

            return temp;
        }
    }
}

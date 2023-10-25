using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DanilovAS.Sprint3.Task5.V17.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task5.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Данилов А. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Вложенные циклы                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Создание программы с вложенным циклом для решения формулы                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            Console.WriteLine("X ={0}", x);
            Console.WriteLine("Стартовое значение №1 = {0}",startValue1);
            Console.WriteLine("Завершающее значение №1 = {0}", stopValue1);
            Console.WriteLine("Стартовое значение №2 = {0}", startValue2);
            Console.WriteLine("Завершающее значение №2 = {0}", stopValue2);


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine("Ответ: {0}",res);
            Console.ReadKey();
        }
    }
}

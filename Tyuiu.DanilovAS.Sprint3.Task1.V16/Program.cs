using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DanilovAS.Sprint3.Task1.V16.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSerivce ds = new DataSerivce();


            Console.Title = "Спринт #3 | Выполнил: Данилов А. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет              *");
            Console.WriteLine("* сумму ряда по формуле, при х=0,7                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.7;
            Console.WriteLine("Переменная X = " + value);

            int startvalue = 1;
            Console.WriteLine("Стартовое значение = " + startvalue);

            int stopvalue = 15;
            Console.WriteLine("Завершающее значение = " + stopvalue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSeries(value,startvalue,stopvalue);
            Console.WriteLine("Ответ: " + res);
            Console.ReadKey();
        }
    }
}

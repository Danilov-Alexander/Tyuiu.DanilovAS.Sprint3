using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DanilovAS.Sprint3.Task7.V25.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Данилов А. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("*(произвести табулирование) f(x) на заданном диапазоне [5,5] с шагом 1    *");
            Console.WriteLine("* Произвести проверку деления на ноль. При нём вернуть значении 0         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = {0}", startValue);
            Console.WriteLine("Конец шага = {0}", stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|    X    |   f(x)  |");
            Console.WriteLine("+---------+---------+");

            for(int i =0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}    |  {1, 5:f2}  |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+---------+---------+");
            Console.ReadKey();
        }
    }
}

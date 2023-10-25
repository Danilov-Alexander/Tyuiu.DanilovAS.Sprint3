using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DanilovAS.Sprint3.Task4.V15.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Данилов А. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от - 5 до 5, вычислить значение    *");
            Console.WriteLine("* функции y = ((sin(x) + x) / x) + 0.75                                   *");
            Console.WriteLine("* При х = 0 пропустить значение Полученные значения перемножать.          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Стартовое значение = {0}",startValue);
            Console.WriteLine("Завершающее значение = {0}", stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("Ответ: {0}", res);
            Console.ReadKey();

        }
    }
}

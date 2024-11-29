using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FominPT.Lab1.V20.Lib;


namespace Tyuiu.FominPT.Lab1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Лабораторная #1 | Выполнил: Фомин П. Т. | МКМб-22-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная #1                                                         *");
            Console.WriteLine("* Тема: Расчёты арифметических выражений в C#                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Фомин Пётр Тарасович | МКМб-22-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу по методологии TDD на С#, которая запрашивает        *");
            Console.WriteLine("* данные с клавиатуры и вычисляет арифметическое выражение по  вариантам  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                   2y + x - 3a       3((2 + a) / 3y) + a / y             *");
            Console.WriteLine("*        z = 8a + --------------- + ---------------------------           *");
            Console.WriteLine("*                     ax - 8y          (3 - a) / (x + y^3)                *");
            Console.WriteLine("***************************************************************************");

            double x, y, a;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y, a));
            Console.ReadKey();
        }
    }
}

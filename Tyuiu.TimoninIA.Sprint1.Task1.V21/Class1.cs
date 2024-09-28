﻿using Tyuiu.TimoninIA.Sprint1.Task1.V21.Lib;
namespace Tyuiu.TimoninIA.Sprint1.Task1.V21;
        
// Написать программу, которая вычисляет выражение (x*y)/(3+y) и печатает результат на экране.
    
        class Program
        {
            static void Main(string[] args)
            {
                DataService ds = new DataService();
                Console.Title = "Спринт #1 | Выполнил: Тимонин И. А. | ИИПБ-24-1";
                //Длинна строки 75 символов
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #1                                                               *");
                Console.WriteLine("* Тема: Базовые навыки работы по С#                                       *");
                Console.WriteLine("* Задание #1                                                              *");
                Console.WriteLine("* Вариант #21                                                             *");
                Console.WriteLine("* Выполнил: Тимонин Иван Александрович | ИИПБ-24-1                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Написать консольную программу которая вычисляет выражение (x*y)/(3+y)   *");
                Console.WriteLine("* и печатает результат на экране                                          *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");
                double x, y;
                Console.WriteLine("Введите значение x");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение y");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("РЕЗУЛЬТАТ                                                                 *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine(ds.Calculate(x,y));
                Console.ReadLine();
            }
        }



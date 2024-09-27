using Tyuiu.TimoninIA.Sprint1.Task0.V29.Lib;
// Написать программу, которая вычисляет выражение 2 * 9 + 7 * 2 и печатает результат на экране.
namespace Tyuiu.TimoninIA.Sprint1.Task0.V29
{
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Тимонин Иван Александрович | ИИПБ-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу которая вычисляет выражение 2 * 9 + 7 * 2 *");
            Console.WriteLine("* и печатает результат на экране                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            //Метод Calculate находится в библиотеке Tyuiu.TimoninIA.Sprint1.Task0.V29.Lib
            //в классе DataService
            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
using System;
using Tyuiu.GalimovAA.Sprint5.Task1.V2.Lib;

namespace Tyuiu.GalimovAA.Sprint5.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Галимов А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x) = (2x-3)/(cos(x)-2x) + 5x - 6. Произвести            *");
            Console.WriteLine("* табулирование f(x) на диапазоне [-5; 5] с шагом 1. При делении на ноль *");
            Console.WriteLine("* вернуть значение 0. Результат сохранить в файл и вывести в таблицу.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");
            Console.WriteLine($"Шаг = 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("╔════════╦════════════╗");
            Console.WriteLine("║   X    ║    f(x)    ║");
            Console.WriteLine("╠════════╬════════════╣");

            for (int x = startValue; x <= stopValue; x++)
            {
                double result = CalculateFunction(x);
                Console.WriteLine($"║ {x,6} ║ {result,10:F2} ║");
            }

            Console.WriteLine("╚════════╩════════════╝");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine($"Файл результатов сохранен: {res}");

            Console.ReadKey();
        }

        private static double CalculateFunction(int x)
        {
            try
            {
                double denominator = Math.Cos(x) - 2 * x;

                if (Math.Abs(denominator) < double.Epsilon)
                {
                    return 0;
                }

                double numerator = 2 * x - 3;
                double fraction = numerator / denominator;
                return fraction + 5 * x - 6;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }
    }
}
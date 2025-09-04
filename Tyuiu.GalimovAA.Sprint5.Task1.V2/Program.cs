using System;
using System.IO;
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
            Console.WriteLine("* табулирование f(x) на диапазоне [-5; 5] с шагом 1. Произвести проверку  *");
            Console.WriteLine("* деления на ноль. При делении на ноль вернуть значение 0. Результат      *");
            Console.WriteLine("* сохранить в файл OutPutFileTask1.txt и вывести на консоль в таблицу.    *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");
            Console.WriteLine("Шаг = 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            // Читаем файл и выводим значения в таблицу
            string[] lines = File.ReadAllLines(path);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i < lines.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine($"| {x,8} | {lines[i].Replace(".", ","),8} |");
            }

            Console.WriteLine("+----------+----------+");
            Console.WriteLine();
            Console.WriteLine($"Файл сохранен: {path}");

            // Выводим содержимое файла как есть (для проверки)
            Console.WriteLine("\nСодержимое файла:");
            Console.WriteLine(File.ReadAllText(path).Replace(".", ","));

            Console.ReadKey();
        }
    }
}
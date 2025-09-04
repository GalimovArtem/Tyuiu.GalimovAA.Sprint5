using System;
using Tyuiu.GalimovAA.Sprint5.Task7.V19.Lib;

namespace Tyuiu.GalimovAA.Sprint5.Task7.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Галимов А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных.                        *");
            Console.WriteLine("* Удалить все удвоенные буквы \"cc\" из файла.                             *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V19.txt.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V19.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат находится в файле: " + res);
            Console.ReadKey();
        }
    }
}
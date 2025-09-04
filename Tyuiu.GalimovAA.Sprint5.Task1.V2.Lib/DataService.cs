using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalimovAA.Sprint5.Task1.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Артём Азатович Галимов, ПКТб-24-1");
                writer.WriteLine("╔════════╦════════════╗");
                writer.WriteLine("║   X    ║    f(x)    ║");
                writer.WriteLine("╠════════╬════════════╣");

                for (int x = startValue; x <= stopValue; x++)
                {
                    double result = CalculateFunction(x);
                    writer.WriteLine($"║ {x,6} ║ {result,10:F2} ║");
                }

                writer.WriteLine("╚════════╩════════════╝");
            }

            return path;
        }

        private double CalculateFunction(int x)
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
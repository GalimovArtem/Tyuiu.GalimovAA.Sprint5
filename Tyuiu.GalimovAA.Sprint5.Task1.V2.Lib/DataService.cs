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
                writer.WriteLine("x\tf(x)");

                for (int x = startValue; x <= stopValue; x++)
                {
                    try
                    {
                        double denominator = Math.Cos(x) - 2 * x;

                        if (Math.Abs(denominator) < 0.0001)
                        {
                            writer.WriteLine($"{x}\t0");
                        }
                        else
                        {
                            double numerator = 2 * x - 3;
                            double result = numerator / denominator + 5 * x - 6;
                            string formattedResult = FormatResult(result);
                            writer.WriteLine($"{x}\t{formattedResult}");
                        }
                    }
                    catch
                    {
                        writer.WriteLine($"{x}\t0");
                    }
                }
            }

            return path;
        }

        private string FormatResult(double value)
        {
            string result = Math.Round(value, 2).ToString("0.##");
            return result == "-0" ? "0" : result;
        }
    }
}
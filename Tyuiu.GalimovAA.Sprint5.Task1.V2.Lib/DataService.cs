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
                for (int x = startValue; x <= stopValue; x++)
                {
                    double result = CalculateFunction(x);
                    string formattedResult = FormatResult(result);
                    writer.WriteLine(formattedResult);
                }
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

        private string FormatResult(double result)
        {
            string formatted = result.ToString("F2");
            if (formatted.EndsWith(",00"))
            {
                formatted = formatted.Substring(0, formatted.Length - 3);
            }
            else if (formatted.EndsWith(",0"))
            {
                formatted = formatted.Substring(0, formatted.Length - 2);
            }

            return formatted;
        }
    }
}
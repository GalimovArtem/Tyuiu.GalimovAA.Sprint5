using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalimovAA.Sprint5.Task1.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            StringBuilder resultBuilder = new StringBuilder();

            for (int x = startValue; x <= stopValue; x++)
            {
                try
                {
                    double denominator = Math.Cos(x) - 2 * x;

                    if (Math.Abs(denominator) < 0.0001)
                    {
                        resultBuilder.Append("0");
                    }
                    else
                    {
                        double numerator = 2 * x - 3;
                        double result = numerator / denominator + 5 * x - 6;
                        string formattedResult = FormatResult(result);
                        resultBuilder.Append(formattedResult);
                    }
                }
                catch
                {
                    resultBuilder.Append("0");
                }

                if (x < stopValue)
                {
                    resultBuilder.Append("\n");
                }
            }

            File.WriteAllText(path, resultBuilder.ToString());
            return path;
        }

        private string FormatResult(double value)
        {
         
            double roundedValue = Math.Round(value, 2);

           
            if (roundedValue % 1 == 0)
            {
                return ((int)roundedValue).ToString();
            }

         
            string result = roundedValue.ToString("0.##");
            return result.Replace(",", ".");
        }
    }
}
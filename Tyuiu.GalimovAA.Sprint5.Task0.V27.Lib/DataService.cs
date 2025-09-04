using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalimovAA.Sprint5.Task0.V27.Lib
{
    public class DataService : ISprint5Task0V27
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Pow(x - 1, 3 * x + 1);
            string roundedY = y.ToString("F3", CultureInfo.InvariantCulture);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(roundedY);
            }

            return path;
        }
    }
}
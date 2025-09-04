using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalimovAA.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX, CultureInfo.InvariantCulture);
            double y = Math.Pow(x, 3) + 1.2 * Math.Pow(x, 2) + 2;
            return Math.Round(y, 3);
        }
    }
}
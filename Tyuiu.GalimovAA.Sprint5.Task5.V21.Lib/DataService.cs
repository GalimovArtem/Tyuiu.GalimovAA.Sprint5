using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalimovAA.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int maxEvenInt = -1;

            foreach (string line in lines)
            {
                string[] values = line.Split(' ');

                foreach (string value in values)
                {
                    if (double.TryParse(value, out double number))
                    {
                        if (number == Math.Floor(number) && (int)number % 2 == 0)
                        {
                            int intValue = (int)number;
                            if (intValue > maxEvenInt)
                            {
                                maxEvenInt = intValue;
                            }
                        }
                    }
                }
            }

            if (maxEvenInt == -1)
            {
                return 0;
            }

            long factorial = 1;
            for (int i = 1; i <= maxEvenInt; i++)
            {
                factorial *= i;
            }

            return Math.Round((double)factorial, 3);
        }
    }
}
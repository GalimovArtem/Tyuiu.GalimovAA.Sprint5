using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalimovAA.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            double maxEvenInteger = 0;
            bool foundEvenInteger = false;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line.Trim(), out double number))
                    {
                        if (number == Math.Floor(number) && number % 2 == 0 && number > 0)
                        {
                            int integerValue = (int)number;
                            if (integerValue > maxEvenInteger)
                            {
                                maxEvenInteger = integerValue;
                                foundEvenInteger = true;
                            }
                        }
                    }
                }
            }

            if (!foundEvenInteger)
            {
                return 1;
            }

            long factorial = 1;
            for (int i = 1; i <= (int)maxEvenInteger; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
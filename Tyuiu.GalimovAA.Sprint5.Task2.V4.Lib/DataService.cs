using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalimovAA.Sprint5.Task2.V4.Lib
{
    public class DataService : ISprint5Task2V4
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            string result = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int value = matrix[i, j] > 0 ? 1 : 0;
                    result += value;

                    if (j < columns - 1)
                    {
                        result += ";";
                    }
                }

                if (i < rows - 1)
                {
                    result += Environment.NewLine;
                }
            }

            File.WriteAllText(path, result);
            return path;
        }
    }
}
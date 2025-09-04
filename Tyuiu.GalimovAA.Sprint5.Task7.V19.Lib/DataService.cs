using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalimovAA.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string tempFile = Path.GetTempFileName();
            string data = File.ReadAllText(path, Encoding.Default);
            string result = RemoveAllOccurrences(data, "сс");
            File.WriteAllText(tempFile, result, Encoding.Default);
            return tempFile;
        }
        private string RemoveAllOccurrences(string input, string pattern)
        {
            int index;
            while ((index = input.IndexOf(pattern, StringComparison.OrdinalIgnoreCase)) >= 0)
            {
                input = input.Remove(index, pattern.Length);
            }
            return input;
        }
    }
}
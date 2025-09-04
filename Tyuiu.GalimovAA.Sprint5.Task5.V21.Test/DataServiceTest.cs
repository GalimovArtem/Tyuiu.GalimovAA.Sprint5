using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint5.Task5.V21.Lib;
using System.IO;

namespace Tyuiu.GalimovAA.Sprint5.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V21.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);
            double wait = 120; 
            Assert.AreEqual(wait, result);
        }
    }
}
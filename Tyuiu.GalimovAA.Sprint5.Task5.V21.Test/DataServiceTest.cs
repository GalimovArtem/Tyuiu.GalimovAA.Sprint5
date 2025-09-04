using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GalimovAA.Sprint5.Task5.V21.Lib;

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
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            double waitResult = 120;
            Assert.AreEqual(waitResult, result);
        }
    }
}
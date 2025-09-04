using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Tyuiu.GalimovAA.Sprint5.Task6.V26.Lib;

namespace Tyuiu.GalimovAA.Sprint5.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            int count = ds.LoadFromDataFile(path);

            int waitCount = 4;
            Assert.AreEqual(waitCount, count);
        }
    }
}
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint5.Task4.V10.Lib;

namespace Tyuiu.GalimovAA.Sprint5.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

            DataService ds = new DataService();
            double wait = 10.368;
            double result = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, result);
        }
    }
}
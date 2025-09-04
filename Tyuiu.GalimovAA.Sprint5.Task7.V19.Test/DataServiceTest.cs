using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GalimovAA.Sprint5.Task7.V19.Lib;

namespace Tyuiu.GalimovAA.Sprint5.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V19.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            string tempFile = ds.LoadDataAndSave(path);

            string resultData = File.ReadAllText(tempFile);

            Assert.IsFalse(resultData.Contains("cc"));
        }
    }
}
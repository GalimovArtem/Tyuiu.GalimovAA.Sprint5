using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GalimovAA.Sprint5.Task0.V27.Lib;

namespace Tyuiu.GalimovAA.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }

        [TestMethod]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            string content = File.ReadAllText(path);
            string expected = "1024.000";

            Assert.AreEqual(expected, content);
        }
    }
}
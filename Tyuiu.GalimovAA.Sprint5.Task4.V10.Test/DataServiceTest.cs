using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.GalimovAA.Sprint5.Task4.V10.Lib;

namespace Tyuiu.GalimovAA.Sprint5.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\DataSprints\InPutDataFileTask4V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);

            DataService ds = new DataService();
            double wait = 12.632;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GalimovAA.Sprint5.Task3.V19.Lib;

namespace Tyuiu.GalimovAA.Sprint5.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            DataService ds = new DataService();
            int x = 3;
            string pathWait = ds.SaveToFileTextData(x);

            double y;
            using (BinaryReader reader = new BinaryReader(File.Open(pathWait, FileMode.Open)))
            {
                y = reader.ReadDouble();
            }

            double wait = (2 * Math.Pow(x, 2) - 1) / Math.Sqrt(Math.Pow(x, 2) - 2);
            wait = Math.Round(wait, 3);

            Assert.AreEqual(wait, y);
            Assert.IsTrue(File.Exists(pathWait));
        }
    }
}
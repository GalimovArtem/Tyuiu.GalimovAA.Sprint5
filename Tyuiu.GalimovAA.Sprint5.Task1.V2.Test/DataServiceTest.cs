using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GalimovAA.Sprint5.Task1.V2.Lib;

namespace Tyuiu.GalimovAA.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\artem\source\repos\Tyuiu.GalimovAA.Sprint5\Tyuiu.GalimovAA.Sprint5.Task1.V2\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
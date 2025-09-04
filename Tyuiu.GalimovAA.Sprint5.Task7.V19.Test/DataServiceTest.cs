using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using Tyuiu.GalimovAA.Sprint5.Task7.V19.Lib;
namespace Tyuiu.GalimovAA.Sprint5.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }

        [TestMethod]
        public void ValidRemoveDoubleC()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V19.txt";

            string testContent = "Test string with ccc double cc letters ccc";
            File.WriteAllText(path, testContent, Encoding.Default);

            DataService ds = new DataService();
            string resultPath = ds.LoadDataAndSave(path);

            string resultContent = File.ReadAllText(resultPath, Encoding.Default);
            string expected = "Test string with cc double c letters cc";

            Assert.AreEqual(expected, resultContent);
        }
    }
}
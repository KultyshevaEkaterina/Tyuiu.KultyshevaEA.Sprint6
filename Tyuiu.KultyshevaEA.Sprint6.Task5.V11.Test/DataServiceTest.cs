using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KultyshevaEA.Sprint6.Task5.V11.Lib;

using System.IO;

namespace Tyuiu.KultyshevaEA.Sprint6.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V11.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}

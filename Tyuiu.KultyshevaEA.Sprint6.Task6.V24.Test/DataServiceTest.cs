using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KultyshevaEA.Sprint6.Task6.V24.Lib;

namespace Tyuiu.KultyshevaEA.Sprint6.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V24.txt";
            DataService ds = new DataService();
            string wait = "EovFJVudRgdWKwQBrOMEwyq";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(res, wait);
        }
    }
}

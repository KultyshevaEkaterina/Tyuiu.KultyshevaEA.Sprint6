using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint6.Task3.V12.Lib;

namespace Tyuiu.KultyshevaEA.Sprint6.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {
            { -6, -13, -1, -7, 10 },
            { 14, -18, 18, 1, 11 },
            { -2, -17, -15, -10, -8 },
            { 19, -4, -6, -11, 8 },
            { -17, 17, 14, 13, 19 }
        };

            int[,] wait = new int[5, 5] {
            { 0, -13, -1, -7, 0 },
            { 14, -18, 18, 1, 11 },
            { -2, -17, -15, -10, -8 },
            { 19, -4, -6, -11, 8 },
            { -17, 17, 14, 13, 19 }
        };

            int[,] result = ds.Calculate(mas2);

            CollectionAssert.AreEqual(wait, result);
        }
    }
}

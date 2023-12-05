using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint6.Task4.V7.Lib;

namespace Tyuiu.KultyshevaEA.Sprint6.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            CollectionAssert.AreEqual(new double[] { 15.19,11.67,9,0,4.08,1.5,-2.28,-6.52,-10.19,-12.76,-14.68 }, ds.GetMassFunction(-5, 5));
        }
    }
}

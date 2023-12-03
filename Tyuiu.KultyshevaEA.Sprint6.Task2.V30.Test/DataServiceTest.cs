using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint6.Task2.V30.Lib;

namespace Tyuiu.KultyshevaEA.Sprint6.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            CollectionAssert.AreEqual(new double[] { -15.40,-13.31,-11.36,-8.00,-2.62,1.83,4.49,6.78,10.58,17.38,23.76 }, ds.GetMassFunction(-5, 5));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using sum;
namespace UnitTestCalic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Double a = 10;
            Double b = 20;
            Double result = Calic.addition(a, b);
        }
        [TestMethod]
        public void Testadditionarr()
        {
            Double[] arr = new Double[5] { 1, 2, 2, 4, 5 };
            Double result = Calic.addition(arr);
        }
        [TestMethod]
        public void Testsubstractiondoublenumbers()
        {
            Double a = 10;
            Double b = 20;
            Double result = Calic.addition(a, b);
        }
        [TestMethod]
        public void Testsubstractionarr()
        {
            Double[] arr = new Double[5] { 1, 2, 2, 4, 5 };
            Double result = Calic.addition(arr);
        }
        [TestMethod]
        public void Testmultiplicationarr()
        {
            Double[] arr = new Double[5] { 1, 2, 2, 4, 5 };
            Double result = Calic.addition(arr);
        }
        [TestMethod]
        public void Testdivisionofdoublenumbers()
            {
                Double a = 10;
                Double b = 20;
                Double result = Calic.addition(a, b);
            }
        [TestMethod]
        public void Testsubstractionarrdiifnumbers()
        {
            Double[] arr = new Double[4] { -2.2, 5.5, -8.2, 61.5 };
            Double result = Calic.addition(arr);
        }
        [TestMethod]
        public void Testsubstractionarrdiifintegers()
        {
            Double[] arr = new Double[4] { -2.2, -(-5.5), -8.2, 61.5 };
            Double result = Calic.addition(arr);
        }
    }

}

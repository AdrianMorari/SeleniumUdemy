using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_9
{
    [TestClass]
    public class MathFunctionsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, MathFunctions.Square_Root(12), 1);
        }

        [TestMethod]
        public void Test_Int_Sum()
        {
            Assert.AreEqual(18, MathFunctions.Sum(12, 6));
        }

        [TestMethod]
        public void Test_Double_Sum()
        {
            Assert.AreEqual(20.1, MathFunctions.Sum(12.6, 7.5));
        }

        [TestMethod]
        public void Test_Decimal_Sum()
        {
            Assert.AreEqual(29.1M, MathFunctions.Sum(22.2M, 6.9M));
        }
    }
}

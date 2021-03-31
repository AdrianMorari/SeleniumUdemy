using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("LoginFeature")]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Positive")]
        [Description("demo unit tests")]
        public void TestMethod1()
        {
            var a = 1;
            var b = 2;
            Assert.AreEqual(3, a + b);
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod2()
        {
            var a = 1;
            Assert.AreNotEqual(2, 1);
        }
    }
}

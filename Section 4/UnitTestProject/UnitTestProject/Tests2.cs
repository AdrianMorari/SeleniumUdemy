using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Quiz")]
    public class Tests2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(2, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("This test will always fail");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            var a = 10;
            var b = 10;
            Assert.AreEqual(21, a + b);
        }
    }
}

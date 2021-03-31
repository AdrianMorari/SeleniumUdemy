using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class Test3
    {
        private int a;
        public TestContext Test3Context { get; set; }
        private static TestContext _testContext;
        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            a = 1;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var b = 2;
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            Assert.AreNotEqual(1, a);
        }

        [ClassInitialize]
        public static void RunBeforeAllOfTheTestMethodsStarted(TestContext testContext)
        {
            _testContext = testContext;
            Trace.Write("I will run one time before all the tests in the class started");
        }

        [ClassCleanup]
        public static void RunAfterEveryTestClass()
        {
            Trace.Write("I will run one time before all the tests in the class finished");
        }

        [TestCleanup]
        public void RunAfterEveryTestMethod()
        {
            Trace.Write("RunAfterEveryTestMethod will execute after every single test method in a class");
        }
    }
}

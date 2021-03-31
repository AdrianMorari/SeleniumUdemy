using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_7
{
    [TestClass]
    public class DoWhileLoops
    {
        [TestMethod]
        public void Test_Do_While()
        {
            int sum = 0;
            int number = 1;
            do
            {
                sum += number;
                number++;

            }
            while (number <= 10);

            Assert.AreEqual(55, number);
        }
    }
}

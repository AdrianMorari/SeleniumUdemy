using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class FloatingPointOperations
    {
        //variables to hold the two double values
        static double number1;
        static double number2;

        [ClassInitialize()]
        public static void DoubleInitialize(TestContext testContext)
        {
            //set value of the two numbers we'll be using
            number1 = 10.5;
            number2 = 5.0;
        }

        [TestMethod]
        public void Test_Addition()
        {
            double sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(15.5, sum);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            double difference = number1 - number2;
            Assert.AreEqual(5.5, difference);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            double product = number1 * number2;
            Assert.AreEqual(52.5, product);
        }

        [TestMethod]
        public void Test_Division()
        {
            double quotient = number1 / number2;
            Assert.AreEqual(2.1, quotient);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            double remainder = number1 % number2;
            Assert.AreEqual(0.5, remainder);
        }
    }
}

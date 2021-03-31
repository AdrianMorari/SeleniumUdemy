using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class SectionQuiz
    {
        [TestMethod]
        public void Convert_F_To_C()
        {
            double tempInF = 57;
            //To convert temperatures in degrees Fahrenheit to Celsius, subtract 32 and multiply by .5556
            double tempInC = (tempInF - 32) * 0.5556;
            Console.WriteLine($"The temp {tempInF} in F  is {tempInC} in C");

            //57F should be 13.89C
            Assert.AreEqual(tempInC, 13.89, 0.01);
        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            double tempInC = 12.5;
            //To convert temperatures in degrees Celsius to Fahrenheit, multiply by 1.8 (or 9/5) and add 32
            double tempInF = 1.8 * tempInC + 32;
            Console.WriteLine($"The temp {tempInC} in C is {tempInF} in F");

            //12.5 to F should be 54.5
            Assert.AreEqual(tempInF, 54.5);
        }
    }
}

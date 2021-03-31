using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_7
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void Test_While_Loops()
        {
            int number = 1;
            while (number < 11)
            {

            }
        }

        [TestMethod]
        public void Test_Operators()
        {
            int number = 1;
            Console.WriteLine("post increment value is: {0}", number++);

            Console.WriteLine("pre increment value is: {0}", ++number);

            Console.WriteLine("post decrement value is: {0}", number--);

            Console.WriteLine("pre decrement value is: {0}", --number);
        }

        [TestMethod]
        public void String_Sentinel_Controlled_Loop()
        {
            string inValue = "";
            while (inValue != "-99")
            {
                Console.WriteLine("\nEnter value (-99 to exit): ");
                inValue = Console.ReadLine();
            }
            Console.ReadKey();
        }

        [TestMethod]
        public void NestedLoops()
        {
            int number1 = 1;
            int number2 = 1;
            while (number1 <= 5)
            {
                while (number2 <= number1)
                {
                    Console.WriteLine(number2);
                    number2++;
                }//inner loop
            }
            number1++;
        }//outer loop
    }
}

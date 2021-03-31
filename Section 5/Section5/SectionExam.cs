using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class SectionExam
    {

        public string IsLeapYear(int givenYear)
        {
            //vars
            int nYear;
            int nFhun;
            int nHun;
            int nFour;
            int nEven;
            string sFhun;
            string sHun;
            string sFour;

            //what year are we testing?
            nYear = givenYear;

            //checks to see if year leaves a remainder to determine if leap year
            nFour = nYear % 4;
            if (nFour == 0)
            {
                sFour = "Divisible by 4: Yes";
            }
            else
            {
                sFour = "Divisible by 4: No";
            }

            nHun = nYear % 100;
            if (nHun == 0)
            {
                sHun = "Divisible by 100: Yes";
            }
            else
            {
                sHun = "Divisible by 100: No";
            }

            nFhun = nYear % 400;
            if (nFhun == 0)
            {
                sFhun = "Divisible by 400: Yes";
            }
            else
            {
                sFhun = "Divisible by 400: No";
            }

            nEven = nYear % 2;

            //display all operations
            Console.WriteLine("Year entered: " + nYear);
            Console.WriteLine(sFour);
            Console.WriteLine(sHun);
            Console.WriteLine(sFhun);

            //determine if leap year
            if((nEven == 0) && (nFour == 0) && (nHun == 0) && (nFhun == 0))
            {
                Console.WriteLine("Leap year: Yes");
                return "Yes";
            }
            else if((nEven == 0) && (nFour == 0) && (nHun != 0) && (nFhun != 0))
            {
                Console.WriteLine("Leap year: Yes");
                return "Yes";
            }
            else if((nEven == 0) && (nFour == 0) && (nHun == 0) && (nFhun != 0))
            {
                Console.WriteLine("Leap year: No");
                return "No";
            }
            else if((nEven == 0) && (nFour == 0) && (nHun != 0) && (nFhun == 0))
            {
                Console.WriteLine("Leap year: No");
                return "No";
            }
            else if (nEven == 1)
            {
                Console.WriteLine("Leap year: No");
                return "No";
            }
            return "No";
        }

        [TestMethod]
        public void Leap_Year_Test_1234()
        {
            //call the IsLeapYear method to test
            string result = IsLeapYear(1234);
            Assert.AreEqual("No", result);
        }
    }
}

﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace Section14
{
    [TestClass]
    public class QuizTest
    {
        [TestMethod]
        public void TestFirstName()
        {
            string firstname = "Tiffany";
            string pattern = @"^[a-zA-Z]+$";

            bool response = Regex.IsMatch(firstname, pattern);
            if (response)
            {
                Assert.IsTrue(response);
            }
            else
            {
                Console.WriteLine("Validation problem with first name");
            }
        }

        [TestMethod]
        public void TestLastName()
        {
            string lastname = "Smith";
            string pattern = @"^[a-zA-Z]+$";

            bool response = Regex.IsMatch(lastname, pattern);
            if (response)
            {
                Assert.IsTrue(response);
            }
            else
            {
                Console.WriteLine("Validation problem with last name");
            }
        }

        [TestMethod]
        public void TestAge()
        {
            int age = 29;
            string sAge = Convert.ToString(age);
            string pattern = @"^\d+$";
            bool response = Regex.IsMatch(sAge, pattern);
            if (response)
            {
                Assert.IsTrue(response);
            }
            else
            {
                Console.WriteLine("Validation problem with age");
            }
        }

        [TestMethod]
        public void TestDOB()
        {
            int day = 12;
            int month = 8;
            int year = 1992;

            string dob = Convert.ToString(day) + "/" + Convert.ToString(month) + "/" + Convert.ToString(year);
            string pattern = @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$";
            bool response = Regex.IsMatch(dob, pattern);
            if (response)
            {
                Assert.IsTrue(response);
            }
            else
            {
                Console.WriteLine("Validation problem with date of birth");
            }
        }

        [TestMethod]
        public void TestPhone()
        {
            string phone = "(555) - 555 - 5555";
            string pattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            bool response = Regex.IsMatch(phone, pattern);
            if (response)
            {
                Assert.IsTrue(response);
            }
            else
            {
                Console.WriteLine("Validation problem with phone number");
            }
        }
    }
}

﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section7
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Test_Employee_ID_Set()
        {
            Employee employee1 = new Employee(123);

            employee1.JobTitle = "Manager";

            string jobLocation = employee1.JobLocation();
            Assert.AreEqual(jobLocation, "New York");
        }

        [TestMethod]
        public void To_String_Test()
        {
            Employee employee1 = new Employee("Sara Burke", 12345, "Manager");
            Console.WriteLine(employee1);
        }
    }
}

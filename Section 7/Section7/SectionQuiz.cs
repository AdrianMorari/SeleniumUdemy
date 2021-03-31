using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7
{
    [TestClass]
    public class Section7
    {
        [TestMethod]
        public void Employee_Full_Name()
        {
            TestEmployee employee = new TestEmployee("Alena", "Dust");
            string fullname = employee.ReturnFullName();
            Assert.AreEqual("Alena Dust", fullname);
        }
        [TestMethod]
        public void Employee_Full_Name_Sorting()
        {
            TestEmployee employee = new TestEmployee("Alena", "Dust");
            string fullname = employee.ReturnFullNameForSortingPurposes();
            Assert.AreEqual("Dust, Alena", fullname);
        }
    }
    
    public class TestEmployee
    {
        //private variables internal to the class
        private string employeeNumber;
        private string employeeFirstName;
        private string employeeLastName;
        private string department;
        private string jobDescription;
        private string dateOfHire;
        private double salary;

        //constructors
        public TestEmployee(string empFirstName, string empLastName)
        {
            EmployeeFirstName = empFirstName;
            EmployeeLastName = empLastName;
        }

        public TestEmployee(string empNumber, string empFirstName, string empLastName, string department, string jobDesc, string dateOfHire, double salary)
        {
            EmployeeNumber = empNumber;
            EmployeeFirstName = empFirstName;
            EmployeeLastName = empLastName;
            Department = department;
            JobDescription = jobDesc;
            DateOfHire = dateOfHire;
            Salary = salary;
        }

        //properties
        public string EmployeeNumber { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string Department { get; set; }
        public string JobDescription { get; set; }
        public string DateOfHire { get; set; }
        public double Salary { get; set; }

        //methods

        public string ReturnFullName()
        {
            return EmployeeFirstName + " " + EmployeeLastName;
        }
        public string ReturnFullNameForSortingPurposes()
        {
            return EmployeeLastName + ", " + EmployeeFirstName;
        }

    }
}

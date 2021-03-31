using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7
{
    class Employee
    {
        public Employee(int id)
        {
            EmployeeID = id;
        }

        public Employee(string name, int id, string title)
        {
            Name = name;
            EmployeeID = id;
            JobTitle = title;
        }

        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public string JobTitle { get; set; }


        public string JobLocation()
        {
            if(JobTitle == "Manager")
            {
                return "Boston";
            }
            else if(JobTitle == "Staff")
            {
                return "Chicago";
            }
            return "New York";
        }

        public override string ToString()
        {
            return EmployeeID + " " + Name + " " + " Job title: " + JobTitle;
        }
    }
}

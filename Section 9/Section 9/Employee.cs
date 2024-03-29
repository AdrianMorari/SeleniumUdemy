﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9
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
            if (JobTitle == "Manager")
            {
                return "Boston";
            }
            else if (JobTitle == "Staff")
            {
                return "Chicago";
            }
            return "New York";
        }

        public string PayType(string title)
        {
            if (JobTitle == "Manager")
            {
                return "Salary";
            }
            else if (JobTitle == "Staff")
            {
                return "Hourly";
            }
            return "Hourly";
        }

        public string PayType(int id)
        {
            if (EmployeeID == 12345)
            {
                return "Salary";
            }
            else if (EmployeeID == 54321)
            {
                return "Hourly";
            }
            return "Hourly";
        }

        public override string ToString()
        {
            return EmployeeID + " " + Name + " " + " Job title: " + JobTitle;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}

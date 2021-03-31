using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12.Implementing_interfaces
{
    abstract class Person
    {
        private string idNumber;
        private string firstName;
        private string lastName;
        private int age;

        public Person(string id, string fname, string lname)
        {
            idNumber = id;
            firstName = fname;
            lastName = lname;
        }

        public override string ToString()
        {
            return "First Name: " + firstName +
                "\nLast Name: " + lastName;
        }
    }
}

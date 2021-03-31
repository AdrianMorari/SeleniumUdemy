using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11
{
    class Person
    {
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;
        protected DateTime dateOfBirth;

        public Person()
        {

        }

        public Person(string id, string lname, string fname, int anAge, DateTime dob)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
            age = anAge;
            dateOfBirth = dob;
        }

        public Person(string id, string lname, string fname, int anAge)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
            age = anAge;
        }

        public virtual string HoursOfSleep()
        {
            return "A person gets 8 hours of sleep";
        }
    }
}

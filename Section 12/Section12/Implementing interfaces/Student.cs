using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12.Implementing_interfaces
{
    class Student : Person, ITraveler
    {
        private string major;
        private string studentId;

        public Student(string id, string fname, string lname, string maj, string sId)
            : base(id, fname, lname)
        {
            Major = maj;
            StudentId = sId;
        }

        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }
        public string StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }

        public string GetDestination()
        {
            return "Home";
        }

        public string GetStartLocation()
        {
            return "Work";
        }
        public double DetermineMiles()
        {
            return 5.7;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nDestination: " + GetDestination() +
                "\nStart Location: " + GetStartLocation() +
                "\nMiles: " + DetermineMiles();
        }
    }
}

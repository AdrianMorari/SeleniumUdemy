using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12.Implementing_interfaces
{
    class Professor : Person, ITraveler
    {
        private string empId;
        private string subject;

        public Professor(string id, string fname, string lname, string empId, string subject)
            : base(id, fname, lname)
        {
            EmployeeId = empId;
            Subject = subject;
        }

        public string EmployeeId
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
        }
        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public string GetDestination()
        {
            return "The beach";
        }

        public string GetStartLocation()
        {
            return "Home";
        }
        public double DetermineMiles()
        {
            return 12.1;
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

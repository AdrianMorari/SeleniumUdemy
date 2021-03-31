using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11.Exam
{
    class HomeLoan : Loan
    {
        private string address;
        private int yearBuilt;
        private int sqFootage;

        public HomeLoan(string number, string first, string last, double intRate, decimal prinBorrowed, double duration,
            string add, int yrBuilt, int sqFeet)
            : base(number, first, last, intRate, prinBorrowed, duration)
        {
            Address = add;
            YearBuilt = yearBuilt;
            SqFootage = sqFeet;
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public int YearBuilt
        {
            get
            {
                return yearBuilt;
            }
            set
            {
                yearBuilt = value;
            }
        }
        public int SqFootage
        {
            get
            {
                return sqFootage;
            }
            set
            {
                sqFootage = value;
            }
        }

        public override decimal CalculateInterest()
        {
            return (Convert.ToDecimal(InterestRate) / (Convert.ToDecimal(TermYears) / 12M) * (LoanAmount + 5000));
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nHome loan address: " + Address +
                "\nCalculated interest: " + CalculateInterest().ToString("C");
        }
    }
}

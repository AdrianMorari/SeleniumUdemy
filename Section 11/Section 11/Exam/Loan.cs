﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11.Exam
{
    abstract class Loan
    {
        private string LoanNumber;
        private string customerFirst;
        private string customerLast;
        private double interestRate;
        private decimal loanAmount;
        private double termYears;

        public Loan(string number, string first, string last, double rate, decimal amtBorrowed, double time)
        {
            loanNumber = number;
            CustomerFirst = first;
            CustomerLast = last;
            InterestRate = rate;
            LoanAmount = amtBorrowed;
            TermYears = time;
        }

        public string loanNumber
        {
            get
            {
                return LoanNumber;
            }
            set
            {
                LoanNumber = value;
            }
        }
        public string CustomerFirst
        {
            get
            {
                return customerFirst;
            }
            set
            {
                customerFirst = value;
            }
        }
        public string CustomerLast
        {
            get
            {
                return customerLast;
            }
            set
            {
                customerLast = value;
            }
        }
        public double InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }
        public decimal LoanAmount
        {
            get
            {
                return loanAmount;
            }
            set
            {
                loanAmount = value;
            }
        }
        public double TermYears
        {
            get
            {
                return termYears;
            }
            set
            {
                termYears = value;
            }
        }

        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            return "Customer: " + CustomerFirst + " " +
                CustomerLast + 
                "\nLoan amount: " + LoanAmount.ToString("C") +
                "\nInterest rate: " + InterestRate.ToString("p2") +
                "\nLoan duration: " + TermYears;
        }
    }
}

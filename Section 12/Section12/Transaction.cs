﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12
{
    class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double getAmount()
        {
            return amount;
        }

        public override string ToString()
        {
            return string.Format("Transaction: {0}" +
                "\nDate: {1}" +
                "\nAmount: {2}", tCode, date, getAmount());
        }
    }
}

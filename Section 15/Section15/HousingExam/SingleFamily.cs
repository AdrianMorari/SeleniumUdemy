using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15
{
    class SingleFamily : Housing
    {
        private int numberOfBedrooms;
        private int numberOfBathrooms;
        private bool garage;
        private bool porch;
        private decimal rentAmount;
        private double squareFeet;

        public SingleFamily(int yr, string addr, string type, int numBeds, int numBaths, bool grg, bool pch, decimal rentAmt)
            : base(yr, addr, type)
        {
            NumberOfBedrooms = numBeds;
            NumberOfBathrooms = numBaths;
            Garage = grg;
            Porch = pch;
            RentAmount = rentAmt;
        }

        #region Properties
        public int NumberOfBedrooms
        {
            get
            {
                return numberOfBedrooms;
            }
            set
            {
                numberOfBedrooms = value;
            }
        }
        public int NumberOfBathrooms
        {
            get
            {
                return numberOfBathrooms;
            }
            set
            {
                numberOfBathrooms = value;
            }
        }
        public bool Garage
        {
            get
            {
                return garage;
            }
            set
            {
                garage = value;
            }
        }
        public bool Porch
        {
            get
            {
                return porch;
            }
            set
            {
                porch = value;
            }
        }
        public decimal RentAmount
        {
            get
            {
                return rentAmount;
            }
            set
            {
                rentAmount = value;
            }
        }
        public double SquareFeet
        {
            get
            {
                return squareFeet;
            }
            set
            {
                squareFeet = value;
            }
        }
        #endregion

        public override decimal ProjectedRentalAmt()
        {
            return 12M * rentAmount;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nNumber of Bedrooms: " + numberOfBedrooms +
                "\nNumber of Bathrooms: " + numberOfBathrooms +
                "\nMonthly Rental Rate: " + rentAmount.ToString("C") +
                "\n\nExpected Annual Rents: " + ProjectedRentalAmt().ToString("C");
        }
    }
}

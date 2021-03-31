using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15
{
    class MultiUnits : Housing, IUnits
    {
        private int numberOfUnits;
        private string complexName;
        private decimal rentAmountPerUnit;

        public MultiUnits(int yrBuilt, string addr, string typeOfConstr, int numberUnits, string name, decimal rentAmt)
            : base(yrBuilt, addr, typeOfConstr)
        {
            NoOfUnits = numberUnits;
            ComplexName = name;
            RentAmountPerUnit = rentAmt;
        }

        #region Properties
        public int NoOfUnits
        {
            get
            {
                return numberOfUnits;
            }
            set
            {
                numberOfUnits = value;
            }
        }
        public string ComplexName
        {
            get
            {
                return complexName;
            }
            set
            {
                complexName = value;
            }
        }
        public decimal RentAmountPerUnit
        {
            get
            {
                return rentAmountPerUnit;
            }
            set
            {
                rentAmountPerUnit = value;
            }
        }
        #endregion

        public override decimal ProjectedRentalAmt()
        {
            return 12 * rentAmountPerUnit * numberOfUnits;
        }

        public int GetNumUnits()
        {
            return numberOfUnits;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nNumber of Units: " + GetNumUnits() +
                "\nPer Unit Rent: " + rentAmountPerUnit.ToString("C") +
                "\n\nProjected Annual Rent From This Address: " + ProjectedRentalAmt().ToString("C");
        }
    }
}

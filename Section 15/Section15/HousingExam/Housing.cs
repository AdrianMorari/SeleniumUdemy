using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15
{
    class Housing
    {
        private int yearBuilt;
        private string address;
        private string typeOfConstruction;

        public Housing(int yr, string addr, string constructionType)
        {
            YearBuilt = yr;
            Address = addr;
            TypeOfConstruction = constructionType;
        }

        #region Properties
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
        public string TypeOfConstruction
        {
            get
            {
                return typeOfConstruction;
            }
            set
            {
                typeOfConstruction = value;
            }
        }
        #endregion


        public virtual decimal ProjectedRentalAmt()
        {
            return 0M;
        }

        public override string ToString()
        {
            return "\nAddress: " + address;
        }
    }
}

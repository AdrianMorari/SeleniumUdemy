using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11
{
    class Play : Ticket
    {
        private bool refreshmentsServed;
        private int numberOfActors;
        private string playSpecificInfo;

        public Play(int seatNum, string rowId, string dateTime, string nameEvent, string type,
            string location, bool refreshments, int numOfActors, string playInfo, double cost)
            : base(seatNum, rowId, dateTime, nameEvent, type, location, cost)
        {
            RefreshmentsServed = refreshments;
            NumbersOfActors = numOfActors;
            PlaySpecificInfo = playInfo;
        }

        public bool RefreshmentsServed
        {
            get
            {
                return refreshmentsServed;
            }
            set
            {
                refreshmentsServed = value;
            }
        }
        public int NumbersOfActors
        {
            get
            {
                return numberOfActors;
            }
            set
            {
                numberOfActors = value;
            }
        }
        public string PlaySpecificInfo
        {
            get
            {
                return playSpecificInfo;
            }
            set
            {
                playSpecificInfo = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nNumber of Actors: " + numberOfActors;
        }
    }
}

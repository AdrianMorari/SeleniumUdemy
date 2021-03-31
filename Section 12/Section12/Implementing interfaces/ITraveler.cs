using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12.Implementing_interfaces
{
    interface ITraveler
    {
        string GetDestination();
        string GetStartLocation();
        double DetermineMiles();
    }
}

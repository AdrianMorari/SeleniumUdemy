﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_7
{
    class ItemPrice
    {
        public ItemPrice(decimal price)
        {
            WholesalePrice = price;
        }

        public decimal WholesalePrice { get; set; }
    }
}

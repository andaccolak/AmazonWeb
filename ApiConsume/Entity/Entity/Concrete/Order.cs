﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Order
    {
        public int OrderID { get; set; }
        public int SiparisNumarasi { get; set; }
        public int BuyTry { get; set; }
        public int BuyUsd { get; set; }
        public int SellUsd { get; set; }
        public int SellTry { get; set; }
        public int SellForCountry { get; set; }
        public string Country { get; set; } 
    }
}

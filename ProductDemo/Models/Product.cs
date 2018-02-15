﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDemo.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { set; get; }
        public int Quantity { get; set; }
        public decimal AmountDue
        {
            get
            {
                return Quantity * Price;
            }

        }
    }
}

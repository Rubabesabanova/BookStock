﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStock.Models
{
    public class Product: Entity
    {
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}

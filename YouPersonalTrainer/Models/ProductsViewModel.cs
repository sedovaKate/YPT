﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YouPersonalTrainer.Models
{
    public class ProductsViewModel
    {
        public List<Product> Products { get; set; }

        public ProductsViewModel()
        {
            Products = new List<Product>();
        }
    }
}
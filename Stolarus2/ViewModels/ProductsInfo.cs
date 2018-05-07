using System;
using System.Collections.Generic;
using Stolarus2.Data.Models;

namespace Stolarus2.ViewModels
{
    public class ProductsInfo
    {
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<Product> Products { get; set; }
    }
}
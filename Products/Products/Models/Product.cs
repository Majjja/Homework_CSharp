using System;
using System.Collections.Generic;
using System.Text;
using Products.Enums;
using Products.Helpers;

namespace Products
{
    public class Product
    {
        public Product()
        {
            Products = new List<Product>();
            ID = HelperMethods.IdGenerator(Products);
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public Category Category { get; set; }

        public List<Product> Products { get; set; }

        public static implicit operator int(Product v)
        {
            throw new NotImplementedException();
        }
    }
}

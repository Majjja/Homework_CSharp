using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ProductApp.Entities
{
    public class Product
    {
        public Product()
        {
            Count++;
            ID = Count;
        }
        private static int Count { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
    }
}

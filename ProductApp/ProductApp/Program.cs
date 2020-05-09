using ProductApp.Entities;
using System;
using System.Collections.Generic;
using ProductApp.Helpers;
using System.Linq;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = ProductHelper.Products();

            ProductHelper.SearchByCategory(products, Category.ItEquipment);
            Console.WriteLine("--------------------------------------");

            ProductHelper.FilterProductsByPrice(products);
            Console.WriteLine("--------------------------------------");

            ProductHelper.FindProductByPartOfName(products, "mo");
            Console.WriteLine("--------------------------------------");

            ProductHelper.ProductIDs(products);
            Console.WriteLine("--------------------------------------");

            ProductHelper.GetProductPrice(products, 8);
            Console.WriteLine("--------------------------------------");

            ProductHelper.CheapestProduct(products);
            Console.WriteLine("--------------------------------------");

            ProductHelper.TheMostExpensiveProduct(products);
            Console.WriteLine("--------------------------------------");

            ProductHelper.AddingNewProduct(products, "Usb", 120, Category.ItEquipment);
            Console.WriteLine("--------------------------------------");

            ProductHelper.RemoveProduct(products, 15);
        }
    }
}

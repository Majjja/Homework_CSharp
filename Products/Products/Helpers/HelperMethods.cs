using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Enums;

namespace Products.Helpers
{
    public class HelperMethods
    {
        public static void SearchProductsByCategory(List<Product> products, Category category)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"{category}: ");
            Console.WriteLine("------------------------");

            foreach (var product in products)
            {
                if (product.Category == category)
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}$");
            }
        }

        //*************
        public static void FilterProductsByPriceRange(List<Product> products)
        {
            products.Sort((x, y) => x.Price.CompareTo(y.Price));

            foreach (var product in products)
            {
                Console.WriteLine(product.Price);
            }

        }

        public static void FindProductsByPartOfName(List<Product> products, string partOfName)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"Found products by part of their name:");
            Console.WriteLine("------------------------");

            foreach (var product in products)
            {
                if (product.Name.ToLower().Contains(partOfName.ToLower()))
                    Console.WriteLine($"{product.Name}, {product.Price}, {product.Category}");
            }

        }

        //ClassLibraryMethod
        public static int IdGenerator(List<Product> products)
        {
            var rand = new Random();
            //int id = 0;
            int id = rand.Next(1, 21);
            foreach (var product in products)
            {
                foreach (var prod in products)
                {
                    if (product.ID.Equals(prod.ID))
                        id = new Random().Next(1, 21);

                }
            }
            return id;
        }


        public static void GetProductsIds(List<Product> products)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"Products IDs:");
            Console.WriteLine("------------------------");

            HelperMethods.IdGenerator(products);
            foreach (var item in products)
            {
                Console.WriteLine($"Name: {item.Name}, ID: {item.ID}");
            }
        }


        public static int CheapestProduct(List<Product> products)
        {
            int cheapest = products[0].Price;
            foreach (var product in products)
            {                
                if (product.Price < cheapest)
                {
                    cheapest = product.Price;
                    Console.WriteLine($"The cheapest product is {product.Name}, price {product.Price}");
                }
            }
            return cheapest;
        }

        public static int MostExpensiveProduct(List<Product> products)
        {
            int mostExpensive = products[0].Price;
            foreach (var product in products)
            {
                if (product.Price > mostExpensive)
                {
                    mostExpensive = product.Price;
                    Console.WriteLine($"The most expensive product is {product.Name}, price {product.Price}");
                }
            }
            return mostExpensive;
        }

        public static void AddingProducts(List<Product> products, string name, int price, Category category)
        {
            products.Add(new Product() { Name = name, Price = price, Category = category});
        }
    }
}

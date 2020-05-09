using System;
using System.Collections.Generic;
using System.Text;
using ProductApp.Entities;
using System.Linq;

namespace ProductApp.Helpers
{
    public class ProductHelper
    {
        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product() { Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
                new Product() { Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
                new Product() { Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
                new Product() { Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
                new Product() { Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                new Product() { Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
                new Product() { Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
                new Product() { Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
                new Product() { Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
                new Product() { Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
                new Product() { Name =  "Office 1", Price = 10200, Category = Category.PC},
                new Product() { Name =  "Office 2", Price = 12400, Category = Category.PC},
                new Product() { Name =  "Gaming", Price = 22000, Category = Category.PC},
                new Product() { Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
                new Product() { Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                new Product() { Name =  "Alienware", Price = 128000, Category = Category.PC},
                new Product() { Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
                new Product() { Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
                new Product() { Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
                new Product() { Name =  "SONY RW78OS", Price = 179999, Category = Category.TV},
                new Product() { Name =  "Samsung Oval", Price = 247999, Category = Category.TV}
            };
        }

        //1.    Search products by category // return all products from given category
        public static void SearchByCategory(List<Product> listOfProducts, Category category)
        {
            var productsByCategory = listOfProducts
                    .Where(product => product.Category.Equals(category))
                    .Select(product => product.Name)
                    .ToList();

            productsByCategory.ForEach(product => Console.WriteLine(product));
        }

        //2.    Filter products by price range(from min to max) // return all products that fall in the given price range

        public static List<Product> FilterProductsByPrice(List<Product> listOfProducts)
        {
            var productsByPriceRangeThatFall = listOfProducts
                                                        .OrderByDescending(product => product.Price)
                                                        .ToList();
            foreach (var product in productsByPriceRangeThatFall)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }
            return productsByPriceRangeThatFall;
        }

        //3.    Find products by part of name // get all products that consist the part in their names
        public static void FindProductByPartOfName(List<Product> listOfProducts, string partOfName)
        {
            var productByPartOfName = listOfProducts
                                        .Where(product => product.Name.ToLower().Contains(partOfName.ToLower()))
                                        .ToList();

            productByPartOfName.ForEach(product => Console.WriteLine(product.Name));   
        }

        //4.    Get only products ids // return only the ids of the products
        public static List<int> ProductIDs(List<Product> listOfProducts)
        {
            var productsId = listOfProducts
                                        .Select(product => product.ID)
                                        .ToList();
            productsId.ForEach(id => Console.WriteLine(id));

            return productsId;
        }

        //5.    Get product price // get the price of the product - give the id as parameter
        public static void GetProductPrice(List<Product> listOfProducts, int id)
        {
            var price = listOfProducts
                                    .Where(product => product.ID.Equals(id))
                                    .Select(product => product.Name)
                                    .ToList();
            price.ForEach(name => Console.WriteLine(name));                       
        }

        //6.    Get cheapest product // return the cheapest product
        public static Product CheapestProduct(List<Product> listOfProducts)
        {
            var min = listOfProducts.Min(product => product.Price);
            var cheapestproduct = listOfProducts
                                            .SingleOrDefault(product => product.Price.Equals(min));

            Console.WriteLine(cheapestproduct.Name);
            
            return cheapestproduct;
        }

        //7.    Get most expensive product // return the most expensive one
        public static Product TheMostExpensiveProduct(List<Product> listOfProducts)
        {
            var max = listOfProducts.Max(product => product.Price);
            var mostExpensiveProduct = listOfProducts
                                                    .SingleOrDefault(product => product.Price.Equals(max));

            Console.WriteLine(mostExpensiveProduct.Name);

            return mostExpensiveProduct;
        }

        //8.    Add product // create method to add product to the list of products
        public static void AddingNewProduct(List<Product> listOfProduct, string name, int price, Category category)
        {
            listOfProduct.Add(new Product()
            {
                Name = name,
                Price = price,
                Category = category
            });

            var newProduct = listOfProduct
                                    .TakeLast(1)
                                    .ToList();
            
            foreach (var item in newProduct)
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Category: {item.Category}, ID: {item.ID}");
            
        }

        //9.    Remove product // and a method to remove it - use id as parameter
        public static void RemoveProduct(List<Product> listOfProducts, int id)
        {
            var productToRemove = listOfProducts.SingleOrDefault(product => product.ID.Equals(id));

            if (productToRemove != null)
                listOfProducts.Remove(productToRemove);
        }
    }
}

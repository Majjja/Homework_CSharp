using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServices
{
    public class GenerateProductID
    {
        public static int IdGenerator()
        {
            return new Random().Next(1, 1000);
        }

        //public static int IdGenerator2(List<Product> products)
        //{
        //    int rand = new Random();
        //    int id = 0;
        //    foreach (var product in products)
        //    {
        //        id = rand.Next(1, 1000);
        //        if (product.ID.Equals(id))
        //            id = new Random().Next(1, 1000)
        //    }
        //    return id;
        //}
    }
}

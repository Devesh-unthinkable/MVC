using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelViewsDemo.Models;

namespace ModelViewsDemo.Models
{
    public class ProductData
    {
        public IEnumerable<Product> ProductList
        {
            get
            {
                List<Product> products = new List<Product>()
                {
                    new Product {ProductID = 1, Name = "Samsung TV", Price = 39999.99},
                    new Product {ProductID = 2, Name = "Smart Phone", Price = 19999.99},
                    new Product {ProductID = 3, Name = "Shoes", Price = 999.99}
                };
                return products;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuldingForms.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products;
        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product(){Id=1, Name="Product1", Description="Description 1", Price=2000, IsApproved=true},
                new Product(){Id=2, Name="Product2", Description="Description 2", Price=4000, IsApproved=false},
                new Product(){Id=3, Name="Product3", Description="Description 3", Price=3000, IsApproved=true},
                new Product(){Id=4, Name="Product4", Description="Description 4", Price=20, IsApproved=false},
                new Product(){Id=5, Name="Product5", Description="Description 5", Price=100, IsApproved=true}
            };
         
        }
        public static List<Product> Products
        {
            get { return _products; }
        }
        public static void AddProduct(Product entity)
        {
            _products.Add(entity);
        }
    }
}

using OdatPractiseCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdatPractiseCoreApi.Domain
{
    public class ProductDomain
    {
        public List<Product> Products = new List<Product>();

        public ProductDomain()
        {
            Product product = new Product();
            product.EntityID = 1;
            product.Name = "iphone 12";
            product.Price = 12000;
            Products.Add(product);

            Product product1 = new Product();
            product1.EntityID = 2;
            product1.Name = "galaxy 13";
            product1.Price = 15000;
            Products.Add(product1);

            Product product2 = new Product();
            product2.EntityID = 3;
            product2.Name = "Asus chromebook";
            product2.Price = 10000;
            Products.Add(product2);
        }
    }
}

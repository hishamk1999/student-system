using P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Data
{
    class DbSeeder
    {
        public static void Seed(ApplicationDBContext context)
        {
            if (context.Products.Any()) return;

            var customer1 = new Customer
            {
                Name = "Ahmed Khaled",
                Email = "ahmed@example.com",
                CreaditCardNumber = "1234-5678-9876-5432"
            };

            var store1 = new Store
            {
                Name = "Cairo SuperMart"
            };

            var product1 = new Product
            {
                Name = "Laptop",
                Quantity = 5,
                Price = 15000
            };

            var product2 = new Product
            {
                Name = "Keyboard",
                Quantity = 20,
                Price = 400
            };

            var sale1 = new Sale
            {
                Date = DateTime.Now,
                Customer = customer1,
                Store = store1,
                Product = product1
            };

            var sale2 = new Sale
            {
                Date = DateTime.Now,
                Customer = customer1,
                Store = store1,
                Product = product2
            };

            context.AddRange(customer1, store1, product1, product2, sale1, sale2);
            context.SaveChanges();
        }
    }
}

using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "New York", "NY", "USA");
            Customer customer1 = new Customer("Will SMith", address1);
            Order order1 = new Order(customer1);
            Product product1 = new Product("Labtop", "LAP123", 999.99, 1);
            Product product2 = new Product("Mouse", "MOU456", 25.50,  2);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Console.WriteLine("Order 1 - Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Order 1 - Shiping Label:");
            
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Order 1 - Total  Cost: $" + order1.CalculateTotalCost());
            Console.WriteLine();

            Address address2 = new Address("456 Elm St", "Toronto", "Ontario", "Canada");
           
            Customer customer2 = new Customer("Jane Johnson", address2);
            Order order2 = new Order(customer2);
            Product product3 = new Product("Smartphone", "SMP789", 599.99, 1);
            Product product4 = new Product("Headphones", "HEA321", 89.99, 1);
            Product product5 = new Product("charger", "CHA654", 19.99, 2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            order2.AddProduct(product5);

            Console.WriteLine("Order 2 - Paking Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Order 2 - Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Order 2 - Total cost: $" + order2.CalculateTotalCost());
        }
    }
}

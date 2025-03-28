using System.Collections.Generic;

namespace OrderSystem
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double CalculateTotalCost()
        {
            double total = 0.0;
            foreach (Product product in products)
            {
                total += product.CalculateTotalCost();
            }

            total += customer.LivesInUSA() ? 5.0 : 35.0;
            return total;
        }

        public string GetPackingLabel()
        {
            string label = "";
            foreach (Product product in products)
            {

                label += $"{product.ProductName} ({product.ProductId})\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"{customer.Name}\n{customer.Address.GetFullAddress()}";
        }
        
    }
}

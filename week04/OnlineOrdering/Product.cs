namespace OrderSystem
{
    public class Product
    {
        private string productName;
        private string productId;
        private double price;

        private int quantity;

        public Product(string productName, string productId, double price, int quantity)
        {
            this.productName = productName;
            this.productId = productId;
            this.price = price;

            this.quantity = quantity;
        }


        public double CalculateTotalCost()
        {
            return price *  quantity;
        }

        public string ProductName { get { return productName; } }
        public string ProductId { get { return productId; } }
    }
}

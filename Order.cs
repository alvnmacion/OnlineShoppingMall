namespace OnlineShoppingMall
{
    public class Order : Product

    {
        private List<Product> products;
        private readonly decimal total;

        public Order(List<Product> products)
        {
            this.products = products;
            this.total = CalculateTotal();
        }

        public decimal Total
        {
            get { return total; }
        }

        private decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (Product product in products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}

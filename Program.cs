using OnlineShoppingMall;

public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product("Shirt", 19.99m, "A comfortable shirt for everyday wear.", "Clothing", "4.5"),
            new Product("Jeans", 39.99m, "Stylish and durable denim jeans.", "Clothing", "4.2"),
            new Product("Sneakers", 59.99m, "Comfortable and supportive athletic shoes.", "Footwear", "4.8"),
            new Product("Backpack", 29.99m, "A spacious and durable backpack for daily use.", "Accessories", "4.1")
        };

        Shopping shopping = new Shopping(products);
        ShoppingCart cart = new ShoppingCart("12345", 10);

        Console.WriteLine("Welcome to our online store!");

        while (true)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. View available products");
            Console.WriteLine("2. Add a product to your cart");
            Console.WriteLine("3. Remove a product from your cart");
            Console.WriteLine("4. View your cart");
            Console.WriteLine("5. Checkout");
            Console.WriteLine("6. Exit\n");
            Console.WriteLine("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    shopping.ShowProducts();
                    break;
                case "2":
                    Console.Clear();
                    shopping.ShowProducts();
                    Console.WriteLine("Enter the name of the product you want to add to your cart:");
                    string productName = Console.ReadLine();
                    Product productToAdd = shopping.SelectProduct(productName);
                    if (productToAdd != null)
                    {
                        cart.AddProduct(productToAdd);
                    }
                    break;
                case "3":
                    cart.ShowCart();
                    Console.WriteLine("Enter the name of the product you want to remove from your cart:");
                    string productToRemove = Console.ReadLine();
                    Product product = cart.Products.Find(p => p.Name == productToRemove);
                    if (product != null)
                    {
                        cart.RemoveProduct(product);
                    }
                    break;
                case "4":
                    Console.Clear();
                    cart.ShowCart();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("How would you like to pay?");
                    Console.WriteLine("1. Cash on delivery");
                    Console.WriteLine("2. Online payment");
                    string paymentChoice = Console.ReadLine();
                    if (paymentChoice == "1")
                    {
                        CashOnDelivery payment = new CashOnDelivery();
                        payment.Amount = cart.Checkout();
                        payment.DeliveryAddress = cart.ShoppingCartId;
                        payment.ProcessPayment();
                    }
                    else if (paymentChoice == "2")
                    {
                        Console.Clear();
                        OnlinePayment payment = new OnlinePayment();
                        payment.Amount = cart.Checkout();
                        Console.WriteLine("Enter your card number:");
                        payment.CardNumber = Console.ReadLine();
                        Console.WriteLine("Enter your card expiry date (MM/YY):");
                        payment.ExpiryDate = Console.ReadLine();
                        Console.WriteLine("Enter your card CVV:");
                        payment.CVV = Console.ReadLine();
                        payment.ProcessPayment();
                    }
                    break;
                case "6":
                    Console.WriteLine("Thank you for shopping with us!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
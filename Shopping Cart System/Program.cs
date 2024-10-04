namespace Shopping_Cart_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddItem(new Item("Apple", 1.50m, 5));
            shoppingCart.AddItem(new Item("Banana", 0.75m, 10));
            shoppingCart.AddItem(new Item("Milk", 3.20m, 2));

            shoppingCart.DisplayCart();

            // Remove an item
            shoppingCart.RemoveItem("Banana");

            // Display the cart after removal
            shoppingCart.DisplayCart();

            // Apply a discount
            Discount discount = new Discount(10);
            var totalWithDiscount = discount.Apply(shoppingCart.GetTotalPrice());
            Console.WriteLine($"Total Price after 10% discount: {totalWithDiscount:C}");
        }
    }
}

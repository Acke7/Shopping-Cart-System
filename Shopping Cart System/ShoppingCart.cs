using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart_System
{
    internal class ShoppingCart
    {
        private List<Item> Items { get; set; } = new List<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public void RemoveItem(string name)
        {
            var itemToRemove = Items.FirstOrDefault(i => i.Name == name);
            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove);
            }
        }
        public decimal GetTotalPrice()
        {
            return Items.Sum(item => item.Price * item.Quantity);
        }
        public void DisplayCart()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
            }
            else
            {
                foreach (var item in Items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Total Price: {GetTotalPrice():C}");
            }
        }
    }

}

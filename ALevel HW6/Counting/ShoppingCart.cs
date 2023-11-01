using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALevel_HW6.Models;

namespace ALevel_HW6.Counting
{
    public class ShoppingCart
    {
        private const int MaxItems = 10;
        public List<Product> Items { get; private set; }

        public ShoppingCart()
        {
            Items = new List<Product>();
        }

        public void AddItem(Product product)
        {
            if (Items.Count < MaxItems)
            {
                Items.Add(product);
                Console.WriteLine($"{product.Name} has been added to the cart.");
            }
            else
            {
                Console.WriteLine("The shopping cart is full. You can't add more product.");
            }
        }
        public static void DisplayCartItems(ShoppingCart cart)
        {
            if (cart.Items.Count == 0)
            {
                Console.WriteLine("The shopping cart is empty.");
            }
            else
            {
                Console.WriteLine("Products in the cart:");
                foreach (var item in cart.Items)
                {
                    Console.WriteLine($"{item.Name} - {item.Price} UAN");
                }
            }
        }
    }
}

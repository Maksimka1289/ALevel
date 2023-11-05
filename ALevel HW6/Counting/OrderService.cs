using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALevel_HW6.Models;

namespace ALevel_HW6.Counting
{
    public class OrderService
    {

        private static int orderCount = 0;

        public void PlaceOrder(ShoppingCart cart)
        {
            Bill bill = new Bill
            {
                OrderTime = DateTime.Now,
                Products = cart.Items,
            };

            if (cart.Items.Count == 0)
            {
                Console.WriteLine("The shopping cart is empty. Please add some items before placing an order.");
                return;
            }

            orderCount++;
            Console.WriteLine($"Order {orderCount} has been placed successfully.");
            Console.Write($"Your check: {bill.OrderTime}, {bill.Id}. Summ of check: {bill.Amount}. ");
            Console.WriteLine("Product in check:   {0}", string.Join(", ", bill.Products.Select(x => x.Name)));
            cart.Items.Clear();

        }
    }
}

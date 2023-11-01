using ALevel_HW6.Counting;
using ALevel_HW6.Models;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var product = new Product();
        var shoppingCart = new ShoppingCart();
        var orderService = new OrderService();

        var products = new Product[]
        {
                new Product { Name = "CocaCola", Price = 32},
                new Product { Name = "PepsiCola", Price=33},
                new Product { Name = "Chitos", Price = 40},
                new Product { Name = "Lays", Price = 50},
                new Product { Name = "BigBob", Price = 25},
                new Product { Name = "Fish", Price = 120},
                new Product { Name = "Meat", Price = 150},
                new Product { Name = "Juice", Price = 60},
                new Product { Name = "Chocolate", Price = 30},
                new Product { Name = "Snack", Price = 23},
                new Product { Name = "Alcohol", Price = 200},
                new Product { Name = "Pizza", Price = 170},
                new Product { Name = "Hot-Dog", Price = 70},
                new Product { Name = "Bread", Price = 15},
                new Product { Name = "Cookie", Price = 36}
        };

        Console.WriteLine("Available Products:");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i].Name} - {products[i].Price} UAN");
        }
        while (true)
        {
            Console.WriteLine("Enter the product number to add to the cart (0 to place order, -1 to display cart):");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int productIndex) && productIndex >= 1 && productIndex <= products.Length)
            {
                shoppingCart.AddItem(products[productIndex - 1]);
            }
            else if (input == "0")
            {
                orderService.PlaceOrder(shoppingCart);
            }
            else if (input == "-1")
            {
                ShoppingCart.DisplayCartItems(shoppingCart);
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
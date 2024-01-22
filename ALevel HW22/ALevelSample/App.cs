using System.Collections.Generic;
using System.Threading.Tasks;
using ALevelSample.Models;
using ALevelSample.Services.Abstractions;

namespace ALevelSample;

public class App
{
    private readonly IUserService _userService;
    private readonly IOrderService _orderService;
    private readonly IProductService _productService;

    public App(
        IUserService userService,
        IOrderService orderService,
        IProductService productService)
    {
        _userService = userService;
        _orderService = orderService;
        _productService = productService;
    }

    public async Task Start()
    {
        var firstName = "first name";
        var lastName = "last name";

        var userId = await _userService.AddUser(firstName, lastName);
        var userId1 = await _userService.AddUser("Maksim", "Duzhyi");
        var userId2 = await _userService.AddUser("Taras", "Vons");

        await _userService.GetUser(userId);

        var product1 = await _productService.AddProductAsync("product1", 4);
        var product2 = await _productService.AddProductAsync("product2", 7);
        var product3 = await _productService.AddProductAsync("product3", 5);
        var product4 = await _productService.AddProductAsync("product4", 6);

        await _productService.UpdateProductAsync(product3, 10);

        await _productService.GetProductAsync(product3);

        await _productService.DeleteProductAsync(product4);

        var order1 = await _orderService.AddOrderAsync(userId, new List<OrderItem>()
        {
            new OrderItem()
            {
                Count = 3,
                ProductId = product1
            },

            new OrderItem()
            {
                Count = 6,
                ProductId = product2
            },
        });

        var order2 = await _orderService.AddOrderAsync(userId, new List<OrderItem>()
        {
            new OrderItem()
            {
                Count = 1,
                ProductId = product1
            },

            new OrderItem()
            {
                Count = 9,
                ProductId = product2
            },
        });

        var userOrder = await _orderService.GetOrderByUserIdAsync(userId);

        await _orderService.UpdateOrder(order1, new List<OrderItem>()
        {
            new OrderItem()
            {
                Count = 8,
                ProductId = product2
            },

            new OrderItem()
            {
                Count = 1,
                ProductId = product3
            }
        });

        await _orderService.DeleteOrder(product4);

        await _orderService.GetOrderAsync(order1);

        await _productService.GetPaginatedProductsAsync(0, 8);
    }
}
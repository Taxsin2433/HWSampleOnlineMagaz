using ConsoleApp2.Models;
using ConsoleApp2.Repositories;
using ConsoleApp2.Repositories.Shop.Repositories;
using ConsoleApp2.Services;
using ConsoleApp2.Services.Shop.Services;
namespace Program;


public class Program
{
    private static ProductService _productService;
    private static CartService _cartService;
    private static OrderService _orderService;

    public static void Main(string[] args)
    {
        var productRepository = new ProductRepository();
        var cartRepository = new CartRepository();
        var orderRepository = new OrderRepository();

        _productService = new ProductService(productRepository);
        _cartService = new CartService(cartRepository);
        _orderService = new OrderService(orderRepository);

       
        while (true)
        {
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Add to cart");
            Console.WriteLine("3. Remove from cart");
            Console.WriteLine("4. Place order");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an action: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    AddToCart();
                    break;
                case "3":
                    RemoveFromCart();
                    break;
                case "4":
                    PlaceOrder();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void AddProduct()
    {
        Console.Write("Enter product Id: ");
        var productId = int.Parse(Console.ReadLine());

        Console.Write("Enter product name: ");
        var productName = Console.ReadLine();

        Console.Write("Enter product price: ");
        var productPrice = decimal.Parse(Console.ReadLine());

        var product = new Product
        {
            Id = productId,
            Name = productName,
            Price = productPrice
        };

        _productService.AddProduct(product);
        Console.WriteLine("Product added successfully.");
    }

    private static void AddToCart()
    {
        Console.Write("Enter product Id: ");
        var productId = int.Parse(Console.ReadLine());

        Console.Write("Enter quantity: ");
        var quantity = int.Parse(Console.ReadLine());

        var cartItem = new CartItem
        {
            ProductId = productId,
            Quantity = quantity
        };

        _cartService.AddToCart(cartItem);
        Console.WriteLine("Product added to cart successfully.");
    }

    private static void RemoveFromCart()
    {
        Console.Write("Enter product Id: ");
        var productId = int.Parse(Console.ReadLine());


        var cartItem = _cartService.GetAllCartItems().FirstOrDefault(item => item.ProductId == productId);

        if (cartItem != null)
        {
            _cartService.RemoveFromCart(cartItem);
            Console.WriteLine("Product removed from cart successfully.");
        }
        else
        {
            Console.WriteLine("Product not found in cart.");
        }
    }

    private static void PlaceOrder()
    {
        var cartItems = _cartService.GetAllCartItems();

        if (!cartItems.Any())
        {
            Console.WriteLine("Cart is empty. Add products to the cart before placing an order.");
            return;
        }

        Console.Write("Enter order Id: ");
        var orderId = int.Parse(Console.ReadLine());

        var order = new Order
        {
            Id = orderId,
            Items = (List<CartItem>)cartItems
        };

        _orderService.PlaceOrder(order);
        _cartService.ClearCart();

        Console.WriteLine("Order placed successfully.");
    }
}

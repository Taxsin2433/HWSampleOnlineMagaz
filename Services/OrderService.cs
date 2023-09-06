using ConsoleApp2.Models;
using ConsoleApp2.Repositories;

namespace ConsoleApp2.Services
{
    namespace Shop.Services
    {
        public class OrderService
        {
            private readonly OrderRepository _orderRepository;
            public OrderService(OrderRepository orderRepository)
            {
                _orderRepository = orderRepository;
            }

            public void PlaceOrder(Order order)
            {
                _orderRepository.PlaceOrder(order);
            }
            public List<Order> GetAllOrders()
            {
                return _orderRepository.GetAllOrders();
            }
            public List<Order> GetAllOrder()
            {
                return _orderRepository.GetAllOrders();
            }
        }
    }
    }

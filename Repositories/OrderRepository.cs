using ConsoleApp2.Models;

namespace ConsoleApp2.Repositories
{
    

        
            public class OrderRepository
            {
                private List<Order> orderList;

        private List<Order> orderList2;

        public OrderRepository()
        {
            orderList2 = new List<Order>();
        }

        public List<Order> GetAllOrders()
        {
            return orderList2;
        }

        public void PlaceOrder(Order order)
                  {
                      // Размещает заказ в базе данных или другом источнике данных.
                  }
                  public List<Order> GetAllOrder()
                  {
                  return orderList;  // Возвращает список всех заказов из базы данных или другого источника данных.
                  }   
    }
        }

    

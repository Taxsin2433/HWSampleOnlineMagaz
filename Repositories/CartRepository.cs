using ConsoleApp2.Models;

namespace ConsoleApp2.Repositories
{

    
        public class CartRepository
        {
        private List<CartItem> cartItems;

        public CartRepository()
        {
            cartItems = new List<CartItem>();
        }
        public List<CartItem> GetAllCartItems()
        {
            return cartItems;
        }

        public void RemoveFromCart(CartItem item)
        {
            cartItems.Remove(item);
        }
        public void AddToCart(CartItem item)
            {
            cartItems.Add(item);  // Добавляет товар в корзину в базе данных или другом источнике данных.
            }
            public void ClearCart()
            {
                // Очищает корзину в базе данных или другом источнике данных.
            }   
    }

    }
        
using ConsoleApp2.Models;
using ConsoleApp2.Repositories;

namespace ConsoleApp2.Services
{

    
        public class CartService
        {
            private readonly CartRepository _cartRepository;
            public CartService(CartRepository cartRepository)
            {
                _cartRepository = cartRepository;
            }

            public void AddToCart(CartItem item)
            {
                _cartRepository.AddToCart(item);
            }
            public void RemoveFromCart(CartItem item)
            {
                _cartRepository.RemoveFromCart(item);
            }

        public void ClearCart()
            {
                _cartRepository.ClearCart();
            }

        public List<CartItem> GetAllCartItems()
        {

            return _cartRepository.GetAllCartItems();
        }
    }
    }
    

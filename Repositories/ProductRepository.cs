using ConsoleApp2.Models;

namespace ConsoleApp2.Repositories
{
    namespace Shop.Repositories
    {
        public class ProductRepository
        {
            private List<Product> productList = new List<Product>();

            public void AddProduct(Product product) 
            {
                productList.Add(product);
            }
            public  List<Product> GetAllProducts()
            {
                return productList;  // Возвращает список всех товаров из базы данных или другого источника данных.
            }
        }
    }
}

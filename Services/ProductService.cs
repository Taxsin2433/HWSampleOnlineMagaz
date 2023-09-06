using ConsoleApp2.Models;
using ConsoleApp2.Repositories.Shop.Repositories;

namespace ConsoleApp2.Services
{
    namespace Shop.Services
    {
        public class ProductService
        {
            private readonly ProductRepository _productRepository;

            public ProductService(ProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public List<Product> GetAllProducts() => _productRepository.GetAllProducts();

            internal void AddProduct(Product product)
            {
                _productRepository.AddProduct(product);
            }
        }

    }
}

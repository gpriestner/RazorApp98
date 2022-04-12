using RazorApp98.Models;

namespace RazorApp98.Data
{
    public class ProductData : IProductData
    {
        public IEnumerable<ProductDto> GetProducts()
        {
            var products = new List<ProductDto>();
            products.Add(new ProductDto { Description = "Nikon D600", Price = 699.99m });
            products.Add(new ProductDto { Description = "Canon E300", Price = 449.99m });
            return products;
        }
    }
}

using RazorApp98.Models;

namespace RazorApp98.Data
{
    public interface IProductData
    {
        IEnumerable<ProductDto> GetProducts();
    }
}
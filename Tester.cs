using Microsoft.AspNetCore.Mvc;
using RazorApp98.Data;

namespace RazorApp98
{
    public class Tester : ViewComponent
    {
        private readonly IProductData _productData;

        public Tester(IProductData productData)
        {
            _productData = productData;
        }

        public async Task<IViewComponentResult> InvokeAsync(string str)
        {
            var products = _productData.GetProducts();
            return View("Default", products);
        }
    }
}

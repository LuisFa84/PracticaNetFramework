using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticaNetFramework.Pages
{
    public class ProductosModel : PageModel
    {
        private readonly ILogger<ProductosModel> _logger;

        public ProductosModel(ILogger<ProductosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
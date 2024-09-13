using aspnet_shopping_cart.Models;
using aspnet_shopping_cart.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_shopping_cart.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IEnumerable<Product> Products { get; private set; }

        public ProductService ProdService;

        public IndexModel(ILogger<IndexModel> logger, ProductService prodService)
        {
            _logger = logger;
            ProdService = prodService;
        }

        public void OnGet()
        {
            Products = ProdService.GetProducts();
        }
    }
}

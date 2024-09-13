using aspnet_shopping_cart.Models;
using aspnet_shopping_cart.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace aspnet_shopping_cart.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(ProductService prodService) {
            this.ProdService = prodService;
        }

        public ProductService ProdService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProdService.GetProducts();
        }
    }
}

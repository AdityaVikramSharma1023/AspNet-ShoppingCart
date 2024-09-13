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
    public class CartController : ControllerBase
    {
        public CartController(CartService mycartService)
        {
            this.MyCartService = mycartService;
        }

        public CartService MyCartService { get; }

        [HttpGet]
        public Cart Get()
        {
            return MyCartService.GetCart();
        }
    }
}

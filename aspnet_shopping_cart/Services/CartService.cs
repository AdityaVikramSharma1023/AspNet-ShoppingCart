using aspnet_shopping_cart.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;

namespace aspnet_shopping_cart.Services
{
    public class CartService
    {
        public CartService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "cart.json"); }
        }
        public Cart GetCart()
        {
            using (var filereader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Cart>(filereader.ReadToEnd(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );
            }
        }
        
        public void AddCart(string productId, float productPrice)
        {
            var cart = GetCart();

            if (cart.Products == null)
            {
                cart.Products = new string[] { productId };
                cart.Pcount = 1;
                cart.Bill = productPrice;
            }
            else
            {
                var cartList = cart.Products.ToList();
                cartList.Add(productId);
                cart.Products = cartList.ToArray();
                cart.Pcount += 1;
                cart.Bill += productPrice;
            }

            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<Cart>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    cart
                );
            }
        }
        public void RemoveCart(string productId, float productPrice)
        {
            var cart = GetCart();
            var cartList = cart.Products.ToList();
            cartList.Remove(productId);
            cart.Products = cartList.ToArray();
            cart.Pcount -= 1;
            cart.Bill -= productPrice;


            //open file stream
            using (StreamWriter file = File.CreateText(JsonFileName))
            {
                file.Write(cart);
            }
        }
    }
}

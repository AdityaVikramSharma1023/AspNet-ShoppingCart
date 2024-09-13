using aspnet_shopping_cart.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace aspnet_shopping_cart.Services
{
    public class ProductService
    {
        //constructor
        public ProductService(IWebHostEnvironment webHostEnvironment) {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        //gets the products.json file path without hardcoding
        private string JsonFileName {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }

        //get an IEnumerable of all the products
        public IEnumerable<Product> GetProducts()
        {
            using (var filereader = File.OpenText(JsonFileName)) {
                return JsonSerializer.Deserialize<Product[]>(filereader.ReadToEnd(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true}
                    );
            }
        }

        public void AddRatings(string productId, int rating)
        {
            var productList = GetProducts();
            var query = productList.First(x => x.Id == productId);

            if (query.Ratings == null)
            {
                query.Ratings = new int[] { rating };
            }
            else
            {
                var ratingsList = query.Ratings.ToList();
                ratingsList.Add(rating);
                query.Ratings = ratingsList.ToArray();
            }

            using (var outputStream = File.OpenWrite(JsonFileName)) {
                JsonSerializer.Serialize<IEnumerable<Product>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    productList
                );
            }
        }
    }
}

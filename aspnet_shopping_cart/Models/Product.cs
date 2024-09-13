using System.Text.Json;

namespace aspnet_shopping_cart.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}

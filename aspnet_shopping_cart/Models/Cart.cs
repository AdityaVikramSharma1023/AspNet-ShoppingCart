using System.Text.Json;

namespace aspnet_shopping_cart.Models
{
    public class Cart
    {
        public string[] Products { get; set; }  
        public int Pcount { get; set; }
        public float Bill { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Cart>(this);
    }
}

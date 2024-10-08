// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace aspnet_shopping_cart.Components
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Components\ProductList.razor"
 using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Components\ProductList.razor"
 using aspnet_shopping_cart.Components

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Components\ProductList.razor"
 using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Components\ProductList.razor"
 using aspnet_shopping_cart.Models

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Components\ProductList.razor"
 using aspnet_shopping_cart.Services

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class ProductList : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Components\ProductList.razor"
           
        Product selectProduct;

        void SelectProduct(string productId)
        {
            selectProduct = ProdService.GetProducts().First(x => x.Id == productId);
            GetCurrentRating();
        }

        int currentRating = 0;
        int voteCount = 0;
        string voteLabel;

        void GetCurrentRating()
        {
            if (selectProduct.Ratings == null)
            {
                currentRating = 0;
                voteCount = 0;
            }
            else
            {
                voteCount = selectProduct.Ratings.Count();
                currentRating = selectProduct.Ratings.Sum() / voteCount;
                voteLabel = voteCount > 1 ? "Votes" : "Vote";
            }
            System.Console.WriteLine($"ProductId {selectProduct.Id}: {currentRating} with {voteCount} {voteLabel}");
        }

        void SubmitRating(int rating)
        {
            System.Console.WriteLine($"ProductId {selectProduct.Id}: {rating}");
            ProdService.AddRatings(selectProduct.Id, rating);
            SelectProduct(selectProduct.Id);
        }


        void AddToCart(string productId, float productPrice)
        {
            MyCartService.AddCart(productId, productPrice);
        }
    

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 7 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Components\ProductList.razor"
        ProductService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 7 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Components\ProductList.razor"
                       ProdService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 6 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Components\ProductList.razor"
        CartService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 6 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Components\ProductList.razor"
                    MyCartService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591

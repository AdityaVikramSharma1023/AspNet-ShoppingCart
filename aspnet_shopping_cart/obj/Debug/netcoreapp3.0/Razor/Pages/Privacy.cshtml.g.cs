#pragma checksum "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Pages\Privacy.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3ee6e59405de897dd8db10b274795d9da2f0effc29ee8805fd2411981e329fb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspnet_shopping_cart.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
namespace aspnet_shopping_cart.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Pages\_ViewImports.cshtml"
using aspnet_shopping_cart

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Pages\Privacy.cshtml"
 using aspnet_shopping_cart.Components

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3ee6e59405de897dd8db10b274795d9da2f0effc29ee8805fd2411981e329fb5", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"244afaa03e3cbb2b7034700201cc4acff5a7c3681fcceae8ca947a7677016b6f", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Pages\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            Write(
#nullable restore
#line 8 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Pages\Privacy.cshtml"
  await Html.RenderComponentAsync<NavComponent>(RenderMode.ServerPrerendered)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n<script src=\"_framework/blazor.server.js\"></script>\r\n\r\n<div class=\"container\">\r\n    <h1>");
            Write(
#nullable restore
#line 12 "C:\Users\Aditya Vikram Sharma\Desktop\personal_projects\aspnet_shopping_cart\aspnet_shopping_cart\Pages\Privacy.cshtml"
         ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n    <p>Use this page to detail your site\'s privacy policy.</p>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

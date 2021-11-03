#pragma checksum "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "712252b54ceb7be7a0d0bbab029600bee18f1997"
// <auto-generated/>
#pragma warning disable 1591
namespace Wepshop.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/_Imports.razor"
using Wepshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/_Imports.razor"
using Wepshop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
using Wepshop.Classes;

#line default
#line hidden
#nullable disable
    public partial class ProductCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-sm-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card my-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-6");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title");
            __builder.AddContent(12, 
#nullable restore
#line 8 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
                                            prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "card-text");
            __builder.AddContent(16, 
#nullable restore
#line 9 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
                                          prod.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "card-text");
            __builder.AddContent(20, 
#nullable restore
#line 10 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
                                          prod.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " kr");
            __builder.CloseElement();
#nullable restore
#line 11 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
                     if (prod.Vendor != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "class", "card-text");
            __builder.AddContent(24, 
#nullable restore
#line 13 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
                                              prod.Vendor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-6");
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "class", "img-fluid");
            __builder.AddAttribute(30, "src", "img/products/" + (
#nullable restore
#line 17 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
                                                              prod.SKU

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "alt", 
#nullable restore
#line 17 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
                                                                              prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "card-footer text-muted");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "class", "btn btn-info");
            __builder.AddAttribute(37, "href", "Details/" + (
#nullable restore
#line 22 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
                                                   prod.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\n                Se mere\n                <i class=\"fas fa-info-circle\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n            ");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "class", "btn btn-success");
            __builder.AddAttribute(42, "href", "FetchData");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
                                                                  () => MainLayout.AddToCart(prod.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\n                Tilføj til kurv\n                <i class=\"fas fa-shopping-basket\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/ProductCard.razor"
 
    [Parameter] public ProductDTO prod { get; set; }
    [CascadingParameter] MainLayout MainLayout { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

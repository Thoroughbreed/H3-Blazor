#pragma checksum "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68af8ad8f1587386ff9b752dd0549896c1749054"
// <auto-generated/>
#pragma warning disable 1591
namespace Wepshop.Pages
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
#line 2 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
using Wepshop.Classes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cart</h3>");
#nullable restore
#line 5 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
 if (MainLayout.CartItems.Count() > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
#nullable restore
#line 8 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
         foreach (var item in MainLayout.CartItems)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "tr");
            __builder.OpenElement(4, "td");
            __builder.OpenElement(5, "a");
            __builder.AddAttribute(6, "href", "Cart");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
                                             () => MainLayout.RemoveAmount(item._ProductID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "<i class=\"oi oi-x\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                    ");
            __builder.AddContent(10, 
#nullable restore
#line 15 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
                     MainLayout.Products.FirstOrDefault(p => p.Id == @item._ProductID).Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "class", "text-center");
            __builder.AddContent(14, 
#nullable restore
#line 17 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
                                         MainLayout.Products.FirstOrDefault(p => p.Id == @item._ProductID).Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "class", "text-center");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "Cart");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
                                             () => MainLayout.SubAmount(item._ProductID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<i class=\"oi oi-minus\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.AddContent(23, 
#nullable restore
#line 22 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
                     item._Amount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "Cart");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
                                             () => MainLayout.AddAmount(item._ProductID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "<i class=\"oi oi-plus\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "class", "text-center");
            __builder.AddContent(32, 
#nullable restore
#line 28 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
                      $"{@item._LinePrice:C}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n    ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", "Cart");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
                             MainLayout.ClearBasket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", "btn btn-danger");
            __builder.AddContent(38, "Empty basket ...");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n    ");
            __builder.AddMarkupContent(40, "<a href=\"Checkout\" class=\"btn btn-success\">Checkout!</a>");
#nullable restore
#line 35 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<h3>Awwwww, your cart is empty *sadface*</h3>");
#nullable restore
#line 39 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Cart.razor"
       
    private List<OrderItemsDTO> ShoppingCart { get; } = new List<OrderItemsDTO>();
    public OrderDTO Order { get; set; }
    public CustomerDTO Customer { get; set; }


    private List<CartOrderItems> CartOrderItems { get; set; }

    [CascadingParameter]
    protected MainLayout MainLayout { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

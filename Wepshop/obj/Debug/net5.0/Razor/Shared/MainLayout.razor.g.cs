#pragma checksum "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "413aef8ddcdbf335a552e42cb1d64de29e8b67da"
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
#line 1 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
using Wepshop.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-ra7cge8npq");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-ra7cge8npq");
            __builder.OpenComponent<Wepshop.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-ra7cge8npq");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-ra7cge8npq");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", "cart");
            __builder.AddAttribute(16, "class", "ml-md-auto" + " " + (
#nullable restore
#line 11 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
                                              _colour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-ra7cge8npq");
            __builder.AddContent(18, 
#nullable restore
#line 12 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
                 CartAmount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, " <i class=\"oi oi-basket\" b-ra7cge8npq></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "content px-4");
            __builder.AddAttribute(23, "b-ra7cge8npq");
            __Blazor.Wepshop.Shared.MainLayout.TypeInference.CreateCascadingValue_0(__builder, 24, 25, 
#nullable restore
#line 17 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
                                   this

#line default
#line hidden
#nullable disable
            , 26, (__builder2) => {
                __builder2.AddContent(27, 
#nullable restore
#line 18 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                );
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "id", "toaster");
            __builder.AddAttribute(31, "class", 
#nullable restore
#line 21 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
                                  _hideNseek

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "b-ra7cge8npq");
            __builder.AddContent(33, 
#nullable restore
#line 21 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
                                               _item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " ");
            __builder.AddContent(35, 
#nullable restore
#line 21 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
                                                      _msg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
 
    public List<CartOrderItems> CartItems { get; set; } = new();
    public List<ProductDTO> Products { get; set; } = new();
    private int CartAmount { get; set; }
    private Timer _timer { get; } = new(3000); // Time the toaster is visible
    
    // Styling ish fields. 
    // _colour sets the background colour of the basket icon in upper right corner
    // _hideNseek is controlling the class of the toaster DIV and _item is the current item in the toaster
    private string _hideNseek { get; set; } = ""; // class for the toaster is blank until the method is called
    private string _item { get; set; } = "Defaulting to default value"; // if no text is sent to the toaster
    private string _msg { get; set; } = "er tilføjet til kurven :)"; // default value
    private string _colour { get; set; } = "btn btn-warning";
    
    public void AddToCart(int id)
    {
        if (CartItems.FirstOrDefault(c => c._ProductID == id) != null)
        {
            CartOrderItems cartItem = CartItems.First(c => c._ProductID == id);
            cartItem._Amount++;
            cartItem._LinePrice = Products.Find(p => p.Id == id).Price * cartItem._Amount;
        }
        else
        {
            CartItems.Add(new CartOrderItems
            {
                _ProductID = id,
                _LinePrice = Products.First(p => p.Id == id).Price,
                _Amount = 1
            });
        }
        CartAmount = CartItems.Sum(a => a._Amount);
        ShopPop(Products.FirstOrDefault(p => p.Id == id)?.Name);
        _colour = "btn btn-success";
    }

    public void AddAmount(int id)
    {
        CartOrderItems cartItem = CartItems.FirstOrDefault(c => c._ProductID == id);
        if (cartItem != null)
        {
            cartItem._Amount++;
            cartItem._LinePrice = Products.Find(p => p.Id == id).Price * cartItem._Amount;
        }
        CartAmount = CartItems.Sum(a => a._Amount);
        _colour = "btn btn-success";
    }

    public void SubAmount(int id)
    {
        CartOrderItems cartItem = CartItems.FirstOrDefault(c => c._ProductID == id);
        if (cartItem != null && cartItem._Amount == 1)
        {
            RemoveAmount(id);
        }
        else
        {
            if (cartItem != null)
            {
                cartItem._Amount--;
                cartItem._LinePrice = Products.Find(p => p.Id == id).Price * cartItem._Amount;
            }
        }
        CartAmount = CartItems.Sum(a => a._Amount);
        if (CartAmount < 1)
        {
            _colour = "btn btn-warning";
        }
    }

    public void RemoveAmount(int id)
    {
        var temp = CartItems.FirstOrDefault(c => c._ProductID == id);
        CartItems.Remove(temp);
        CartAmount = CartItems.Sum(a => a._Amount);
        if (CartAmount < 1)
        {
            _colour = "btn btn-warning";
        }
    }

    public void ClearBasket()
    {
        CartItems.Clear();
        CartAmount = 0;
        _colour = "btn btn-warning";
    }
    
    // Parameter p is the product name (or other string) that the toaster is supposed to show
    private void ShopPop(string p)
    {
        _item = p;
        _hideNseek = "show";
        _timer.Elapsed += OnTimedEvent;
        _timer.Enabled = true;
    }
    
    // When the timer lapses, the class variable is set to not-show (or any other thing other than show) and the timer stops
    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        _hideNseek = "I TOLD YOU SO!";
        StateHasChanged();
        _timer.Enabled = false;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Wepshop.Shared.MainLayout
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

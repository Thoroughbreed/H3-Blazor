// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using Wepshop.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/MainLayout.razor"
 
    public List<CartOrderItems> CartItems { get; set; } = new List<CartOrderItems>();
    public List<ProductDTO> Products { get; set; } = new List<ProductDTO>();
    private int CartAmount { get; set; } = 0;
    private string _colour { get; set; } = "btn btn-warning";


    public void AddToCart(int id)
    {
        if (CartItems.FirstOrDefault(c => c._ProductID == id) != null)
        {
            CartOrderItems cartItem = CartItems.First(c => c._ProductID == id);
            cartItem._Amount++;
            cartItem._LinePrice = (Products.Find(p => p.Id == id).Price * cartItem._Amount);
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
        _colour = "btn btn-success";
    }

    public void AddAmount(int id)
    {
        CartOrderItems cartItem = CartItems.FirstOrDefault(c => c._ProductID == id);
        cartItem._Amount++;
        cartItem._LinePrice = (Products.Find(p => p.Id == id).Price * cartItem._Amount);
        CartAmount = CartItems.Sum(a => a._Amount);
        _colour = "btn btn-success";
    }

    public void SubAmount(int id)
    {
        CartOrderItems cartItem = CartItems.FirstOrDefault(c => c._ProductID == id);
        if (cartItem._Amount == 1)
        {
            RemoveAmount(id);
        }
        else
        {
            cartItem._Amount--;
            cartItem._LinePrice = (Products.Find(p => p.Id == id).Price * cartItem._Amount);
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
        _colour = "btn btn-warning";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

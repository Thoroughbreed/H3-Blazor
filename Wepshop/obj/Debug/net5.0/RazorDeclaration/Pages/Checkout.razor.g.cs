// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Wepshop.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
using Wepshop.Classes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Checkout")]
    public partial class Checkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
       
    private CustomerDTO[] _custArr;
    private CustomerDTO _cust = new();
    private OrderDTO _order { get; set; }
    private OrderDTO[] _orders { get; set; }
    private EditContext EditContext = new(new CustomerDTO());
    private string DebugMsg;

    [CascadingParameter]
    protected MainLayout MainLayout { get; set; }

    [Parameter]
    public int CustID { get; set; } = 8; // Hardcoded test value

    protected override async Task OnInitializedAsync()
    {
        _custArr = await _http.GetFromJsonAsync<CustomerDTO[]>($"https://192.168.236.142:5001/Shop/Customers?search=api");
        await base.OnInitializedAsync();
        _cust = _custArr[0];
        EditContext = new EditContext(_cust);
    }

    private async Task OnValidSubmit()
    {
        _orders = new OrderDTO[MainLayout.CartItems.Count];
        foreach (var item in MainLayout.CartItems)
        {
            _orders[MainLayout.CartItems.IndexOf(item)] = new OrderDTO
            {
                Amount = item._Amount,
                Product = item._ProductID,
                CustomerId = _cust.id,
                LinePrice = item._LinePrice
            };
        }

        if (_cust.orders < 1)
        {
            _cust.orders = 1;
        }
        else
        {
            _cust.orders++;
        }
        await _http.PutAsJsonAsync<CustomerDTO>("https://192.168.236.142:5001/Shop/Customers", _cust);
        var response = await _http.PostAsJsonAsync<OrderDTO[]>("https://192.168.236.142:5001/Shop/Orders", _orders);

        if (response.StatusCode == System.Net.HttpStatusCode.Created)
        {
            MainLayout.CartItems.Clear();
            _nav.NavigateTo($"Success/{response.Content.ReadAsStringAsync()}");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
    }
}
#pragma warning restore 1591

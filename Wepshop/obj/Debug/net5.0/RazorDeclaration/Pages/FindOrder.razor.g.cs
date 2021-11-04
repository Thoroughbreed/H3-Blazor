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
#line 2 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/FindOrder.razor"
using Wepshop.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/FindOrder.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FindOrder")]
    public partial class FindOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/FindOrder.razor"
       
    private string _order { get; set; }
    private OrderDTO _orderResult { get; set; }
    private string DebugMsg { get; set; }
    private List<ProductDTO> _products { get; set; }
    
    [CascadingParameter]
    protected MainLayout MainLayout { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        _products = await _http.GetFromJsonAsync<List<ProductDTO>>($"/Shop/Products");
    }
    
    private async void Search()
    {
        if (_order.Length > 7)
        {
            var _response = await _http.GetAsync($"/Shop/Orders?guid={_order}");
            DebugMsg = _response.ToString();
            if (_response.StatusCode == HttpStatusCode.OK)
            {
                // DebugMsg = await _response.Content.ReadAsStringAsync();
                _orderResult = await _http.GetFromJsonAsync<OrderDTO>($"/Shop/Orders?guid={_order}");
            }
            else
            {
                DebugMsg = $"Sorry, but we couldn't find any order matching the order ID {_order} *sadface*";
                _orderResult = null;
            }
        }
        else
        {
            DebugMsg = "You have to input all 8 chars of your order ID";
            _orderResult = null;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
    }
}
#pragma warning restore 1591

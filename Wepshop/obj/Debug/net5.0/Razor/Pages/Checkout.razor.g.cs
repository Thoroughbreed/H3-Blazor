#pragma checksum "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a5b8d31d18e1165b666f2c02f5df7c0b4ecfe06"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, 
#nullable restore
#line 6 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
    DebugMsg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\n");
            __builder.AddMarkupContent(3, "<h3>Show me your creditcard!</h3>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 8 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
                        EditContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
                                                     OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label for=\"InputName\">Name: </label>\n        ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "id", "InputName");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
                                        _cust.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _cust.name = __value, _cust.name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n\n    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "<label for=\"InputName\">Address: </label>\n        ");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "type", "text");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "id", "InputName");
                __builder2.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
                                        _cust.address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _cust.address = __value, _cust.address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label for=\"InputName\">Zip & City: </label>\n        ");
                __builder2.OpenElement(35, "input");
                __builder2.AddAttribute(36, "type", "text");
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "id", "InputName");
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
                                        _cust.city

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _cust.city = __value, _cust.city));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "<label for=\"InputName\">E-Mail: </label>\n        ");
                __builder2.OpenElement(45, "input");
                __builder2.AddAttribute(46, "type", "email");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "id", "InputName");
                __builder2.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
                                         _cust.eMail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _cust.eMail = __value, _cust.eMail));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n\n    ");
                __builder2.AddMarkupContent(52, "<button type=\"submit\" class=\"btn btn-success\">BUY!!!!</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\n");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-success");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Checkout.razor"
                                          OnValidSubmit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Buy ... button?");
            __builder.CloseElement();
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
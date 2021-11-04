#pragma checksum "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6114cf2c2d75042664049d45099277015cd756d8"
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
#line 3 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
using Wepshop.Classes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Details/{Id:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Details</h3>");
#nullable restore
#line 7 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
 if (_prod != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-8");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card my-8");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-6");
            __builder.OpenElement(13, "h5");
            __builder.AddAttribute(14, "class", "card-title");
            __builder.AddContent(15, 
#nullable restore
#line 16 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
                                                    _prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                            ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "card-text");
            __builder.AddContent(19, 
#nullable restore
#line 17 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
                                                  _prod.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                            ");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "card-text");
            __builder.AddContent(23, 
#nullable restore
#line 18 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
                                                   $"{_prod.Price:C}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
                             if (_prod.Vendor != "")
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "card-text");
            __builder.AddContent(26, 
#nullable restore
#line 21 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
                                                      _prod.Vendor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-6");
            __builder.OpenElement(30, "img");
            __builder.AddAttribute(31, "class", "img-fluid");
            __builder.AddAttribute(32, "src", "img/products/" + (
#nullable restore
#line 25 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
                                                                      _prod.SKU

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "alt", 
#nullable restore
#line 25 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
                                                                                       _prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "card-footer text-muted");
            __builder.AddMarkupContent(37, "<a class=\"btn btn-info\" href=\"FetchData\">\n                        Tilbage\n                        <i class=\"fas fa-info-circle\"></i></a>\n                    ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "class", "btn btn-success");
            __builder.AddAttribute(40, "href", "Details/" + (
#nullable restore
#line 34 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
                                                              _prod.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
                                                                                  () => MainLayout.AddToCart(_prod.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\n                        Tilføj til kurv\n                        <i class=\"fas fa-shopping-basket\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<h3>Product not found ....</h3>");
#nullable restore
#line 46 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Details.razor"
       

    [Parameter]
    public int Id { get; set; }
    [CascadingParameter]
    MainLayout MainLayout { get; set; }

    private ProductDTO _prod;

    protected override async Task OnInitializedAsync()
    {
        // _prod = await _http.GetFromJsonAsync<ProductDTO>($"https://192.168.236.142:5001/Shop/Products?search={Id}");
        _prod = await _http.GetFromJsonAsync<ProductDTO>($"/Shop/Products?search={Id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
    }
}
#pragma warning restore 1591

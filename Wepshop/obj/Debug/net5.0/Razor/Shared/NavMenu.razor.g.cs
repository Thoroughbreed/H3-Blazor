#pragma checksum "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d777624677e7742b275646b8f0ebd6f42b4a2ac3"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-2mcnv6yapz");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-2mcnv6yapz>Wepshop</a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-2mcnv6yapz");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-2mcnv6yapz></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-2mcnv6yapz");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-2mcnv6yapz");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-2mcnv6yapz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-bullhorn\" aria-hidden=\"true\" b-2mcnv6yapz></span> Shop\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item px-3");
            __builder.AddAttribute(28, "b-2mcnv6yapz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "cart");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "<span class=\"oi oi-basket\" aria-hidden=\"true\" b-2mcnv6yapz></span> Cart\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n        <hr b-2mcnv6yapz>\n        ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav-item px-3");
            __builder.AddAttribute(37, "b-2mcnv6yapz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", "FindOrder");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "<span class=\"oi oi-magnifying-glass\" b-2mcnv6yapz></span> Find order\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Shared/NavMenu.razor"
       
    private bool _collapseNavMenu = true;
    private string NavMenuCssClass => _collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        _collapseNavMenu = !_collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

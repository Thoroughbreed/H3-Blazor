#pragma checksum "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8a286bc3180c96c0e21102438902c71840e172"
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
#line 2 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
using System.Xml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
using Wepshop.Classes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Calculator</h1>\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
              _inputA

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _inputA = __value, _inputA));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(4, " ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
                                       _inputB

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _inputB = __value, _inputB));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Result: ");
            __builder.AddContent(11, 
#nullable restore
#line 8 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
            _calculateResult

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
                                          ()=>Calculate('+')

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "+");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
                                          ()=>Calculate('-')

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "-");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-primary");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
                                          ()=>Calculate('*')

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "*");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
                                          ()=>Calculate('/')

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "/");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
                                          ()=>Calculate('M')

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Mod");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "/Users/janandreasen/RiderProjects/BlazorWebshop/Wepshop/Pages/Counter.razor"
       
    private string _calculateResult;
    private string _inputA;
    private string _inputB;
    private decimal _result;

    private void Calculate(char c)
    {
        try
        {
            if (c  == '+')
            {
                _calculateResult = _inputA + _inputB;
            }
            else
            {
                decimal A = Convert.ToDecimal(_inputA);
                decimal B = Convert.ToDecimal(_inputB);
                
                switch (@c)
                {
                    case '+':
                        _result = A + B;
                        _calculateResult = _result.ToString();
                        break;
                    case '-':
                        _result = A - B;
                        _calculateResult = _result.ToString();
                        break;
                    case '*':
                        _result = A * B;
                        _calculateResult = _result.ToString();
                        break;
                    case '/':
                        if (B == 0)
                        {
                            _calculateResult = "You can't divide by zero you dumb fuck ...";
                            break;;
                        }
                        _result = A / B;
                        _calculateResult = _result.ToString();
                        break;
                    case 'M':
                        if (B == 0)
                        {
                            _calculateResult = "You can't divide by zero you dumb fuck ...";
                            break;
                        }
                        _result = A % B;
                        _calculateResult = _result.ToString();
                        break;
                    default:
                        break;
                }
            }
        }
        catch (Exception)
        {
            _calculateResult = "Input only numbers you retarded dipshit!";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\nelson\Documents\Code\BlazorServerApp\Pages\ParametersSite.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d84aca8c9a9d2ae17b4dec2746d80702e516f65"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nelson\Documents\Code\BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nelson\Documents\Code\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nelson\Documents\Code\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nelson\Documents\Code\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nelson\Documents\Code\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nelson\Documents\Code\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nelson\Documents\Code\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nelson\Documents\Code\BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nelson\Documents\Code\BlazorServerApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nelson\Documents\Code\BlazorServerApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nelson\Documents\Code\BlazorServerApp\Pages\ParametersSite.razor"
using BlazorServerApp.Shared.cTabSet;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ParametersSite")]
    public partial class ParametersSite : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorServerApp.Shared.cTabSet.TabSet>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorServerApp.Shared.cTabSet.Tab>(2);
                __builder2.AddAttribute(3, "Title", "Generales");
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "<h4>Propiedades Globales de la Aplicaion Web</h4>\r\n\r\n        ");
                    __builder3.OpenElement(6, "label");
                    __builder3.OpenElement(7, "input");
                    __builder3.AddAttribute(8, "type", "checkbox");
                    __builder3.AddAttribute(9, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\nelson\Documents\Code\BlazorServerApp\Pages\ParametersSite.razor"
                                          showThirdTab

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => showThirdTab = __value, showThirdTab));
                    __builder3.SetUpdatesAttributeName("checked");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(11, "\r\n            Toggle third tab\r\n        ");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<BlazorServerApp.Shared.cTabSet.Tab>(13);
                __builder2.AddAttribute(14, "Title", "Conexion");
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "<h5>Parametros de Conexion a la base de datos.</h5>");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 18 "C:\Users\nelson\Documents\Code\BlazorServerApp\Pages\ParametersSite.razor"
     if (showThirdTab)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<BlazorServerApp.Shared.cTabSet.Tab>(17);
                __builder2.AddAttribute(18, "Title", "Usuarios");
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "<h4>Welcome to the disappearing third tab!</h4>\r\n            ");
                    __builder3.AddMarkupContent(21, "<p>Toggle this tab from the first tab.</p>");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 24 "C:\Users\nelson\Documents\Code\BlazorServerApp\Pages\ParametersSite.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\nelson\Documents\Code\BlazorServerApp\Pages\ParametersSite.razor"
       
    private bool showThirdTab = true;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

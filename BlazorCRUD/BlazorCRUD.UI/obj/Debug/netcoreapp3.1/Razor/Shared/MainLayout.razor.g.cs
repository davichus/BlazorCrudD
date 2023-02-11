#pragma checksum "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbdd2fff5e887a1099c90651815f4acf8aaf9313"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/_Imports.razor"
using BlazorCRUD.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/_Imports.razor"
using BlazorCRUD.UI.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<global::BlazorCRUD.UI.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4");
            __builder.AddMarkupContent(11, "\n        ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", "");
            __builder.AddAttribute(14, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Shared/MainLayout.razor"
                             Salir

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Salir");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content px-4");
            __builder.AddMarkupContent(20, "\n        ");
#nullable restore
#line 14 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Shared/MainLayout.razor"
__builder.AddContent(21, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Shared/MainLayout.razor"
       
    protected async Task Salir()
    {
        await sessionStorage.SetItemAsync("Usuario", "");
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
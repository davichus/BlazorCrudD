#pragma checksum "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "341f23ab2d4e51412019e8c76b889c3a05a62a9b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.UI.Pages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Inicio")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n");
            __builder.OpenComponent<global::BlazorCRUD.UI.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/Index.razor"
 
    string usuario;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            usuario = await sessionStorage.GetItemAsync<string>("Usuario");
            if (usuario != null)
            {

            }
            else
            {
                NavigationManager.NavigateTo("/");
            }
        }
        catch (Exception ex)
        {
            NavigationManager.NavigateTo("/");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591

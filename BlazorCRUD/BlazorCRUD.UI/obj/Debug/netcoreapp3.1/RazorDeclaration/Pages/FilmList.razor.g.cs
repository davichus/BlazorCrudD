// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmList.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmList.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/filmlist")]
    public partial class FilmList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmList.razor"
       

    private IEnumerable<Film> films;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            films = await FilmService.GetAllFilms();
        }
        catch (Exception)
        {
            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFilmService FilmService { get; set; }
    }
}
#pragma warning restore 1591
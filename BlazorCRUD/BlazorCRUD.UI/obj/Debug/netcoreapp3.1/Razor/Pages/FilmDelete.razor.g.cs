#pragma checksum "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "099c0866ff39b69f858b6a771b8ddfabe49ce553"
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
#nullable restore
#line 2 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmDelete.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmDelete.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/filmdelete/{id:int}")]
    public partial class FilmDelete : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Film Delete</h1>\n");
            __builder.AddMarkupContent(1, "<p style=\"color:red; text-align:center\">Are you sure you want to delete this film?</p>\n\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 10 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmDelete.razor"
                  film

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenElement(6, "table");
                __builder2.AddAttribute(7, "class", "table");
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.OpenElement(9, "tr");
                __builder2.AddMarkupContent(10, "\n            ");
                __builder2.AddMarkupContent(11, "<td>Title:</td>\n            ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, " ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmDelete.razor"
                                           film.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.Title = __value, film.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddContent(18, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.OpenElement(21, "tr");
                __builder2.AddMarkupContent(22, "\n            ");
                __builder2.AddMarkupContent(23, "<td>Director:</td>\n            ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, " ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "text");
                __builder2.AddAttribute(28, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmDelete.razor"
                                           film.Director

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.Director = __value, film.Director));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddContent(30, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n        ");
                __builder2.OpenElement(33, "tr");
                __builder2.AddMarkupContent(34, "\n            ");
                __builder2.AddMarkupContent(35, "<td>Release Date:</td>\n            ");
                __builder2.OpenElement(36, "td");
                __builder2.AddContent(37, " ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "text");
                __builder2.AddAttribute(40, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmDelete.razor"
                                           film.ReleaseDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.ReleaseDate = __value, film.ReleaseDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddContent(42, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n        ");
                __builder2.OpenElement(45, "tr");
                __builder2.AddMarkupContent(46, "\n            ");
                __builder2.OpenElement(47, "td");
                __builder2.AddAttribute(48, "colspan", "2");
                __builder2.AddAttribute(49, "style", "text-align:center");
                __builder2.AddMarkupContent(50, "\n                ");
                __builder2.OpenElement(51, "input");
                __builder2.AddAttribute(52, "type", "submit");
                __builder2.AddAttribute(53, "class", "btn btn-warning");
                __builder2.AddAttribute(54, "value", "Delete");
                __builder2.AddAttribute(55, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmDelete.razor"
                                                                                      DeleteFilm

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n                ");
                __builder2.OpenElement(57, "input");
                __builder2.AddAttribute(58, "type", "button");
                __builder2.AddAttribute(59, "class", "btn btn-danger");
                __builder2.AddAttribute(60, "value", "Cancel");
                __builder2.AddAttribute(61, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmDelete.razor"
                                                                                     Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "/Users/davidnavarrete/Projects/BlazorCRUD/BlazorCRUD.UI/Pages/FilmDelete.razor"
       
    Film film = new Film();

    [Parameter]
    public int id { get; set; }

    protected async Task DeleteFilm()
    {
        await FilmService.DeleteFilm(id);
        NavigationManager.NavigateTo("/filmlist");
    }

    protected override async Task OnInitializedAsync()
    {
        film = await FilmService.GetDetails(id);
    }

    protected void Cancel()
    {
        NavigationManager.NavigateTo("/filmlist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFilmService FilmService { get; set; }
    }
}
#pragma warning restore 1591

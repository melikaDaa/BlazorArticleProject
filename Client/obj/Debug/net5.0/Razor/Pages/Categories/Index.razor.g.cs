#pragma checksum "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c640a7d2cd26b0ffebffa2d550a70987e33cc44"
// <auto-generated/>
#pragma warning disable 1591
namespace MyProject.Client.Pages.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using MyProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using MyProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using MyProject.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using MyProject.Shared.DTo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using MyProject.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using MyProject.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using DNTPersianComponents.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using DNTPersianUtils.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\New folder\Blazor\MyProject\Client\_Imports.razor"
using DNTPersianUtils.Core.IranCities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddAttribute(2, "style", "text-align:right;");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
                      SaveMovie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "btn btn-success");
            __builder.AddMarkupContent(6, "جدید");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __Blazor.MyProject.Client.Pages.Categories.Index.TypeInference.CreateGenericList_0(__builder, 8, 9, 
#nullable restore
#line 12 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
                   CateList

#line default
#line hidden
#nullable disable
            , 10, (__builder2) => {
                __builder2.OpenElement(11, "table");
                __builder2.AddAttribute(12, "class", "table table-striped");
                __builder2.AddAttribute(13, "style", "width:50%; font-size:15px;");
                __builder2.AddMarkupContent(14, "<thead style=\"text-align:right\"><tr><th></th>\r\n                    <th>نام</th></tr></thead>");
#nullable restore
#line 24 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
             foreach (var item in CateList)
            {


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(15, "tr");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 28 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
                         item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "td");
                __builder2.OpenElement(20, "a");
                __builder2.AddAttribute(21, "class", "btn btn-warning");
                __builder2.AddAttribute(22, "href", "/genre/edit/" + (
#nullable restore
#line 30 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
                                                                      item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(23, "ویرایش");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "button");
                __builder2.AddAttribute(26, "class", "btn btn-outline-danger");
                __builder2.AddAttribute(27, "data-toggle", "modal");
                __builder2.AddAttribute(28, "data-target", "#deleteEmpModal");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
                                          (()=>DeleteConfirm(item.Id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(30, "<i class=\"fa fa-trash-o\"></i>\r\n                            حذف\r\n                        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 39 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            );
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal fade");
            __builder.AddAttribute(34, "id", "deleteEmpModal");
            __builder.AddAttribute(35, "style", "text-align:right");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-dialog");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal-content");
            __builder.AddMarkupContent(40, "<div class=\"modal-header\" style=\"text-align:center;\"><h3 class=\"modal-title\">تایید حذف </h3>\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\"><span aria-hidden=\"true\" style=\"text-align:left;\">X</span></button></div>\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "modal-body");
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "class", "table");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "<td>نام</td>\r\n                        ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 58 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
                             categories.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-footer");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "class", "btn btn-danger");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
                                                         (async () => await DeleteEmployee(categories.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "data-dismiss", "modal");
            __builder.AddMarkupContent(56, "حذف");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.AddMarkupContent(58, "<button data-dismiss=\"modal\" class=\"btn btn-light\">لغو</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\New folder\Blazor\MyProject\Client\Pages\Categories\Index.razor"
       
    protected HttpClient Http { get; set; }
    List<Categories> CateList;
    public Categories categories = new Categories();

    private void SaveMovie()
    {
        navigationManager.NavigateTo("Category/create");
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            CateList = await genreRepository.GetGenres();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    protected void DeleteConfirm(int id)
    {

        categories = CateList.FirstOrDefault(x => x.Id == id);

    }

    protected async Task DeleteEmployee(int id)
    {

        await genreRepository.DeleteGenre(id);
        await genreRepository.GetGenres();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpService http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository genreRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.MyProject.Client.Pages.Categories.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MyProject.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

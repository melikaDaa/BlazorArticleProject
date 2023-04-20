// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyProject.Client.Pages.Article
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
#line 4 "D:\New folder\Blazor\MyProject\Client\Pages\Article\DetailsArticle.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{ArticleId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{ArticleId:int}/{Title}")]
    public partial class DetailsArticle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\New folder\Blazor\MyProject\Client\Pages\Article\DetailsArticle.razor"
       

    [Parameter]
    public int ArticleId { get; set; }

    [Parameter]
    public string Title { get; set; }

    ArticleDetailsDto model;

    private RenderFragment<Categories> linkGenres = (genre) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "a");
            __builder2.AddAttribute(1, "href", "/category?Id=" + (
#nullable restore
#line 52 "D:\New folder\Blazor\MyProject\Client\Pages\Article\DetailsArticle.razor"
                                                                                      genre.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(2, 
#nullable restore
#line 52 "D:\New folder\Blazor\MyProject\Client\Pages\Article\DetailsArticle.razor"
                                                                                                 genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 52 "D:\New folder\Blazor\MyProject\Client\Pages\Article\DetailsArticle.razor"
                                                                                                               ;

protected async override Task OnInitializedAsync()
{
model = await articleRepository.GetDetailArticleDTO(ArticleId);
}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArticleRepository articleRepository { get; set; }
    }
}
#pragma warning restore 1591
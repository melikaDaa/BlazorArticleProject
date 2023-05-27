#pragma checksum "D:\New folder\Blazor\MyProject\Client\Shared\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40e6273ae33c045015099870fd9626cfd47de7ab"
// <auto-generated/>
#pragma warning disable 1591
namespace MyProject.Client.Shared
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
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example ");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "pagination justify-content-center fixed-bottom");
#nullable restore
#line 3 "D:\New folder\Blazor\MyProject\Client\Shared\Pagination.razor"
        foreach (var link in links)
       {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\New folder\Blazor\MyProject\Client\Shared\Pagination.razor"
                           () => SelectedPageInternal(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "Cursor:pointer;");
            __builder.AddAttribute(7, "class", "page-item" + "  " + (
#nullable restore
#line 7 "D:\New folder\Blazor\MyProject\Client\Shared\Pagination.razor"
                                   link.Enabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 7 "D:\New folder\Blazor\MyProject\Client\Shared\Pagination.razor"
                                                                       link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "page-link");
            __builder.AddAttribute(10, "href", "#");
            __builder.AddContent(11, 
#nullable restore
#line 8 "D:\New folder\Blazor\MyProject\Client\Shared\Pagination.razor"
                                               link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "D:\New folder\Blazor\MyProject\Client\Shared\Pagination.razor"
       }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\New folder\Blazor\MyProject\Client\Shared\Pagination.razor"
       

        [Parameter]public int CurrentPage { get; set; } = 1;
        [Parameter]public int TotalPageQuantity { get; set; }
        [Parameter]public int Radius { get; set; } = 3;
        [Parameter]public EventCallback<int> SelectPage { get; set; }
        List<ListModel> links;
    protected override void OnParametersSet()
    {
        LoadPages();
    }

    private async Task SelectedPageInternal(ListModel link)
    {
        if (link.Page == CurrentPage)
        {
            return;
        }
        if (!link.Enabled)
        {
            return;
        }
        CurrentPage = link.Page;
        await SelectPage.InvokeAsync(link.Page);
    }
    private void LoadPages()
    {
        links = new List<ListModel>();
        var isPerviousPageLinkEnabled = CurrentPage != 1;
        var perviousPage = CurrentPage - 1;
        links.Add(new ListModel(perviousPage, isPerviousPageLinkEnabled, "Previous"));
        for (int i = 1; i <= TotalPageQuantity; i++)
        {
            if (i >= CurrentPage - Radius && i <= CurrentPage + Radius)
            {
                links.Add(new ListModel(i) { Active = CurrentPage == i });
            }
        }
        var isNextPageLinkEnabled = CurrentPage != TotalPageQuantity;
        var nextpage = CurrentPage + 1;
        links.Add(new ListModel(nextpage, isNextPageLinkEnabled, "Next"));
    }

    class ListModel
    {
        public ListModel(int page)
            : this(page, true) { }

        public ListModel(int page, bool enable)
            : this(page, enable, page.ToString()) { }

        public ListModel(int page, bool enable, string text)
        {
            Page = page;
            Enabled = enable;
            Text = text;

        }
        public string Text { get; set; }
        public int Page { get; set; }
        public bool Enabled { get; set; } = true;
        public bool Active { get; set; } = false;

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

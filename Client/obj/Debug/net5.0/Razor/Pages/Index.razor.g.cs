#pragma checksum "D:\New folder\Blazor\MyProject\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ff76d5fe2175129b3ba9c8e9777337deef27395"
// <auto-generated/>
#pragma warning disable 1591
namespace MyProject.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<MyProject.Client.Shared.SurveyPrompt>(2);
                __builder2.AddAttribute(3, "Title", "خوش آمدید");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(4, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<MyProject.Client.Shared.SurveyPrompt>(5);
                __builder2.AddAttribute(6, "Title", "برای ثبت مقاله ابتدا وارد شوید");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

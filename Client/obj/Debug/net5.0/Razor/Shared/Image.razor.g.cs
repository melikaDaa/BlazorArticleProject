#pragma checksum "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b5c1d85dec17dbad19d8a14304b53b8a876f91"
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
#nullable restore
#line 1 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class Image : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "file");
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
                                                          ImageFileSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "accept", ".png,jpg,.jpeg");
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 9 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
                                 inputElement = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
 if (ImageBase64 != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "margin-top: 20px");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 17 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
                                               ImageBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "style", "width: 400px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
 if (ImageURL != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "style", "margin-top: 20px");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 26 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
                       ImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "style", "width: 400px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\New folder\Blazor\MyProject\Client\Shared\Image.razor"
       



    [Parameter]
    public string ImageURL { get; set; }

    [Parameter]
    public EventCallback<string> OnSelectedImage { get; set; }

    private string ImageBase64;

    ElementReference inputElement;

    async Task ImageFileSelected()
    {
        foreach (var file in await fileReaderService.CreateReference(inputElement).EnumerateFilesAsync())
        {
            using (MemoryStream memoryStream = await file.CreateMemoryStreamAsync(4 * 1024))
            {
                var imageBytes = new byte[memoryStream.Length];
                memoryStream.Read(imageBytes, 0, (int)memoryStream.Length);
                ImageBase64 = Convert.ToBase64String(imageBytes);
                await OnSelectedImage.InvokeAsync(ImageBase64);
                ImageURL = null;
                StateHasChanged();
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
    }
}
#pragma warning restore 1591

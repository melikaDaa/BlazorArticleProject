#pragma checksum "D:\New folder\Blazor\MyProject\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf2c664e8162fada22845d7249e9be39f268bf56"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"text-align:center; font-style:italic\">ورود</h3>");
#nullable restore
#line 4 "D:\New folder\Blazor\MyProject\Client\Pages\Login.razor"
 if (ShowAuthError)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-danger");
            __builder.AddAttribute(3, "role", "alert");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, 
#nullable restore
#line 7 "D:\New folder\Blazor\MyProject\Client\Pages\Login.razor"
            Error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 9 "D:\New folder\Blazor\MyProject\Client\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\New folder\Blazor\MyProject\Client\Pages\Login.razor"
                 _userForAuthentication

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "D:\New folder\Blazor\MyProject\Client\Pages\Login.razor"
                                                        ExecuteLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group row");
                __builder2.AddAttribute(15, "style", "text-align:right;");
                __builder2.AddMarkupContent(16, "<label for=\"email\" class=\"col-md-2 col-form-label\">:ایمیل</label>\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "email");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\New folder\Blazor\MyProject\Client\Pages\Login.razor"
                                                                    _userForAuthentication.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _userForAuthentication.Email = __value, _userForAuthentication.Email))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _userForAuthentication.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __Blazor.MyProject.Client.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 17 "D:\New folder\Blazor\MyProject\Client\Pages\Login.razor"
                                      () => _userForAuthentication.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group row");
                __builder2.AddAttribute(31, "style", "text-align:right;");
                __builder2.AddMarkupContent(32, "<label for=\"password\" class=\"col-md-2 col-form-label\">رمز عبور:</label>\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "type", "password");
                __builder2.AddAttribute(37, "id", "password");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\New folder\Blazor\MyProject\Client\Pages\Login.razor"
                                                                                       _userForAuthentication.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _userForAuthentication.Password = __value, _userForAuthentication.Password))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _userForAuthentication.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __Blazor.MyProject.Client.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 25 "D:\New folder\Blazor\MyProject\Client\Pages\Login.razor"
                                      () => _userForAuthentication.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\r\n    ");
                __builder2.AddMarkupContent(46, "<div class=\"row\"><div class=\"col-md-12 text-right\" style=\"text-align:right;\"><button type=\"submit\" class=\"btn btn-success\">ورود</button></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.MyProject.Client.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

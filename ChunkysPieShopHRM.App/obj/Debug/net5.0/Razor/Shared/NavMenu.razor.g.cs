#pragma checksum "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e2b7fc53a8cfa08985fd96b2e2658697c49051f"
// <auto-generated/>
#pragma warning disable 1591
namespace ChunkysPieShopHRM.App.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/_Imports.razor"
using ChunkysPieShopHRM.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/_Imports.razor"
using ChunkysPieShopHRM.App.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light");
            __builder.AddAttribute(2, "id", "sidebar-wrapper");
            __builder.AddAttribute(3, "b-xwi6mcnosp");
            __builder.AddMarkupContent(4, "<div class=\"sidebar-logo\" b-xwi6mcnosp><img class=\"img-responsive\" id=\"logo\" src=\"images/bethanylogo.png\" b-xwi6mcnosp></div>\n    ");
            __builder.AddMarkupContent(5, @"<div class=""profile"" b-xwi6mcnosp><div class=""profile-bg"" b-xwi6mcnosp><img class=""img-responsive"" src=""images/profilePicture.jpg"" b-xwi6mcnosp></div>
        <div class=""profile-picture"" b-xwi6mcnosp><img class=""img-responsive circle account-photo"" src=""images/profilePicture.jpg"" b-xwi6mcnosp></div></div>
    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "menu list-group list-group-flush");
            __builder.AddAttribute(8, "b-xwi6mcnosp");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(11, "href", "/");
            __builder.AddAttribute(12, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/Shared/NavMenu.razor"
                                                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-xwi6mcnosp></span> Home\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(16);
            __builder.AddAttribute(17, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(18, "href", "/employeeoverview");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-xwi6mcnosp></span> Employees\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

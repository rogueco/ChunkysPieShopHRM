#pragma checksum "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaa354ca04c2b306d533f1044dd658d10fdb8d76"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex");
            __builder.AddAttribute(2, "id", "wrapper");
            __builder.AddAttribute(3, "b-tsrtay7og5");
            __builder.OpenComponent<ChunkysPieShopHRM.App.Shared.NavMenu>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "id", "page-content-wrapper");
            __builder.AddAttribute(8, "b-tsrtay7og5");
            __builder.AddMarkupContent(9, @"<nav class=""navbar navbar-expand-lg navbar-light border-bottom"" b-tsrtay7og5><div class=""collapse navbar-collapse"" id=""navbarSupportedContent"" b-tsrtay7og5><h3 class=""title"" b-tsrtay7og5>Bethany's Pie Shop HRM </h3>
                <ul class=""navbar-nav ml-auto mt-2 mt-lg-0"" b-tsrtay7og5></ul></div></nav>

        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "container-fluid");
            __builder.AddAttribute(12, "b-tsrtay7og5");
            __builder.AddContent(13, 
#nullable restore
#line 19 "/home/tfletcher/Git/Development/ASP.NET/Pluralsight/BlazorGettingStarted/ChunkysPieShopHRM.App/ChunkysPieShopHRM.App/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

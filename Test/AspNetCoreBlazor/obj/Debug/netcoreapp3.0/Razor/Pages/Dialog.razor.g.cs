#pragma checksum "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\Pages\Dialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1616224c7468814cd1892b2ecb1229cfff934353"
// <auto-generated/>
#pragma warning disable 1591
namespace aspnetcoreblazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\_Imports.razor"
using aspnetcoreblazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\_Imports.razor"
using aspnetcoreblazor.Shared;

#line default
#line hidden
#nullable disable
    public class Dialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "h1");
            __builder.AddContent(3, 
#nullable restore
#line 2 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\Pages\Dialog.razor"
         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.AddContent(5, 
#nullable restore
#line 4 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\Pages\Dialog.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\Pages\Dialog.razor"
                      OnYes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Yes!");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\huangjinlong\Desktop\demo\Test\aspnetcoreblazor\Pages\Dialog.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private void OnYes()
    {
        Console.WriteLine("Write to the console in C#! 'Yes' button was selected.");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

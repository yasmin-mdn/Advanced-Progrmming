#pragma checksum "C:\git\AP98992\Projects\P2\project\myWasm\Pages\History.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "299396bc5dd98c05d8f81da783cac974403a23f8"
// <auto-generated/>
#pragma warning disable 1591
namespace myWasm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using myWasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using myShared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\git\AP98992\Projects\P2\project\myWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\History.razor"
using myShared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\History.razor"
using myShared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ShowHistory/{value}")]
    public partial class History : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(0);
            __builder.AddAttribute(1, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\History.razor"
                        (args) => Click(args)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Text", "show");
            __builder.AddAttribute(3, "style", " position:absolute; left: 987px;top: 89px;background-color: #f9777f;");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n  \r\n  ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(5);
            __builder.AddAttribute(6, "Style", "width:600px;position: absolute;left: 468px;top: 142px;background-color:blanchedalmond; margin-bottom: 20px; height:500px;");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n   ");
                __builder2.OpenElement(9, "div");
                __builder2.OpenElement(10, "p");
                __builder2.AddAttribute(11, "style", "font-size: larger;font-style: italic;");
                __builder2.AddContent(12, "Search history for :  ");
                __builder2.AddContent(13, 
#nullable restore
#line 10 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\History.razor"
                                                                                userservice.user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n");
#nullable restore
#line 11 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\History.razor"
    if(tmp==true){

#line default
#line hidden
#nullable disable
                __builder2.AddContent(15, "   ");
                __builder2.OpenElement(16, "p");
                __builder2.AddAttribute(17, "style", "font-size: larg");
                __builder2.AddContent(18, 
#nullable restore
#line 12 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\History.razor"
                               toshow

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n");
#nullable restore
#line 13 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\History.razor"
   }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(20, "  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\History.razor"
      
   
HttpResponseMessage response= null;
string toshow="";
bool tmp=false;

[Parameter]
public string value{get;set;}
protected override void OnParametersSet()
{
   var t=value;
}  



async void Click(MouseEventArgs args)
 {
      var uri = $"https://localhost:5004/User/SearchHistory/{userservice.user.UserName}";
      try { toshow = await Http.GetStringAsync(uri); 
      tmp=true; }
      catch (Exception e) { System.Console.WriteLine(e.Message);}
       
   }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

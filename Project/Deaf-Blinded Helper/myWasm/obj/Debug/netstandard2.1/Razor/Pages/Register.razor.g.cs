#pragma checksum "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "706dcabe5ec3e6e7cf6c6e1d856865ebe50a5395"
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
#line 1 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Register.razor"
using myShared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Register.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Register.razor"
using myShared.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "Style", "width:600px;position: absolute;left: 197px;top: 100px;height:500px;background-color:#007bff");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.AddMarkupContent(4, "<h1 style=\"position: absolute;left: 25px;top: 30px;color: darkblue;\">Register</h1>\r\n");
                __builder2.AddMarkupContent(5, "<h3 style=\"position: absolute;left:25px;top:163px;color: white;\">Password</h3>\r\n ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPassword>(6);
                __builder2.AddAttribute(7, "Style", "margin-bottom: 20px;position: absolute;left: 125px;top:163px ;width: 450px;");
                __builder2.AddAttribute(8, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 11 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Register.razor"
                                                                                                               args => Changepass(args)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n ");
                __builder2.AddMarkupContent(10, "<h3 style=\"position: absolute;left: 25px;top:110px;color: white;\">Username</h3>\r\n ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(11);
                __builder2.AddAttribute(12, "Style", "margin-bottom: 20px;position: absolute ;left: 125px;top:110px;width: 450px;");
                __builder2.AddAttribute(13, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 13 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Register.razor"
                                                                                                              args => Changeuser(args)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(15);
                __builder2.AddAttribute(16, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Register.razor"
                        (args) => Registermethod()

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "Text", "register");
                __builder2.AddAttribute(18, "Style", "margin-bottom: 20px;width: 121px;position: absolute;left: 433px;top: 405px;background-color:#194b82");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Register.razor"
      
   
    User user2=new User();
     
    HttpResponseMessage response2= null;
    void Changepass(string pass)
    {
      
       user2.PassWord=pass;
       
    }
    void Changeuser(string un)
    {
        user2.UserName=un;
        user2.id=0;
        user2.SearchHistoryString="";
       // userservice.user.UserName=un;
        //userservice.user.SearchHistoryString="";
    }

    private async void Registermethod()
    {   
        userservice.UserServicePass( user2);
        var uri=@"https://localhost:5004/User";
        try{response2= await Http.PostAsJsonAsync(uri,userservice.user);}
       catch(Exception e){System.Console.WriteLine(e.Message);}
         if(response2.Content.ReadAsStringAsync().Result.ToString()=="true"){
            NavigationManager.NavigateTo($"DeafBlindHelper/{userservice.user.UserName}");
        }
        else{
            NavigationManager.NavigateTo("/");
        }
       
    }
    
       
   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
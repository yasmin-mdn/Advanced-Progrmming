#pragma checksum "C:\git\AP98992\Projects\P2\project\myWasm\Pages\AboutUs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6001a2bd66a2183215739485ec254dc99267cca7"
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
#line 1 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\AboutUs.razor"
using myShared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\AboutUs.razor"
using myShared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class AboutUs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"page-header\">\r\n<h1 class=\"Headerstyle\" Style=\"position:absolute; left: 50px;top: 34px;\">Welcome To Deaf-Blind Helper</h1>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(4);
            __builder.AddAttribute(5, "Style", " background-color:#b6e0e7; width: 493px;position:absolute;left: 63px;top: 132px;height: 546px;");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.AddMarkupContent(8, "<div style=\"font-weight: bolder;\">Deaf-blindness is the condition of little or no useful hearing and little or no useful sight.</div>\r\n\r\n    ");
                __builder2.AddMarkupContent(9, "<div style=\"font-weight: bolder;\">some problems a Deaf-blind may face:</div>\r\n\r\n    ");
                __builder2.AddMarkupContent(10, "<div style=\"font-weight: lighter;\">1)Depending on others to feel safe and informed</div>\r\n\r\n    ");
                __builder2.AddMarkupContent(11, "<div style=\"font-weight: lighter;\">2)Learning and using communication strategies</div>\r\n\r\n    ");
                __builder2.AddMarkupContent(12, "<div style=\"font-weight: lighter;\">3)Becoming aware of and navigating their surroundings</div>\r\n\r\n    ");
                __builder2.AddMarkupContent(13, "<div style=\"font-weight: lighter;\">4)Finding social, living and employment situations that fit their individual talents, needs and aspirations</div>\r\n\r\n    ");
                __builder2.AddMarkupContent(14, "<div style=\"font-weight: lighter;\">5)Overcoming barriers that complicate their interactions with non Deaf-Blind people</div>\r\n\r\n    ");
                __builder2.AddMarkupContent(15, "<div style=\"font-weight: bolder;\">We are trying to make it easier to communicate with them by creating a web app that guides us to communicate using tactile sign language</div>\r\n   \r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenImage>(16);
                __builder2.AddAttribute(17, "Path", "tactile.jpg");
                __builder2.AddAttribute(18, "Style", "width:266px;position: absolute;top: 363px;left: 84px;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(21);
            __builder.AddAttribute(22, "style", "background-color:#b6e0e7;position: absolute;top: 134px;left: 615px;width: 474px;");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLogin>(25);
                __builder2.AddAttribute(26, "AllowResetPassword", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\AboutUs.razor"
                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Login", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoginArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoginArgs>(this, 
#nullable restore
#line 34 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\AboutUs.razor"
                     (args) => Login(args)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(28, "Register", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 35 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\AboutUs.razor"
                        (args) => signup()

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(29, "Style", "margin-bottom: 20px;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n");
#nullable restore
#line 36 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\AboutUs.razor"
             if(tmp){

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(31, "<p style=\"color: red;\">You are not registerd!</p>");
#nullable restore
#line 36 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\AboutUs.razor"
                                                                      }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(33);
            __builder.AddAttribute(34, "style", "background-color:#b6e0e7;align-items: center;opacity: 66%;font-size:medium;position: absolute;top: 446px;left: 615px;height: 110px;width: 474px;");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n   ");
                __builder2.AddMarkupContent(37, "<div style=\"font-weight: bold;\"> Contact Us</div>\r\n   ");
                __builder2.AddMarkupContent(38, "<div> email : yasmina.md78@gmail.com</div>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\AboutUs.razor"
      

    User user2=new User();
    HttpResponseMessage response= null;
    bool tmp=false;
    
    
    void  Login(LoginArgs args)
    {
       user2.UserName=args.Username;
       user2.PassWord=args.Password;
       userservice.UserServicePass( user2);
        Loginmethod();
        StateHasChanged();
        
       
    }

    private  void signup()
    {
        NavigationManager.NavigateTo("Register");
    }

     private async void Loginmethod()
    {
        var uri = "https://localhost:5004/User/login";
        try { response = await Http.PostAsJsonAsync(uri,userservice.user); }
        catch (Exception e) { System.Console.WriteLine(e.Message); }
        
        if(response.Content.ReadAsStringAsync().Result.ToString()=="true"){
            NavigationManager.NavigateTo($"DeafBlindHelper/{userservice.user.UserName}");
            tmp=false;
        }
        else{
            tmp=true;
        }
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

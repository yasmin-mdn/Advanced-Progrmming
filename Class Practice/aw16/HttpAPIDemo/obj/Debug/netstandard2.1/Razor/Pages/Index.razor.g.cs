#pragma checksum "C:\git\AP98992\TA\aw16\HttpAPIDemo\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cee112aa4f86097d3447fe8b46ae7320453f3ce"
// <auto-generated/>
#pragma warning disable 1591
namespace HttpAPIDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\git\AP98992\TA\aw16\HttpAPIDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\AP98992\TA\aw16\HttpAPIDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP98992\TA\aw16\HttpAPIDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\AP98992\TA\aw16\HttpAPIDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\AP98992\TA\aw16\HttpAPIDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\AP98992\TA\aw16\HttpAPIDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\AP98992\TA\aw16\HttpAPIDemo\_Imports.razor"
using HttpAPIDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\git\AP98992\TA\aw16\HttpAPIDemo\_Imports.razor"
using HttpAPIDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\git\AP98992\TA\aw16\HttpAPIDemo\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\git\AP98992\TA\aw16\HttpAPIDemo\Pages\Index.razor"
                  CallAPI

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, " call me");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 8 "C:\git\AP98992\TA\aw16\HttpAPIDemo\Pages\Index.razor"
 foreach (var item in dailyreports)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 10 "C:\git\AP98992\TA\aw16\HttpAPIDemo\Pages\Index.razor"
        item.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 11 "C:\git\AP98992\TA\aw16\HttpAPIDemo\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\git\AP98992\TA\aw16\HttpAPIDemo\Pages\Index.razor"
      
    private string Jasonstring {get;set;}="";
    private Dailyreport[] dailyreports;
    private async Task CallAPI(){
      HttpResponseMessage response=null;
        try{
              string uri="https://covid-19-data.p.rapidapi.com/report/totals?date-format=YYYY-MM-DD&format=json&date=2020-04-01";
            var request = new HttpRequestMessage{
            Method=HttpMethod.Get,
            RequestUri=new Uri(uri),
            Headers={
                {"x-rapidapi-host", "covid-19-data.p.rapidapi.com"},
                {"x-rapidapi-key", "df2438bf92msh78ff320d9a4c04cp1594f3jsna64c8366dff5"},
            },
        };
         response=await Http.SendAsync(request);
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        
           this.Jasonstring= response !=null ? await response.Content.ReadAsStringAsync():"Null";
            this.dailyreports=response !=null ? await response.Content.ReadFromJsonAsync<Dailyreport[]>():new Dailyreport[]{};
       
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

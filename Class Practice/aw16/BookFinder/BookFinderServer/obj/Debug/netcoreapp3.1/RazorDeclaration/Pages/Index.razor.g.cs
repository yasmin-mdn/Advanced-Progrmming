#pragma checksum "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84356461ee761b68a16a755bdd1b904e11648214"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookFinderServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\Pages\Index.razor"
using BookFinderServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\Pages\Index.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\git\AP98992\TA\aw16\BookFinder\BookFinderServer\Pages\Index.razor"
          
    private Starship starship = new Starship();
    bool search = false;
    bool analyze = false;
    private List<ChartData> chartDatas=new List<ChartData>();
    private string searchkey = null;
    Book book;

    private void HandleValidSubmit()
    {
        searchkey = starship.Identifier;
    }

    public void Search(){
        book= Finder.FindBook(searchkey);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

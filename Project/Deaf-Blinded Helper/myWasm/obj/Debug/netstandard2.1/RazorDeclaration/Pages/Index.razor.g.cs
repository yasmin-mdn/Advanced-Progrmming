#pragma checksum "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c014d1417dd09c19b85fc9c0fe7b5f6d5f94b76"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace myWasm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 1 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Index.razor"
using myShared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Index.razor"
using myShared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Index.razor"
using myShared.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Index.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Index.razor"
using myWasm.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeafBlindHelper/{myvalue}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\git\AP98992\Projects\P2\project\myWasm\Pages\Index.razor"
       
    HttpResponseMessage response = null;

    private Starship starship = new Starship();
    List<string> DesiredSentence = new List<string>();
    List<char> CurrentWord = new List<char>();
    bool show = false;
    string imagepath = "";
    string Showingword = "";
    int letterindex;
    int wordindex;
    char showingletter = ' ';
    string addingword = "";
    public ((bool p1_On, bool p2_On, bool p3_On) p, (bool palm0_On, bool palm1_On, bool palm2_On, bool palm3_On, bool palm4_On, bool palm5_On, bool palm6_On, bool palm7_On) palm, (bool i1_On, bool i2_On, bool i3_On, bool i4_On, bool i5_On, bool i6_On) i, bool m, bool a, (bool x1_On, bool x2_On) x, bool off) sensorStates;
    private void HandleValidSubmit()
    {
        DesiredSentence = starship.Sentence.ToLower().Split().ToList();
        addingword = starship.Sentence;
        CurrentWord = DesiredSentence[0].ToList();
        Showingword = DesiredSentence[0];
        showingletter = CurrentWord[0];
        letterindex = 0;
        wordindex = 0;
        sensorStates = methodes.CheckForOnSensors(showingletter);
        imagepath = methodes.GetletterImagePath(showingletter);
        show = true;

    }
    void Change() { }
    void ClickPereviousWord(MouseEventArgs args)
    {
        if (DesiredSentence.Count() != 0)
        {
            StateHasChanged();
            letterindex = 0;
            methodes.PreviousWord(DesiredSentence, ref wordindex);
            CurrentWord = DesiredSentence[wordindex].ToList();
            Showingword = DesiredSentence[wordindex];
            showingletter = Showingword[0];
            imagepath = methodes.GetletterImagePath(showingletter);
            sensorStates = methodes.CheckForOnSensors(showingletter);
        }
    }
    void ClickNextWord(MouseEventArgs args)
    {

        if (DesiredSentence.Count() != 0)
        {
            letterindex = 0;
            methodes.NextWord(DesiredSentence, ref wordindex);
            CurrentWord = DesiredSentence[wordindex].ToList();
            Showingword = DesiredSentence[wordindex];
            showingletter = Showingword[0];
            imagepath = methodes.GetletterImagePath(showingletter);
            sensorStates = methodes.CheckForOnSensors(showingletter);
            StateHasChanged();
        }



    }


    void ClickPereviousLetter(MouseEventArgs args)
    {
        if (DesiredSentence.Count() != 0)
        {
            StateHasChanged();
            methodes.PreviousLetter(CurrentWord, ref letterindex);
            showingletter = CurrentWord[letterindex];
            imagepath = methodes.GetletterImagePath(showingletter);
            sensorStates = methodes.CheckForOnSensors(showingletter);
        }
    }
    void ClickNextLettter(MouseEventArgs args)
    {
        if (DesiredSentence.Count() != 0)
        {
            StateHasChanged();
            methodes.NextLetter(CurrentWord, ref letterindex);
            showingletter = CurrentWord[letterindex];
            sensorStates = methodes.CheckForOnSensors(showingletter);
            imagepath = methodes.GetletterImagePath(showingletter);
        }
    }
    void ClickHistory(MouseEventArgs args)
    {
        NavigationManager.NavigateTo($"/ShowHistory/{userservice.user.UserName}");
    }
    async void ClickAddHistory(string st)
    {
        var uri = $"https://localhost:5004/User/AddHistory/{st}";
        try { response = await Http.PostAsJsonAsync(uri, st); }
        catch (Exception e) { System.Console.WriteLine(e.Message); }

    }


    [Parameter]
    public string myvalue { get; set; }
    protected override void OnParametersSet()
    {
        //the param will be set 
        var test = myvalue;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

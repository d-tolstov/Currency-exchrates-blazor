#pragma checksum "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02554a6f4979082184ddb785b168ae7da503fb82"
// <auto-generated/>
#pragma warning disable 1591
namespace CurrExch.NB.Info.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\_Imports.razor"
using CurrExch.NB.Info;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\_Imports.razor"
using CurrExch.NB.Info.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<h1>API курсов валют</h1>

На данном сайте вы сможете найти ссылки на API получения курсов валют национальных банков нескольких стран.<br>
Какие-то банки позволяют получить курсы на явно указанную дату, какие-то только на текущую.<br>
Формат возвращаемых данных тоже различный - json, xml, xlsx.<br>

");
            __builder.OpenComponent<CurrExch.NB.Info.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
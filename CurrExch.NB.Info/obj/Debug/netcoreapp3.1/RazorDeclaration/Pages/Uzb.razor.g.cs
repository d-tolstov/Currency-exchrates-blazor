#pragma checksum "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Uzb.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "878b2d4604b07a5f71bb2f536ed0ec654bdf932e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 3 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Uzb.razor"
using CurrExch.NB.Info.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/uzb")]
    public partial class Uzb : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Uzb.razor"
           
        private void RefreshExchRates()
        {
            countryService.CalcExchRateListByDate();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UzbCurrencyExchRateService countryService { get; set; }
    }
}
#pragma warning restore 1591

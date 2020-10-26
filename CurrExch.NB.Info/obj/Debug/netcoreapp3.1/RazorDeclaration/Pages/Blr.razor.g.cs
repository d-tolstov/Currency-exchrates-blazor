#pragma checksum "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9006f9625d85a49f9337c6585b47a75b0ccede82"
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
#line 3 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
using CurrExch.NB.Info.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blr")]
    public partial class Blr : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
       
    private string dateStr;

    protected override void OnInitialized()
    {
        dateStr = countryService.GetRequestDateStr();
    }

    private void RefreshExchRates()
    {
        DateTime exchRateDate;

        if (!DateTime.TryParse(dateStr, out exchRateDate))
        {
            throw new Exception($"Не удалось преобразовать в дату строку '{dateStr}'");
        }

        countryService.CalcExchRateListByDate(exchRateDate);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlrCurrencyExchRateService countryService { get; set; }
    }
}
#pragma warning restore 1591

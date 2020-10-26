#pragma checksum "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9006f9625d85a49f9337c6585b47a75b0ccede82"
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
            __builder.AddMarkupContent(0, "<h3>Курсы валют с сайта центрального банка республики Беларусь</h3>\r\n");
            __builder.AddMarkupContent(1, "<h5>Формат ссылки для скачивания:</h5>\r\n");
            __builder.AddMarkupContent(2, "<pre>\r\nhttp://www.nbrb.by/Services/XmlExRates.aspx?ondate=%MM%/%DD%/%YYYY%\r\nгде :\r\n%MM% - месяц\r\n%DD% - день\r\n%YYYY% - год\r\n</pre>\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "input-group mb-3");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "input-group-prepend");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                                                                          RefreshExchRates

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "placeholder", "Введите дату, например 19/08/1993");
            __builder.AddAttribute(20, "aria-label", "");
            __builder.AddAttribute(21, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                                                   dateStr

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dateStr = __value, dateStr));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "container");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 24 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
     if (countryService.AlreadyLaunched)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.OpenElement(30, "pre");
            __builder.AddMarkupContent(31, "\r\n            Дата курса из источника : ");
            __builder.AddContent(32, 
#nullable restore
#line 27 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                                       countryService.GetRateDateStr()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.AddContent(35, "        ");
            __builder.OpenElement(36, "table");
            __builder.AddAttribute(37, "class", "table table-sm table-striped");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.AddMarkupContent(39, @"<thead>
                <tr>
                    <th>Id</th>
                    <th>NumCode</th>
                    <th>CharCode</th>
                    <th>Scale</th>
                    <th>Name</th>
                    <th>Rate</th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(40, "tbody");
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 42 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                 foreach (var exchRate in countryService.ExchRates)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                    ");
            __builder.OpenElement(43, "tr");
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 45 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                             exchRate.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 46 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                             exchRate.NumCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 47 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                             exchRate.IsoCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "align", "right");
            __builder.AddContent(56, 
#nullable restore
#line 48 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                                           exchRate.Nominal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 49 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                             exchRate.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "td");
            __builder.AddAttribute(62, "align", "right");
            __builder.AddContent(63, 
#nullable restore
#line 50 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                                           exchRate.Rate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 52 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 55 "C:\Users\dtolstov\source\repos\CurrExch.NB.Info\CurrExch.NB.Info\Pages\Blr.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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

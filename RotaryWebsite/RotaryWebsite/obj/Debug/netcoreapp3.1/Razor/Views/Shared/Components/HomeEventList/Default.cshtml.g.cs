#pragma checksum "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d60791d7b2a192efb0640b43446a5cd8d1330b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomeEventList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HomeEventList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\_ViewImports.cshtml"
using RotaryWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\_ViewImports.cshtml"
using RotaryWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d60791d7b2a192efb0640b43446a5cd8d1330b", @"/Views/Shared/Components/HomeEventList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392fdfb2defe746a147c96eab23595a37e467da7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HomeEventList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"r-upcoming-container\">\r\n    <div class=\"card shadow-sm\">\r\n        <div class=\"card-header r-gallery-title\">\r\n            Upcoming Events\r\n        </div>\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 8 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml"
             foreach (var item in Model.Take(2))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"r-upcoming-sec\">\r\n                    <div class=\"row no-gutters\">\r\n                        <div class=\"col-md-3 r-upcoming-img\">\r\n");
#nullable restore
#line 13 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml"
                             if (string.IsNullOrEmpty(@item.eventimage))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img src=\"http://rotaryclubgudur.org/images/eventdefaultimage.png\" class=\"card-img\">\r\n");
#nullable restore
#line 16 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 811, "\"", 833, 1);
#nullable restore
#line 19 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml"
WriteAttributeValue("", 817, item.eventimage, 817, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\">\r\n");
#nullable restore
#line 20 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"col-md-9 r-upcoming-info\">\r\n                            <p class=\"r-upcoming-title\">");
#nullable restore
#line 23 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml"
                                                   Write(item.eventtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"r-upcoming-meta\">");
#nullable restore
#line 24 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml"
                                                  Write(item.venue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"r-upcoming-meta\">");
#nullable restore
#line 25 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml"
                                                  Write(Convert.ToDateTime(@item.date).ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml"
                                                                                                         Write(item.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 29 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\HomeEventList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\BULLETIN\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9adbee8f6b6bc86fbac92fc1609c7535bf7c686c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BULLETIN_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BULLETIN/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9adbee8f6b6bc86fbac92fc1609c7535bf7c686c", @"/Views/Shared/Components/BULLETIN/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392fdfb2defe746a147c96eab23595a37e467da7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BULLETIN_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BulletinModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""r-bulletin-container"">
    <div class=""r-main-heading d-flex justify-content-center""><span>Bulletin</span></div>
    <div class=""r-bulletin-sec"">
        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""r-bulletin"">
                    <tbody>
                        <tr>
                            <th>BULLETIN</th>
                            <th>ISSUE MONTH</th>
                        </tr>
");
#nullable restore
#line 14 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\BULLETIN\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 646, "\"", 670, 1);
#nullable restore
#line 17 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\BULLETIN\Default.cshtml"
WriteAttributeValue("", 653, item.bulletinurl, 653, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 17 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\BULLETIN\Default.cshtml"
                                                                           Write(item.bulletinname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td style=\"vertical-align:middle;\">");
#nullable restore
#line 18 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\BULLETIN\Default.cshtml"
                                                              Write(item.bulletindate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 20 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Shared\Components\BULLETIN\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BulletinModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

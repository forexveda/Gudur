#pragma checksum "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\PastLeader\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23928986d8a21c2d20c20fa2d4d0d5736469c006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PastLeader_Index), @"mvc.1.0.view", @"/Views/PastLeader/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23928986d8a21c2d20c20fa2d4d0d5736469c006", @"/Views/PastLeader/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392fdfb2defe746a147c96eab23595a37e467da7", @"/Views/_ViewImports.cshtml")]
    public class Views_PastLeader_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PastLeadersModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\PastLeader\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""r-leaders-container"">
    <div class=""r-main-heading d-flex justify-content-center""><span> Past Leaders of Rotary Club Gudur </span></div>
    <div class=""r-leaders-sec"">
        <table class=""r-leaders"">
            <tbody>
                <tr>
                    <th>YEAR</th>
                    <th>PRESIDENT</th>
                    <th>SECRETORY</th>
                </tr>
");
#nullable restore
#line 17 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\PastLeader\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\PastLeader\Index.cshtml"
                       Write(item.Years);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\PastLeader\Index.cshtml"
                       Write(item.PRESIDENT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\PastLeader\Index.cshtml"
                       Write(item.SECRETORY);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 24 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\PastLeader\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PastLeadersModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f589db1012346b10b4b99528de748c828b5e63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
#line 1 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\_ViewImports.cshtml"
using RotaryWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\_ViewImports.cshtml"
using RotaryWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f589db1012346b10b4b99528de748c828b5e63", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392fdfb2defe746a147c96eab23595a37e467da7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
 foreach (var item in Model.Take(2))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card shadow-sm r-service-sec\">\r\n        <div class=\"card-header r-service-title\">");
#nullable restore
#line 6 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
                                            Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n        <div class=\"card-body r-service-body\">\r\n            <div class=\"r-service-img\">\r\n");
#nullable restore
#line 9 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
                  
                    string imgPath = "images/basi40586.jpg";
                    if (item.ProjectImageModel.Count > 0)
                    {
                        imgPath = item.ProjectImageModel[0].imageurl;
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 606, "\"", 620, 1);
#nullable restore
#line 17 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 612, imgPath, 612, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"r-service-info\">\r\n                <p class=\"text-justify\">\r\n");
#nullable restore
#line 21 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
                     if (item.Description.Count() > 500)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
                   Write(item.Description.Substring(0, 500));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>...</span>\r\n");
#nullable restore
#line 24 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
                Write(item.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n            </div>\r\n            <div class=\"r-service-btn text-right mt-3\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
           Write(Html.ActionLink("Read More", "Index", "Projects", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\Vedam\Desktop\Websites\gudur12thdecperfect\gudur12thdec\french11thdec\RotaryWebsite\RotaryWebsite\Views\Shared\Components\ProjectList\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
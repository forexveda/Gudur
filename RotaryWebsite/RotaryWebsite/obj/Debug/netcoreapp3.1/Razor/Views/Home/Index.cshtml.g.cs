#pragma checksum "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d31472f384b5ed6b778947d75e00ca0c3a6638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d31472f384b5ed6b778947d75e00ca0c3a6638", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392fdfb2defe746a147c96eab23595a37e467da7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row r-project-sec"">
    <div class=""col-md-8"">
        <div class=""card shadow-sm r-about-sec"">
            <div class=""card-header r-about-title""> Welcome To Rotary Club Gudur </div>
            <div class=""card-body r-about-body"">
                <div class=""r-about-img"">
                    <img class=""img-thumbnail"" src=""images/club-logo.png"">
                </div>
                <div class=""r-about-info"">
                    <p class=""text-justify"">
                        Rotary club of Gudur, one of the oldest club in RID 3160 was provisionally started in the year 1962 and

                        received its charter in the year January 1963. It was the initiative of Dodla Sundarami Reddy which resulted in the formation of the

                        club with some of the elite of Gudur town. The Club was sponsored by Rotary club of Nellore.
                    </p>
                    <p class=""text-justify"">
                        The Club had members from varying bu");
            WriteLiteral(@"siness backgrounds like Mica exports, Finance, Agriculture, Lemon business

                        and from varied professions like Medicine, engineering, law and business administration. Most of the charter members continued their

                        membership in the club till their last breath.


                    </p>


                </div>
                <div class=""r-about-btn text-right mt-3"">
                    <a href=""#"" class=""btn btn-primary"">Read More</a>
                </div>
            </div>
        </div>
        <div class=""r-service-container"">
            <div class=""r-main-heading"">
                <span>Events & Projects</span>
            </div>
            ");
#nullable restore
#line 41 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("ProjectList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n         \r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <div class=\"r-sidebar-sec\">\r\n            ");
#nullable restore
#line 48 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("HomeEventList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""r-upcoming-container mt-3"">
                <div class=""card shadow-sm"">
                    <div class=""card-header r-gallery-title"">
                        Club Leaders 2020-21
                    </div>
                    <div class=""card-body"">
                        <div class=""card mb-2 shadow-sm"">
                            <img class=""r-members-img img-thumbnail"" src=""images/president.jpg"" alt=""President"" />
                            <div class=""r-members-info"">
                                <p class=""r-members-title"">Raghava Reddy G.S.</p>
                                <p class=""r-members-position"">President</p>
                            </div>
                        </div>
                        <div class=""card mb-2 shadow-sm"">
                            <img class=""r-members-img img-thumbnail"" src=""images/secretary.jpg"" alt=""Secretory"" />
                            <div class=""r-members-info"">
                                <p class=""r-mem");
            WriteLiteral(@"bers-title"">Venkata Sridhar Reddy Bandi</p>
                                <p class=""r-members-position"">Secretary</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
#nullable restore
#line 75 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("PhotoGalleryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
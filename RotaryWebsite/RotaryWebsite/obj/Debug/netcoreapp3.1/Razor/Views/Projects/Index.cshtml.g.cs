#pragma checksum "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c328d93fb78f9aded5db139c2f71fa94636c923"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Index), @"mvc.1.0.view", @"/Views/Projects/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c328d93fb78f9aded5db139c2f71fa94636c923", @"/Views/Projects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392fdfb2defe746a147c96eab23595a37e467da7", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectCategoryModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .paginationshow {
        display: block !important;
    }

    .paginationhide {
        display: none !important;
    }
</style>
<div class=""r-projects-container"">
    <div class=""r-main-heading d-flex justify-content-center"">
        <span>Projects</span>
    </div>
    <div class=""row r-projects-sec"">
        <div class=""col-md-3"">
            <ul class=""r-projects-categories"">
");
#nullable restore
#line 22 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a");
            BeginWriteAttribute("id", " id=\"", 634, "\"", 712, 3);
            WriteAttributeValue("", 639, "li_", 639, 3, true);
#nullable restore
#line 24 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
WriteAttributeValue("", 642, item.Projecttype.ToString().Replace(" ", "-"), 642, 46, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
WriteAttributeValue("", 688, item.projectscategoryid, 688, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"liProjects\">");
#nullable restore
#line 24 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                                                                                                        Write(item.Projecttype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 25 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n\r\n        <div class=\"col-md-9\">\r\n            <div class=\"r-projects-list\">\r\n");
#nullable restore
#line 31 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                   int i = 0; bool firstCategory = false;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                 foreach (var item in Model)
                {
                    if (i == 0)
                    {
                        firstCategory = true;
                    }
                    else
                    {
                        firstCategory = false;

                    }

                    foreach (var project in item.ProjectsModel)
                    {
                        if (firstCategory)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("id", " id=\"", 1458, "\"", 1525, 3);
            WriteAttributeValue("", 1463, "div_", 1463, 4, true);
#nullable restore
#line 48 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
WriteAttributeValue("", 1467, item.Projecttype.Replace(" ","-"), 1467, 34, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
WriteAttributeValue("", 1501, item.projectscategoryid, 1501, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card shadow-sm r-projects-item\" style=\"display:block\">\r\n                                <div class=\"card-header r-projects-title\"> ");
#nullable restore
#line 49 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                                                      Write(project.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                                <div class=\"card-body r-projects-body\">\r\n                                    <div class=\"clearfix\">\r\n                                        <div class=\"r-projects-img\">\r\n");
#nullable restore
#line 53 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                             if (project.ProjectImageModel.Count > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <img");
            BeginWriteAttribute("src", " src=\"", 2077, "\"", 2121, 1);
#nullable restore
#line 55 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
WriteAttributeValue("", 2083, project.ProjectImageModel[0].imageurl, 2083, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 2144, "\"", 2150, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 56 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                        <div class=\"r-projects-info\">\r\n                                            <p class=\"text-justify mb-3\">\r\n                                                ");
#nullable restore
#line 60 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                           Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"r-projects-gallery row mt-3 \">\r\n");
#nullable restore
#line 65 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                         if (project.ProjectImageModel.Count > 1)
                                        {
                                            int o = 0;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                             foreach (var images in project.ProjectImageModel)
                                            {
                                                if (o == 0)
                                                {
                                                    o = o + 1;
                                                    continue;
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"col-6 col-md-3\">\r\n                                                    <img");
            BeginWriteAttribute("src", " src=\"", 3436, "\"", 3458, 1);
#nullable restore
#line 76 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
WriteAttributeValue("", 3442, images.imageurl, 3442, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\">\r\n                                                </div>\r\n");
#nullable restore
#line 78 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 83 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("id", " id=\"", 3868, "\"", 3935, 3);
            WriteAttributeValue("", 3873, "div_", 3873, 4, true);
#nullable restore
#line 87 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
WriteAttributeValue("", 3877, item.Projecttype.Replace(" ","-"), 3877, 34, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
WriteAttributeValue("", 3911, item.projectscategoryid, 3911, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card shadow-sm r-projects-item\" style=\"display:none\">\r\n                                <div class=\"card-header r-projects-title\"> ");
#nullable restore
#line 88 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                                                      Write(project.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                                <div class=\"card-body r-projects-body\">\r\n                                    <div class=\"clearfix\">\r\n                                        <div class=\"r-projects-img\">\r\n");
#nullable restore
#line 92 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                             if (project.ProjectImageModel.Count > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <img");
            BeginWriteAttribute("src", " src=\"", 4486, "\"", 4530, 1);
#nullable restore
#line 94 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
WriteAttributeValue("", 4492, project.ProjectImageModel[0].imageurl, 4492, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 4553, "\"", 4559, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 95 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                        <div class=\"r-projects-info\">\r\n                                            <p class=\"text-justify mb-3\">\r\n                                                ");
#nullable restore
#line 99 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                           Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"r-projects-gallery row mt-3 \">\r\n");
#nullable restore
#line 104 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                         if (project.ProjectImageModel.Count > 1)
                                        {
                                            int o = 0;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                             foreach (var images in project.ProjectImageModel)
                                            {
                                                if (o == 0)
                                                {
                                                    o = o + 1;
                                                    continue;
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"col-6 col-md-3\">\r\n                                                    <img");
            BeginWriteAttribute("src", " src=\"", 5845, "\"", 5867, 1);
#nullable restore
#line 115 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
WriteAttributeValue("", 5851, images.imageurl, 5851, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\">\r\n                                                </div>\r\n");
#nullable restore
#line 117 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 122 "C:\Users\tm\Downloads\gudur5thdec\gudur5thdec\kalamassery_latest_28_Nov_2020\kalamassery_latest\kalamassery\kalamassery\RotaryWebsite\RotaryWebsite\Views\Projects\Index.cshtml"

                        }
                        i = i + 1;
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
            <div class=""r-pagination-sec"">
                <div id=""r-pagination""></div>
            </div>
        </div>
    </div>
</div>

<script src=""js/scripts.js""></script>
<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"" type=""text/javascript""></script>

<script>
    $(document).ready(function () {
        $('.liProjects').on('click', function () {
            $('[id$=r-pagination]').html('');
            let id = $(this).attr('id').split('_')[1];
            $('.r-projects-item').css('display', 'none');
            let divId = 'div_' + id;
            $('[id$=' + divId + ']').css('display', 'block');

            $('.r-projects-item').removeClass('paginationhide');
            $('.r-projects-item').removeClass('paginationshow');

            pagination();
        });
    });
</script>

<script type=""text/javascript"" src=""js/main.js""></script>
<script type=""text/javascript"">
    pagination();
    function pagination() {
   ");
            WriteLiteral(@"     var pageSize = 10;
        var pageCount = $("".r-projects-item:visible"").length / pageSize;
        if (pageCount <= 1) {
            $('#r-pagination').hide()
        } else {
            $('#r-pagination').show()
        }
        for (var i = 0; i < pageCount; i++) {
            $(""#r-pagination"").append('<a href=""#"">' + (i + 1) + '</a>');
        }

        $(""#r-pagination"").find(""a"").first().addClass(""active"")

        showPageFirst = function (page) {
            var items = $("".r-projects-item:visible"");
            let i = 1;
            let maxItemCountPerPage = page * pageSize;
            let minItemCountPerPage = (page * pageSize) - pageSize;

            $.each(items, function (item) {
                if (i > minItemCountPerPage && i <= maxItemCountPerPage) {
                    $(this).addClass('paginationshow');
                } else {
                    $(this).addClass('paginationhide');
                }

                i = i + 1;
            });
        ");
            WriteLiteral(@"}
        showPage = function (page) {
            debugger
            var allItems = $("".r-projects-item"");

            var items = new Array();

            $.each(allItems, function (i, item) {
                if ($(item).hasClass('paginationshow') || $(item).hasClass('paginationhide')) {
                    items.push(item);
                    $(this).removeClass('paginationhide');
                    $(this).removeClass('paginationshow');
                }
            });
            let i = 0;
            //if (page == 1) {
            //    i = 1;
            //} else {
            //    i = pageSize + 1;
            //}
            let maxItemCountPerPage = page * pageSize;
            let minItemCountPerPage = (page * pageSize) - pageSize;

            $.each(items, function (item) {
                if (i > minItemCountPerPage && i <= maxItemCountPerPage) {
                    $(this).addClass('paginationshow');
                } else {
                    $(this).addCla");
            WriteLiteral(@"ss('paginationhide');
                }

                i = i + 1;
            });
        }
        //showPage = function (page) {
        //    $("".r-projects-item"").hide();
        //    $("".r-projects-item"").each(function (n) {
        //        if (n >= pageSize * (page - 1) && n < pageSize * page) {
        //            $(this).show();
        //        }
        //    });
        //}
        showPageFirst(1);
        $(""#r-pagination a"").click(function () {
            $(""#r-pagination a"").removeClass(""active"");
            $(this).addClass(""active"");
            showPage(parseInt($(this).text()))
        });

    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectCategoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

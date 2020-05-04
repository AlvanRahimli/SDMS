#pragma checksum "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06b3aa01862b94d26df8dbd7d7e8411de955f81d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_TakenCourses), @"mvc.1.0.view", @"/Views/Students/TakenCourses.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/alvan/Projects/SDMS/Views/_ViewImports.cshtml"
using SDMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alvan/Projects/SDMS/Views/_ViewImports.cshtml"
using SDMS.Models.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alvan/Projects/SDMS/Views/_ViewImports.cshtml"
using SDMS.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alvan/Projects/SDMS/Views/_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06b3aa01862b94d26df8dbd7d7e8411de955f81d", @"/Views/Students/TakenCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e9968b171d1a710a2c363dd6b78a9472837a44", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_TakenCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SDMS.Models.Dtos.CourseReturnDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n");
#nullable restore
#line 6 "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml"
     for (int i = 0; i < Model.Count; i += 4)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n");
#nullable restore
#line 9 "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml"
             for (int j = i; j < 4 && j < Model.Count; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\" style=\"width: 18rem; margin-left: 20px;\">\n                    <div class=\"card-body\">\n                        <h5 class=\"card-title\">Name: ");
#nullable restore
#line 13 "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml"
                                                Write(Model[j].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <h6 class=\"card-subtitle mb-2 text-muted\">\n                            Credit: <strong>");
#nullable restore
#line 15 "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml"
                                       Write(Model[j].Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                            Absence limit: <strong>");
#nullable restore
#line 16 "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml"
                                              Write(Model[j].AbsenceLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                        </h6>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 720, "\"", 749, 1);
#nullable restore
#line 18 "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml"
WriteAttributeValue("", 727, Model[j].SyllabusPath, 727, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\">Syllabus</a>\n                        <a href=\"#\" class=\"card-link\">");
#nullable restore
#line 19 "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml"
                                                 Write(Model[j].Teacher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                        <a href=\"#\" class=\"card-link\">Go to course info</a>\n                    </div>\n                </div>\n");
#nullable restore
#line 23 "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n");
#nullable restore
#line 25 "/home/alvan/Projects/SDMS/Views/Students/TakenCourses.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SDMS.Models.Dtos.CourseReturnDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

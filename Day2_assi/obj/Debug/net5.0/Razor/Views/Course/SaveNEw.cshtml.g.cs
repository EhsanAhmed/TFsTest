#pragma checksum "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Course\SaveNEw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34664560c1123d85093c25c4a40e1d13d4b2c74d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_SaveNEw), @"mvc.1.0.view", @"/Views/Course/SaveNEw.cshtml")]
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
#line 1 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\_ViewImports.cshtml"
using Day2_assi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\_ViewImports.cshtml"
using Day2_assi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\_ViewImports.cshtml"
using Day2_assi.View_Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34664560c1123d85093c25c4a40e1d13d4b2c74d", @"/Views/Course/SaveNEw.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79def73523820b4d5ce0b19739828ff4ea350a5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_SaveNEw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Courses</h1>\r\n<table class=\"table table-hover table-bordered\">\r\n");
#nullable restore
#line 5 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Course\SaveNEw.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 8 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Course\SaveNEw.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 9 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Course\SaveNEw.cshtml"
           Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 11 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Course\SaveNEw.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

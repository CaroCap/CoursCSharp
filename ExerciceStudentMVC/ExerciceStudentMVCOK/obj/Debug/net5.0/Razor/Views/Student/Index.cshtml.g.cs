#pragma checksum "C:\Users\c.cap\source\repos\ExerciceStudentMVC\ExerciceStudentMVCOK\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee309d6d1167a7bdb49846c16660960a8dcc9a7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\c.cap\source\repos\ExerciceStudentMVC\ExerciceStudentMVCOK\Views\_ViewImports.cshtml"
using ExerciceStudentMVCOK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\c.cap\source\repos\ExerciceStudentMVC\ExerciceStudentMVCOK\Views\Student\Index.cshtml"
using ExerciceStudentMVCOK.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\c.cap\source\repos\ExerciceStudentMVC\ExerciceStudentMVCOK\Views\Student\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee309d6d1167a7bdb49846c16660960a8dcc9a7e", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72256bc135688cbcfe65bd8d2dc51a3dcdb77203", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentListItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>Dans le groupe, il y a : ");
#nullable restore
#line 6 "C:\Users\c.cap\source\repos\ExerciceStudentMVC\ExerciceStudentMVCOK\Views\Student\Index.cshtml"
                         Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" élève(s) </div>\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\c.cap\source\repos\ExerciceStudentMVC\ExerciceStudentMVCOK\Views\Student\Index.cshtml"
Write(Html.ActionLink("Vers le fomulaire pour ajouter un étudiant", "AddStudent", "Student"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n<ul>\r\n");
#nullable restore
#line 15 "C:\Users\c.cap\source\repos\ExerciceStudentMVC\ExerciceStudentMVCOK\Views\Student\Index.cshtml"
     foreach (StudentListItem item in Model)
    {
        //<li>@*<a href="/student/details/@item.Id"><div>@item.Nom @item.Prenom @item.Section_id</div></a>*@</li>

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 18 "C:\Users\c.cap\source\repos\ExerciceStudentMVC\ExerciceStudentMVCOK\Views\Student\Index.cshtml"
       Write(Html.ActionLink(@item.Nom + " " + @item.Prenom + " " + @item.Section_id.ToString(), "Details", "Student", new { id = item.Id } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\Users\c.cap\source\repos\ExerciceStudentMVC\ExerciceStudentMVCOK\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentListItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591

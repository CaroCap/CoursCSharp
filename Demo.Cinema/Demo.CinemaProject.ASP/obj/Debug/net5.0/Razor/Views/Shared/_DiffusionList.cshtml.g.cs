#pragma checksum "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2917f6aa312442e2bdf7c01492071d500d7e30f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DiffusionList), @"mvc.1.0.view", @"/Views/Shared/_DiffusionList.cshtml")]
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
#line 1 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\_ViewImports.cshtml"
using Demo.CinemaProject.ASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\_ViewImports.cshtml"
using Demo.CinemaProject.ASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2917f6aa312442e2bdf7c01492071d500d7e30f2", @"/Views/Shared/_DiffusionList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1af2d488ca10fab7547080c4f1c3abf62eefe38", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DiffusionList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Demo.CinemaProject.ASP.Models.DiffusionDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml"
  
    ViewData["Title"] = "_DiffusionList"; // _Diffusion => le _ sert à dire que c'est une vue partagée + partiel qui ne pourra pas être vue seul mais servira à être ajouté à une autre vue

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>_DiffusionList</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2917f6aa312442e2bdf7c01492071d500d7e30f24044", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml"
           Write(Html.DisplayNameFor(model => model.DateDiffusion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml"
           Write(Html.DisplayNameFor(model => model.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateDiffusion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 35 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 36 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Mediamonster\source\repos\CoursCSharp\Demo.Cinema\Demo.CinemaProject.ASP\Views\Shared\_DiffusionList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Demo.CinemaProject.ASP.Models.DiffusionDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/saharak/Documents/Work/Web/demoDotnet/Views/Home/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75efc96ee29733b3264f71e869dae92adc6fb2e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_New), @"mvc.1.0.view", @"/Views/Home/New.cshtml")]
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
#line 1 "/Users/saharak/Documents/Work/Web/demoDotnet/Views/_ViewImports.cshtml"
using demoDotnet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/saharak/Documents/Work/Web/demoDotnet/Views/_ViewImports.cshtml"
using demoDotnet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75efc96ee29733b3264f71e869dae92adc6fb2e5", @"/Views/Home/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c862931c76e05e40466ddc51a6113ba27475060", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<demoDotnet.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/saharak/Documents/Work/Web/demoDotnet/Views/Home/New.cshtml"
  
  ViewData["Title"] = "New Student";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n  <h1 class=\"text-center\" class=\"display-4\">Create Student</h1>\n");
#nullable restore
#line 8 "/Users/saharak/Documents/Work/Web/demoDotnet/Views/Home/New.cshtml"
     using (Html.BeginForm("Create", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"row\">\n\t\t\t\t<div class=\"col-lg-6\">\n\t\t\t\t\t<label>Name :</label>\n\t\t\t\t\t");
#nullable restore
#line 13 "/Users/saharak/Documents/Work/Web/demoDotnet/Views/Home/New.cshtml"
               Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"col-lg-6\">\n\t\t\t\t\t<label>Status :</label>\n\t\t\t\t\t");
#nullable restore
#line 17 "/Users/saharak/Documents/Work/Web/demoDotnet/Views/Home/New.cshtml"
               Write(Html.DropDownListFor(model => model.Status, new SelectList(new string[] {"กำลังศึกษา", "จบการศึกษา", "ลาออก"}, "กำลังศึกษา"), htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t\t<br>\n\t\t\t<div class=\"row\">\n\t\t\t\t<div class=\"col-lg-12\">\n\t\t\t\t\t<input type=\"submit\" value=\"Save\" class=\"btn btn-success btn-block\"/>\n\t\t\t\t</div>\n\t\t\t</div>\n");
#nullable restore
#line 26 "/Users/saharak/Documents/Work/Web/demoDotnet/Views/Home/New.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<demoDotnet.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/home/ryu/Documents/Work/demoDotnet/Views/Home/StudentTableModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b98e897649409679b10f1114539c7810f57d87e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StudentTableModal), @"mvc.1.0.view", @"/Views/Home/StudentTableModal.cshtml")]
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
#line 1 "/home/ryu/Documents/Work/demoDotnet/Views/_ViewImports.cshtml"
using demoDotnet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ryu/Documents/Work/demoDotnet/Views/_ViewImports.cshtml"
using demoDotnet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b98e897649409679b10f1114539c7810f57d87e", @"/Views/Home/StudentTableModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c862931c76e05e40466ddc51a6113ba27475060", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StudentTableModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<demoDotnet.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table"">
  <tr>
    <th class=""sort"" id=""SelectAll"" ><input type=""checkbox"" onclick=""CheckboxAll(this.id)""  id=""Checkall""  >เลือกทั้งหมด</th>
    <th class=""sort"" id=""Select"">เลือก</th>
    <th class=""sort"" id=""Id"">ไอดี</th>
    <th class=""sort"" id=""Name"">ชื่อ</th>
    <th class=""sort"" id=""Brithday"">วันเกิด</th>
    <th class=""sort"" id=""Status"">สถานะ</th>
    <th></th>
  </tr>
");
#nullable restore
#line 12 "/home/ryu/Documents/Work/demoDotnet/Views/Home/StudentTableModal.cshtml"
   foreach (var student in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr id=\"allStudent\">\n     \n      <td><input type=\"checkbox\" onclick=\"getStudentsById()\" name=\"student[selected]\" id=\"studentSelected\"");
            BeginWriteAttribute("student-id", " student-id=\"", 612, "\"", 636, 1);
#nullable restore
#line 15 "/home/ryu/Documents/Work/demoDotnet/Views/Home/StudentTableModal.cshtml"
WriteAttributeValue("", 625, student.Id, 625, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"true\"></td>\n      <td>");
#nullable restore
#line 16 "/home/ryu/Documents/Work/demoDotnet/Views/Home/StudentTableModal.cshtml"
     Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 17 "/home/ryu/Documents/Work/demoDotnet/Views/Home/StudentTableModal.cshtml"
     Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 18 "/home/ryu/Documents/Work/demoDotnet/Views/Home/StudentTableModal.cshtml"
     Write(student.Brithday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 19 "/home/ryu/Documents/Work/demoDotnet/Views/Home/StudentTableModal.cshtml"
     Write(student.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n");
#nullable restore
#line 21 "/home/ryu/Documents/Work/demoDotnet/Views/Home/StudentTableModal.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<div class=\"row\">\n  <div class=\"col-lg-11\">\n    <ul class=\"pagination\" id=\"StudentTableModal-paginationStudents\"></ul>\n  </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<demoDotnet.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591

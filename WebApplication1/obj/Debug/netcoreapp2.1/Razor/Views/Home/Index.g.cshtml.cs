#pragma checksum "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a8a8c807cafde6178d164aa846629ffb47379b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 2 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\_ViewImports.cshtml"
using CompanyEmployee.Data.Models;

#line default
#line hidden
#line 3 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\_ViewImports.cshtml"
using CompanyEmployee.Data.Models.Entities;

#line default
#line hidden
#line 5 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\_ViewImports.cshtml"
using CompanyEmployee.Services.Models;

#line default
#line hidden
#line 6 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 7 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a8a8c807cafde6178d164aa846629ffb47379b2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d726dd7c394f604c7b2dc54dd33116b2cc9b04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AllCompanyModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 365, true);
            WriteLiteral(@"
<br /> <br />
       <a class=""btn btn-warning btn-sm"" href=""/Home/Create/"">Create New Company</a>
<table class=""table table-hover table-bordered"">
    <thead>
        <tr>
            <th>Company Name</th>
            <th>Founded</th>
            <th>Information</th>
            <th>Modify Company</th>
        </tr>
     
    </thead>
    <tbody>
");
            EndContext();
#line 16 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
         foreach (var company in Model)
        {

#line default
#line hidden
            BeginContext(454, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(485, 12, false);
#line 19 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
           Write(company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(497, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(521, 15, false);
#line 20 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
           Write(company.Founded);

#line default
#line hidden
            EndContext();
            BeginContext(536, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(560, 19, false);
#line 21 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
           Write(company.Information);

#line default
#line hidden
            EndContext();
            BeginContext(579, 74, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-warning btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 653, "\"", 688, 2);
            WriteAttributeValue("", 660, "/Employee/Create/", 660, 17, true);
#line 23 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 677, company.Id, 677, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(689, 68, true);
            WriteLiteral(">Add Employee</a>\r\n                <a class=\"btn btn-warning btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 757, "\"", 789, 2);
            WriteAttributeValue("", 764, "/Home/Details/", 764, 14, true);
#line 24 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 778, company.Id, 778, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(790, 60, true);
            WriteLiteral(">Edit</a>\r\n                <a class=\"btn btn-warning btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 850, "\"", 881, 2);
            WriteAttributeValue("", 857, "/Home/Delete/", 857, 13, true);
#line 25 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 870, company.Id, 870, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(882, 63, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n\r\n        </tr>\r\n        <tr>\r\n");
            EndContext();
#line 30 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
             if (@company.Employees == null)
            {

#line default
#line hidden
            BeginContext(1006, 75, true);
            WriteLiteral("                <td>\r\n                    <a class=\"btn btn-warning btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1081, "\"", 1116, 2);
            WriteAttributeValue("", 1088, "/Employee/Create/", 1088, 17, true);
#line 33 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1105, company.Id, 1105, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1117, 42, true);
            WriteLiteral(">Add Employee</a>\r\n                </td>\r\n");
            EndContext();
#line 35 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1174, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 36 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
             foreach (var employ in company.Employees)
            {

#line default
#line hidden
            BeginContext(1245, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1266, 11, false);
#line 38 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
               Write(employ.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1277, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1305, 17, false);
#line 39 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
               Write(employ.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(1322, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1350, 19, false);
#line 40 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
               Write(employ.StartingDate);

#line default
#line hidden
            EndContext();
            BeginContext(1369, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1397, 19, false);
#line 41 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
               Write(employ.VacationDays);

#line default
#line hidden
            EndContext();
            BeginContext(1416, 82, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-warning btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1498, "\"", 1533, 2);
            WriteAttributeValue("", 1505, "/Employee/Create/", 1505, 17, true);
#line 43 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1522, company.Id, 1522, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1534, 72, true);
            WriteLiteral(">Add Employee</a>\r\n                    <a class=\"btn btn-warning btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1606, "\"", 1639, 2);
            WriteAttributeValue("", 1613, "/Employee/Edit/", 1613, 15, true);
#line 44 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1628, company.Id, 1628, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1640, 34, true);
            WriteLiteral(">Edit</a>\r\n                </td>\r\n");
            EndContext();
#line 46 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1689, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Sekul\Desktop\Test\WebApplication1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1715, 34, true);
            WriteLiteral("        \r\n    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AllCompanyModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
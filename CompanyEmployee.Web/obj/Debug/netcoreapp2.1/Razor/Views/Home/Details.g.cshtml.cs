#pragma checksum "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "896fe74111dfee5dc9f9b160959bb8380ebcf742"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\_ViewImports.cshtml"
using CompanyEmployee.Web.Models;

#line default
#line hidden
#line 2 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\_ViewImports.cshtml"
using CompanyEmployee.Web.Models.Employee;

#line default
#line hidden
#line 3 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\_ViewImports.cshtml"
using CompanyEmployee.Web.Controllers;

#line default
#line hidden
#line 4 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\_ViewImports.cshtml"
using CompanyEmployee.Web.Models.Company;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"896fe74111dfee5dc9f9b160959bb8380ebcf742", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc4b50c61171054271a7e38140731badcb518096", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 298, true);
            WriteLiteral(@"
<div>
<div class=""panel-body table-responsive col-md-6 col-md-offset-3"">
    <table class=""table"">
        <tr>
            <td colspan=""2"" align=""center"" class=""info""><b>Company</b></td>
        </tr>
        <tr>
            <td width=""35%""><b>Name</b></td>
            <td width=""65%"">");
            EndContext();
            BeginContext(322, 10, false);
#line 11 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
                       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(332, 89, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Founded</b></td>\r\n            <td>");
            EndContext();
            BeginContext(422, 36, false);
#line 15 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
           Write(Model.Founded.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(458, 93, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Information</b></td>\r\n            <td>");
            EndContext();
            BeginContext(552, 17, false);
#line 19 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
           Write(Model.Information);

#line default
#line hidden
            EndContext();
            BeginContext(569, 113, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </table> <br /><br />\r\n</div> \r\n<div class=\"table-hover col-md-6 col-md-offset-3\">\r\n<b>");
            EndContext();
            BeginContext(683, 10, false);
#line 24 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(693, 55, true);
            WriteLiteral(" Employees</b> <br /><br />\r\n<div class=\"form-group\">\r\n");
            EndContext();
#line 26 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
     if (Model.Employees != null)
    {

#line default
#line hidden
            BeginContext(790, 427, true);
            WriteLiteral(@"        <table class=""table col-md-10 info"">
            <thead class=""thead-dark"">
                <tr class=""info"">
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Experience</th>
                    <th scope=""col"">Starting date</th>
                    <th scope=""col"">Salary</th>
                    <th scope=""col"">Vacation days</th>
                </tr>
            </thead>
");
            EndContext();
#line 38 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
             foreach (var employee in Model.Employees)
            {

#line default
#line hidden
            BeginContext(1288, 79, true);
            WriteLiteral("                <tbody>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(1368, 13, false);
#line 42 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
                       Write(employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1381, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1417, 19, false);
#line 43 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
                       Write(employee.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(1436, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1472, 44, false);
#line 44 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
                       Write(employee.StartingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 69, true);
            WriteLiteral("</td>\r\n                        <td class=\"glyphicon glyphicon-euro\"> ");
            EndContext();
            BeginContext(1586, 15, false);
#line 45 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
                                                         Write(employee.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(1601, 55, true);
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
            EndContext();
            BeginContext(1657, 21, false);
#line 46 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
                                           Write(employee.VacationDays);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 60, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n");
            EndContext();
#line 49 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1753, 18, true);
            WriteLiteral("        </table>\r\n");
            EndContext();
#line 51 "C:\Users\Sekul\Desktop\Test  with unit testing - Copy\CompanyEmployee.Web\Views\Home\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1778, 27, true);
            WriteLiteral("</div>\r\n</div>\r\n</div>\r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335857ba93730b78388b1f068f8715f17eb26808"
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
#line 1 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\_ViewImports.cshtml"
using CompanyEmployee.Web.Models;

#line default
#line hidden
#line 2 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\_ViewImports.cshtml"
using CompanyEmployee.Web.Models.Employee;

#line default
#line hidden
#line 3 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\_ViewImports.cshtml"
using CompanyEmployee.Web.Controllers;

#line default
#line hidden
#line 4 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\_ViewImports.cshtml"
using CompanyEmployee.Web.Models.Company;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335857ba93730b78388b1f068f8715f17eb26808", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc4b50c61171054271a7e38140731badcb518096", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyDetails>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 87, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"col-md-3\">\r\n        <div class=\"form-group\">\r\n            <h2>");
            EndContext();
            BeginContext(111, 10, false);
#line 6 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(121, 34, true);
            WriteLiteral(" Details:</h2><br />\r\n            ");
            EndContext();
            BeginContext(155, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd4e000b5e8f4c9aaecb1f8f772582a2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 7 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(185, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(200, 10, false);
#line 8 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(210, 65, true);
            WriteLiteral(" \r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(275, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b77cafade044a3b1b55ce8c788cff8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 11 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Founded);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(308, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(323, 36, false);
#line 12 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
       Write(Model.Founded.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(359, 64, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(423, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1efafb9296fa430caaca14f04fe67b2b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 15 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Information);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(460, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(475, 17, false);
#line 16 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
       Write(Model.Information);

#line default
#line hidden
            EndContext();
            BeginContext(492, 108, true);
            WriteLiteral("\r\n        </div>\r\n    </div> \r\n        <div class=\"table-hover col-md-6 col-md-offset-1\"> \r\n            <h2>");
            EndContext();
            BeginContext(601, 10, false);
#line 20 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(611, 62, true);
            WriteLiteral(" Employees:</h2><br />\r\n            <div class=\"form-group\">\r\n");
            EndContext();
#line 22 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
                 if (Model.Employees != null)
                {

#line default
#line hidden
            BeginContext(739, 530, true);
            WriteLiteral(@"                    <table class=""table col-md-10"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th scope=""col"">Name</th>
                                <th scope=""col"">Experience</th>
                                <th scope=""col"">Starting date</th>
                                <th scope=""col"">Salary</th>
                                <th scope=""col"">Vacation days</th> 
                            </tr>
                        </thead>
");
            EndContext();
#line 34 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
                         foreach (var employee in Model.Employees)
                        {

#line default
#line hidden
            BeginContext(1364, 115, true);
            WriteLiteral("                            <tbody>\r\n                                <tr>\r\n                                    <th>");
            EndContext();
            BeginContext(1480, 13, false);
#line 38 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
                                   Write(employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1493, 47, true);
            WriteLiteral("</th>\r\n                                    <td>");
            EndContext();
            BeginContext(1541, 19, false);
#line 39 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
                                   Write(employee.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(1560, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1608, 44, false);
#line 40 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
                                   Write(employee.StartingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 81, true);
            WriteLiteral("</td>\r\n                                    <td class=\"glyphicon glyphicon-euro\"> ");
            EndContext();
            BeginContext(1734, 15, false);
#line 41 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
                                                                     Write(employee.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(1749, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1797, 21, false);
#line 42 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
                                   Write(employee.VacationDays);

#line default
#line hidden
            EndContext();
            BeginContext(1818, 85, true);
            WriteLiteral("</td> \r\n                                </tr>\r\n                            </tbody>\r\n");
            EndContext();
#line 45 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(1930, 30, true);
            WriteLiteral("                    </table>\r\n");
            EndContext();
#line 47 "C:\Users\Sekul\Desktop\Test\CompanyEmployee.Web\Views\Home\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1979, 46, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>");
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

#pragma checksum "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b5ac0421e2c6a5bb07d858fdd869d9b0d47ebf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_TestGV), @"mvc.1.0.view", @"/Views/Test/TestGV.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/TestGV.cshtml", typeof(AspNetCore.Views_Test_TestGV))]
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
#line 1 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\_ViewImports.cshtml"
using RavenDB_Embedded;

#line default
#line hidden
#line 2 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\_ViewImports.cshtml"
using RavenDB_Embedded.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b5ac0421e2c6a5bb07d858fdd869d9b0d47ebf", @"/Views/Test/TestGV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5578d4cd3c929c1a9d9ad21fd42e0e00baf0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_TestGV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RavenDB_Embedded.Models.DocGia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
  
    ViewData["Title"] = "TestGV";

#line default
#line hidden
            BeginContext(96, 30, true);
            WriteLiteral("\r\n<h2>TestGV</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57dab8d165b94c2b99e70a197182569c", async() => {
                BeginContext(149, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(163, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(256, 38, false);
#line 16 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(294, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(350, 44, false);
#line 19 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.DisplayNameFor(model => model.MaLoaiDG));

#line default
#line hidden
            EndContext();
            BeginContext(394, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(450, 40, false);
#line 22 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.DisplayNameFor(model => model.MaDG));

#line default
#line hidden
            EndContext();
            BeginContext(490, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(546, 41, false);
#line 25 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.DisplayNameFor(model => model.TenDG));

#line default
#line hidden
            EndContext();
            BeginContext(587, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(643, 47, false);
#line 28 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.DisplayNameFor(model => model.SoDienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(690, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(808, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(857, 37, false);
#line 37 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(894, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(950, 43, false);
#line 40 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaLoaiDG));

#line default
#line hidden
            EndContext();
            BeginContext(993, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1049, 39, false);
#line 43 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaDG));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1144, 40, false);
#line 46 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenDG));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1240, 46, false);
#line 49 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoDienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1342, 65, false);
#line 52 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1428, 71, false);
#line 53 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1520, 69, false);
#line 54 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\TestGV.cshtml"
}

#line default
#line hidden
            BeginContext(1628, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RavenDB_Embedded.Models.DocGia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
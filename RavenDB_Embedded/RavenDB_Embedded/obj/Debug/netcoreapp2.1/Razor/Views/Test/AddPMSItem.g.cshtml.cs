#pragma checksum "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\AddPMSItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60036a20ed670693d29a0227e2dae4bb0137d2ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_AddPMSItem), @"mvc.1.0.view", @"/Views/Test/AddPMSItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/AddPMSItem.cshtml", typeof(AspNetCore.Views_Test_AddPMSItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60036a20ed670693d29a0227e2dae4bb0137d2ba", @"/Views/Test/AddPMSItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5578d4cd3c929c1a9d9ad21fd42e0e00baf0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_AddPMSItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RavenDB_Embedded.Models.PMSItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(173, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\AddPMSItem.cshtml"
 foreach (PMSItem p in Model)
{

#line default
#line hidden
            BeginContext(209, 37, true);
            WriteLiteral("<tr>\r\n    <td class=\"pmsitem_masach\">");
            EndContext();
            BeginContext(247, 8, false);
#line 8 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\AddPMSItem.cshtml"
                          Write(p.SachId);

#line default
#line hidden
            EndContext();
            BeginContext(255, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(270, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bdfbecb83cf148ec928c8e79df8d02a8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 280, "~/images/", 280, 9, true);
#line 9 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\AddPMSItem.cshtml"
AddHtmlAttributeValue("", 289, p.Hinh, 289, 7, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(327, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(343, 9, false);
#line 10 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\AddPMSItem.cshtml"
   Write(p.TenSach);

#line default
#line hidden
            EndContext();
            BeginContext(352, 32, true);
            WriteLiteral("</td>    \r\n    <td id=\"soluong\">");
            EndContext();
            BeginContext(385, 9, false);
#line 11 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\AddPMSItem.cshtml"
                Write(p.SoLuong);

#line default
#line hidden
            EndContext();
            BeginContext(394, 14, true);
            WriteLiteral("</td>\r\n</tr>\r\n");
            EndContext();
#line 13 "F:\Hoc Tap\Chuyen Nganh\Nam 3\Co So Du Lieu Nang Cao\CuoiKy_RavenDB\CSDLNC_Demo\RavenDB_Embedded\RavenDB_Embedded\Views\Test\AddPMSItem.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RavenDB_Embedded.Models.PMSItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591

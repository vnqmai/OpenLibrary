#pragma checksum "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce0b0a258a84937ea257c2abc24b3572818a4d07"
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
#line 1 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\_ViewImports.cshtml"
using RavenDB_Embedded;

#line default
#line hidden
#line 2 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\_ViewImports.cshtml"
using RavenDB_Embedded.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0b0a258a84937ea257c2abc24b3572818a4d07", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5578d4cd3c929c1a9d9ad21fd42e0e00baf0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 562, true);
            WriteLiteral(@"
<h2>Đăng Nhập</h2>
<table style=""margin:auto"">
    <tr>
        <td>Tên đăng nhập:</td>
        <td><input type=""text"" class=""form-control"" id=""tendn""/></td>
    </tr>
    <tr>
        <td>Mật khẩu:</td>
        <td><input type=""password"" class=""form-control"" id=""matkhau"" /></td>
    </tr>
    <tr>
        <td colspan=""2"" style=""text-align:center"">
            <input type=""button"" value=""Đăng nhập"" id=""btnDN"" class=""btn btn-primary""/>
        </td>
    </tr>
</table>
<div style=""text-align: center"">
    <h3 style=""color:red"" id=""ketqua"">");
            EndContext();
#line 23 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\Index.cshtml"
                                       if (ViewBag.TrangThai != null) { 

#line default
#line hidden
            BeginContext(640, 17, false);
#line 23 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\Index.cshtml"
                                                                   Write(ViewBag.TrangThai);

#line default
#line hidden
            EndContext();
#line 23 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\Index.cshtml"
                                                                                          ; }

#line default
#line hidden
            BeginContext(660, 18, true);
            WriteLiteral(" </h3>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(678, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdb4c91b1f7c43ae904f48585d4de9f4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(729, 826, true);
            WriteLiteral(@"
<script>
    $(function () {
        $(""#btnDN"").on(""click"", function () {
            $.ajax({
                url: ""/Home/DangNhap"",
                data: { tendn_matkhau: $(""#tendn"").val() + ""-"" + $(""#matkhau"").val() },
                success: function (response) {                                        
                    if (response==""DG"")
                        location.href = ""../Home/ChonChiNhanh"";                        
                    else if (response == ""QT"")
                        location.href = ""../QuanThu/Index"";
                    else if (response == ""QL"")
                        location.href = ""../QuanLy/Index"";
                    else
                        $(""#ketqua"").html(""Đăng nhập thất bại!"");
                }
            });
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

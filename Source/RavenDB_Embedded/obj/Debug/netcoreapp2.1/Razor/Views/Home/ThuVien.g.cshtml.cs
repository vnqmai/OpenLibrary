#pragma checksum "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "159d1498d62851ccf7e97b17eeada5b930b41760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ThuVien), @"mvc.1.0.view", @"/Views/Home/ThuVien.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ThuVien.cshtml", typeof(AspNetCore.Views_Home_ThuVien))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"159d1498d62851ccf7e97b17eeada5b930b41760", @"/Views/Home/ThuVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5578d4cd3c929c1a9d9ad21fd42e0e00baf0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ThuVien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RavenDB_Embedded.Models.Sach>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
  
    ViewData["Title"] = "ThuVien";

#line default
#line hidden
            BeginContext(95, 111, true);
            WriteLiteral("\r\n\r\n\r\n<h2>Thư Viện</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(207, 38, false);
#line 15 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(245, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(301, 42, false);
#line 18 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
            EndContext();
            BeginContext(343, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(399, 43, false);
#line 21 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayNameFor(model => model.TenSach));

#line default
#line hidden
            EndContext();
            BeginContext(442, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(498, 40, false);
#line 24 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(538, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(594, 45, false);
#line 27 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayNameFor(model => model.TenTacGia));

#line default
#line hidden
            EndContext();
            BeginContext(639, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(695, 46, false);
#line 30 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayNameFor(model => model.NhaXuatBan));

#line default
#line hidden
            EndContext();
            BeginContext(741, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(797, 46, false);
#line 33 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayNameFor(model => model.NamXuatBan));

#line default
#line hidden
            EndContext();
            BeginContext(843, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(899, 48, false);
#line 36 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayNameFor(model => model.LoiGioiThieu));

#line default
#line hidden
            EndContext();
            BeginContext(947, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1003, 42, false);
#line 39 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1101, 44, false);
#line 42 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayNameFor(model => model.ChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 48 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1263, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1312, 37, false);
#line 51 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1405, 41, false);
#line 54 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaSach));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1502, 42, false);
#line 57 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenSach));

#line default
#line hidden
            EndContext();
            BeginContext(1544, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1599, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3ed754fd6f94c78bb9f0f4216285525", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1609, "~/images/", 1609, 9, true);
#line 60 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
AddHtmlAttributeValue("", 1618, Html.DisplayFor(modelItem => item.Hinh), 1618, 40, false);

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
            BeginContext(1684, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1740, 44, false);
#line 63 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenTacGia));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1840, 45, false);
#line 66 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.NhaXuatBan));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1941, 45, false);
#line 69 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.NamXuatBan));

#line default
#line hidden
            EndContext();
            BeginContext(1986, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2042, 47, false);
#line 72 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoiGioiThieu));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2145, 41, false);
#line 75 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(2186, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2242, 43, false);
#line 78 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.ChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(2285, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td>                \r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2358, "\'", 2409, 3);
#line 81 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
WriteAttributeValue("", 2365, Url.Action("XemChiTiet","Test"), 2365, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 2397, "?id=", 2397, 4, true);
#line 81 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
WriteAttributeValue("", 2401, item.Id, 2401, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2410, 95, true);
            WriteLiteral(" class=\"btn btn-default\">Xem</a>                           \r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 84 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ThuVien.cshtml"
}

#line default
#line hidden
            BeginContext(2508, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RavenDB_Embedded.Models.Sach>> Html { get; private set; }
    }
}
#pragma warning restore 1591

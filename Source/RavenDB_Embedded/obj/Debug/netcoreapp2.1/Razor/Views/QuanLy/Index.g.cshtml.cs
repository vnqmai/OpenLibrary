#pragma checksum "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\QuanLy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3671032cfd1fed522c9927e5760913c16b137851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLy_Index), @"mvc.1.0.view", @"/Views/QuanLy/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QuanLy/Index.cshtml", typeof(AspNetCore.Views_QuanLy_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3671032cfd1fed522c9927e5760913c16b137851", @"/Views/QuanLy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5578d4cd3c929c1a9d9ad21fd42e0e00baf0f", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\QuanLy\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 105, true);
            WriteLiteral("\r\n<br />\r\n<h2>Các chức năng của Quản lý</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 148, "\"", 189, 1);
#line 11 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\QuanLy\Index.cshtml"
WriteAttributeValue("", 155, Url.Action("ListYeuCau","QuanLy"), 155, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(190, 48, true);
            WriteLiteral(">Thống kê yêu cầu mua sách</a><br />\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 238, "\"", 277, 1);
#line 12 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\QuanLy\Index.cshtml"
WriteAttributeValue("", 245, Url.Action("ListSach","QuanLy"), 245, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(278, 35, true);
            WriteLiteral(">Quản lý sách</a><br />\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 313, "\"", 354, 1);
#line 13 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\QuanLy\Index.cshtml"
WriteAttributeValue("", 320, Url.Action("ListPhanBo","QuanLy"), 320, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(355, 35, true);
            WriteLiteral(">Phân bổ sách</a><br />\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 390, "\"", 431, 1);
#line 14 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\QuanLy\Index.cshtml"
WriteAttributeValue("", 397, Url.Action("ListDocGia","QuanLy"), 397, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(432, 111, true);
            WriteLiteral(">Quản lý độc giả</a><br />\r\n    </div>\r\n</div>\r\n\r\n<style>\r\n    a {\r\n        font-size: 30px;\r\n    }\r\n</style>\r\n");
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
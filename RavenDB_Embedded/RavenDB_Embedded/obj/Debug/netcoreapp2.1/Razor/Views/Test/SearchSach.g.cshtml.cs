#pragma checksum "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80b72c3ff5840db2f6ad2129a52de52d68aaf8a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_SearchSach), @"mvc.1.0.view", @"/Views/Test/SearchSach.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/SearchSach.cshtml", typeof(AspNetCore.Views_Test_SearchSach))]
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
#line 1 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\_ViewImports.cshtml"
using RavenDB_Embedded;

#line default
#line hidden
#line 2 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
using RavenDB_Embedded.Models;

#line default
#line hidden
#line 3 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b72c3ff5840db2f6ad2129a52de52d68aaf8a0", @"/Views/Test/SearchSach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5578d4cd3c929c1a9d9ad21fd42e0e00baf0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_SearchSach : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RavenDB_Embedded.Models.SearchSachView>>
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
#line 5 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
  
    ViewData["Title"] = "SearchSach";

#line default
#line hidden
            BeginContext(248, 263, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th></th>
            <th>Tên sách</th>
            <th>Tác Giả</th>
            <th>Giới thiệu</th>
            <th>SL còn</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(560, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(598, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbe69e5cf1e842ac851957e5d03f9bdb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 608, "~/images/", 608, 9, true);
#line 24 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
AddHtmlAttributeValue("", 617, item.Hinh, 617, 10, false);

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
            BeginContext(658, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(686, 12, false);
#line 25 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
               Write(item.TenSach);

#line default
#line hidden
            EndContext();
            BeginContext(698, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(726, 11, false);
#line 26 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
               Write(item.TacGia);

#line default
#line hidden
            EndContext();
            BeginContext(737, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(765, 14, false);
#line 27 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
               Write(item.GioiThieu);

#line default
#line hidden
            EndContext();
            BeginContext(779, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(807, 15, false);
#line 28 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
               Write(item.SoLuongCon);

#line default
#line hidden
            EndContext();
            BeginContext(822, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 873, "\"", 890, 1);
#line 30 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
WriteAttributeValue("", 878, item.MaSach, 878, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(891, 84, true);
            WriteLiteral(" class=\"masach btn btn-default\">Mượn</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 33 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibrary\RavenDB_Embedded\RavenDB_Embedded\Views\Test\SearchSach.cshtml"
        }

#line default
#line hidden
            BeginContext(986, 624, true);
            WriteLiteral(@"    </tbody>
</table>

<script>
    $(function () {
        $(""tr td a"").on(""click"", function () {
            //if ($(""this"").attr(""id""))
            var sl = prompt(""Nhập số lượng: "");
            $.ajax({
                url: ""/Test/AddPMSItem"",
                data: { sach_sl: $(this).attr(""id"") + ""-"" + sl },
                success: function (response) {
                    if (response.message !== ""Failed"") {
                        $(""#giosach"").html(response);
                    }
                }
            });
            $("".popup"").removeClass(""hidden"");
        });
    })
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RavenDB_Embedded.Models.SearchSachView>> Html { get; private set; }
    }
}
#pragma warning restore 1591

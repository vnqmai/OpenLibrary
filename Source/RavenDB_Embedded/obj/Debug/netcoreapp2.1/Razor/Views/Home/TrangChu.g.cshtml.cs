#pragma checksum "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a5629e436682a2db009626d7e6f70cd17c99708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TrangChu), @"mvc.1.0.view", @"/Views/Home/TrangChu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TrangChu.cshtml", typeof(AspNetCore.Views_Home_TrangChu))]
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
#line 1 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a5629e436682a2db009626d7e6f70cd17c99708", @"/Views/Home/TrangChu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5578d4cd3c929c1a9d9ad21fd42e0e00baf0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TrangChu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
  
    ViewData["Title"] = "TrangChu";

#line default
#line hidden
            BeginContext(154, 301, true);
            WriteLiteral(@"

<hr />
<div class=""chat col-md-12 "">
    <div id=""messagesList"" class=""chatcontent"">

    </div>
</div>
<div class=""chatcontrol"">
    <textarea id=""message"" class=""chatmess form-control""></textarea>
    <input type=""button"" value=""Gửi"" id=""btnsend"" class=""chatsendbtn"" />
</div>
<hr />
");
            EndContext();
            BeginContext(455, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f71ce1037e1742a0abe772469e8520af", async() => {
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
            BeginContext(506, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(508, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "431a7de833674662a2cbe088afe5ab03", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(569, 120, true);
            WriteLiteral("\r\n\r\n<script>\r\n    var connection = new signalR.HubConnectionBuilder().withUrl(\"/ChatHub\").build();\r\n\r\n    var docgia = \'");
            EndContext();
            BeginContext(690, 58, false);
#line 25 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
             Write(HttpContextAccessor.HttpContext.Session.GetString("TenDN"));

#line default
#line hidden
            EndContext();
            BeginContext(748, 1650, true);
            WriteLiteral(@"';
    docgia = docgia.replace(""&quot;"", """").replace(""&quot;"", """");

    connection.on(""NhanTinNhan"", function (name, mess) {
        var p = document.createElement(""p"");
        p.textContent = name + "" says "" + mess;
        document.getElementById(""messagesList"").appendChild(p);
    });

    connection.start();

    document.getElementById(""btnsend"").addEventListener(""click"", function (e) {
        var name = docgia;
        var message = document.getElementById(""message"").value;
        connection.invoke(""GuiTinNhan"", name, message).catch(function (e) {
            return console.error(e.toString());
        });
        e.preventDefault();
    });
</script>

<style>
    .chat {
        border: 1px solid #ccc;
        padding: 10px;
        margin-top: 10px;
        margin-bottom: 10px;
        height: 200px;
        border-radius: 10px 11px;
        overflow-y: scroll;
    }

    .chatcontrol {
        text-align: center;
    }

    #message {
        margin: auto;
  ");
            WriteLiteral(@"      margin-bottom: 10px;
    }
</style>
<script>
    $(function () {
        $(""#btnsend"").on(""click"", function () {
            //$(""#chatcontrol"").attr(""bottom"")=""0px"";
            $("".chat"").animate({ scrollTop: $("".chat"")[0].scrollHeight }, 1000);
        });
    });
</script>


<div class=""maincontent-area"">
    
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""latest-product"">
                    <h2 class=""section-title"" style=""font-family: Tahoma"">Sách mới cập nhật</h2>
                    <div class=""product-carousel"">
");
            EndContext();
#line 84 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
                          
                            List<Sach> s = RavenDBHelper.ListSach();
                            foreach (Sach x in s)
                            {

#line default
#line hidden
            BeginContext(2578, 169, true);
            WriteLiteral("                                <div class=\"single-product\">\r\n                                    <div class=\"product-f-image\">\r\n                                        ");
            EndContext();
            BeginContext(2747, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4bc68ac2254247d8b1021fdda5f0983e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2757, "~/images/", 2757, 9, true);
#line 90 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
AddHtmlAttributeValue("", 2766, x.Hinh, 2766, 7, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2782, 117, true);
            WriteLiteral("\r\n                                        <div class=\"product-hover\">\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2899, "\"", 2947, 3);
#line 92 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
WriteAttributeValue("", 2906, Url.Action("XemChiTiet","Test"), 2906, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 2938, "?id=", 2938, 4, true);
#line 92 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
WriteAttributeValue("", 2942, x.Id, 2942, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2948, 211, true);
            WriteLiteral(" class=\"view-details-link\"><i class=\"fa fa-link\"></i> Xem chi tiết sách</a>\r\n                                        </div>\r\n                                    </div>\r\n                                    <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3159, "\"", 3207, 3);
#line 95 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
WriteAttributeValue("", 3166, Url.Action("XemChiTiet","Test"), 3166, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 3198, "?id=", 3198, 4, true);
#line 95 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
WriteAttributeValue("", 3202, x.Id, 3202, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3208, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3210, 9, false);
#line 95 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
                                                                                       Write(x.TenSach);

#line default
#line hidden
            EndContext();
            BeginContext(3219, 51, true);
            WriteLiteral("</a></h2>\r\n                                </div>\r\n");
            EndContext();
#line 97 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\TrangChu.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(3328, 139, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div> <!-- End main content area -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

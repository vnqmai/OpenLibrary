#pragma checksum "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e7d69577008515d30c038d175dfaa8f94b13051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChonChiNhanh), @"mvc.1.0.view", @"/Views/Home/ChonChiNhanh.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ChonChiNhanh.cshtml", typeof(AspNetCore.Views_Home_ChonChiNhanh))]
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
#line 1 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e7d69577008515d30c038d175dfaa8f94b13051", @"/Views/Home/ChonChiNhanh.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5578d4cd3c929c1a9d9ad21fd42e0e00baf0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChonChiNhanh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
  
    ViewData["Title"] = "ChonChiNhanh";

#line default
#line hidden
            BeginContext(160, 47, true);
            WriteLiteral("\r\n<h2>Chọn chi nhánh mượn sách</h2>\r\n<hr />\r\n\r\n");
            EndContext();
#line 11 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
  
    string dg = HttpContextAccessor.HttpContext.Session.GetString("DocGia");
    PhieuMuonSach pm= RavenDBHelper.ListPhieuMuon(dg, "DangMuon").SingleOrDefault();
    if (pm != null)
    {
        string cn = pm.ChiNhanh;

#line default
#line hidden
            BeginContext(437, 78, true);
            WriteLiteral("        <select class=\"form-control\" id=\"slcn\" style=\"margin:auto\" disabled>\r\n");
            EndContext();
#line 18 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
              
                List<ChiNhanh> cns = RavenDBHelper.ListChiNhanh();
                foreach (ChiNhanh x in cns)
                {
                    if (x.Id == cn)
                    {

#line default
#line hidden
            BeginContext(723, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(747, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "732894bb23e44db0b4213153310eccb6", async() => {
                BeginContext(794, 13, false);
#line 24 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
                                                                 Write(x.TenChiNhanh);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
                           WriteLiteral(x.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(816, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(890, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(914, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e769b9cb1f464b0eaf58b39d46c53336", async() => {
                BeginContext(937, 13, false);
#line 28 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
                                         Write(x.TenChiNhanh);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
                           WriteLiteral(x.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(959, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
                    }
                }
            

#line default
#line hidden
            BeginContext(1018, 19, true);
            WriteLiteral("        </select>\r\n");
            EndContext();
#line 33 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1061, 69, true);
            WriteLiteral("        <select class=\"form-control\" id=\"slcn\" style=\"margin:auto\">\r\n");
            EndContext();
#line 37 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
              
                List<ChiNhanh> cns = RavenDBHelper.ListChiNhanh();
                foreach (ChiNhanh x in cns)
                {

#line default
#line hidden
            BeginContext(1278, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1298, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9109e474ecfa47b09a3d21f7952aa962", async() => {
                BeginContext(1321, 13, false);
#line 41 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
                                     Write(x.TenChiNhanh);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
                       WriteLiteral(x.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1343, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1379, 19, true);
            WriteLiteral("        </select>\r\n");
            EndContext();
#line 45 "C:\Users\vnqma\OneDrive\Documents\GitHub\OpenLibraryComplete\RavenDB_Embedded\RavenDB_Embedded\Views\Home\ChonChiNhanh.cshtml"
    }

#line default
#line hidden
            BeginContext(1415, 122, true);
            WriteLiteral("<div style=\"text-align:center\">\r\n    <input type=\"button\" value=\"Chọn\" class=\"btn btn-primary\" id=\"btnChonCN\" />\r\n</div>\r\n");
            EndContext();
            BeginContext(1537, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a398be7fc43041b6ad483ac942099be8", async() => {
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
            BeginContext(1588, 481, true);
            WriteLiteral(@"
<script>
    $(function () {
        $(""#btnChonCN"").on(""click"", function () {
            $.ajax({
                        url: ""/Home/LuuChiNhanh"",
                data: { chinhanh: $(""#slcn"").val() },
                success: function (response) {
                                if (response == true)
                                    location.href = ""../Test"";
                            }
                        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

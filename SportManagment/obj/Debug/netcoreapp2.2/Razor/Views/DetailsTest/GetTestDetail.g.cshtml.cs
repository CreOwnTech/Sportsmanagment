#pragma checksum "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdaded8cecac2da20278f689edde87fb07cd0071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DetailsTest_GetTestDetail), @"mvc.1.0.view", @"/Views/DetailsTest/GetTestDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DetailsTest/GetTestDetail.cshtml", typeof(AspNetCore.Views_DetailsTest_GetTestDetail))]
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
#line 1 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\_ViewImports.cshtml"
using SportManagment;

#line default
#line hidden
#line 2 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\_ViewImports.cshtml"
using SportManagment.Models;

#line default
#line hidden
#line 1 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdaded8cecac2da20278f689edde87fb07cd0071", @"/Views/DetailsTest/GetTestDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc96157c1774ecefc507680a3ce58e71466d7b3c", @"/Views/_ViewImports.cshtml")]
    public class Views_DetailsTest_GetTestDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataSet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DetailsOfTest.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml"
  
    ViewData["Title"] = "GetTestDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 619, true);
            WriteLiteral(@"<div class=""text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3""></div>
            <div class=""col-lg-6"">




                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">Type</th>
                            <th scope=""col"">Column heading</th>
                            <th scope=""col"">Column heading</th>
                            <th scope=""col"">Column heading</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 26 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml"
                         foreach (DataRow row in Model.Tables[0].Rows)
                        {

#line default
#line hidden
            BeginContext(850, 103, true);
            WriteLiteral("                            <tr class=\"table-active\">\r\n                                <th scope=\"row\">");
            EndContext();
            BeginContext(954, 14, false);
#line 29 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml"
                                           Write(row["Ranking"]);

#line default
#line hidden
            EndContext();
            BeginContext(968, 55, true);
            WriteLiteral("</th>\r\n                                <th scope=\"row\">");
            EndContext();
            BeginContext(1024, 15, false);
#line 30 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml"
                                           Write(row["Distance"]);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 156, true);
            WriteLiteral("</th>\r\n                                <td>Column content</td>\r\n                                <td>Column content</td>\r\n                            </tr>\r\n");
            EndContext();
#line 34 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml"
                        }

#line default
#line hidden
            BeginContext(1222, 1213, true);
            WriteLiteral(@"

                    </tbody>
                </table>
            </div>
            <div class=""col-lg-3""></div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3""></div>
            <div class=""col-lg-6""><button type=""button"" class=""btn btn-success btn-sm btn-block"" id=""myBtn"">ADD NEW ATHELET TO TEST</button></div>
            <div class=""col-lg-3""></div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4""></div>
            <div class=""col-lg-4"">
                <!-- The Modal -->
                <div id=""myModal"" class=""modal"">

                    <!-- Modal content -->
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            ADD NEW ATHLETE TO TEST <span class=""close"">&times;</span>

                        </div>
                        <div class=""modal-body"">

                 ");
            WriteLiteral("           <div class=\"form-group\">\r\n                                <label for=\"exampleSelect1\">Name</label>\r\n\r\n                                <select class=\"form-control\" id=\"Ranking\">\r\n");
            EndContext();
#line 69 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml"
                                     foreach (DataRow row in Model.Tables[0].Rows)
                                    {

#line default
#line hidden
            BeginContext(2558, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2598, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdaded8cecac2da20278f689edde87fb07cd00718213", async() => {
                BeginContext(2634, 17, false);
#line 71 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml"
                                                                      Write(row["Users_Name"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 71 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml"
                                           WriteLiteral(row["Users_Name"]);

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
            BeginContext(2660, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 72 "E:\Creown\SportManagment\SportManagment\SportManagment\Views\DetailsTest\GetTestDetail.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2701, 679, true);
            WriteLiteral(@"                                </select>
                            </div>
                            <label for=""exampleSelect1"">Distance (meter)</label>
                            <input class=""form-control"" type=""text"" id=""Distance"">
                            <br />
                            <button type=""button"" class=""btn btn-success"" id=""SubmitTestDetail"">SAVE</button>
                        </div>

                    </div>

                </div>
            </div>
            <div class=""col-lg-4""></div>
        </div>
    </div>
</div>
<script type=""text/javascript"" src=""https://cdn.jsdelivr.net/jquery/latest/jquery.min.js""></script>
");
            EndContext();
            BeginContext(3380, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdaded8cecac2da20278f689edde87fb07cd007111217", async() => {
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
            BeginContext(3425, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataSet> Html { get; private set; }
    }
}
#pragma warning restore 1591

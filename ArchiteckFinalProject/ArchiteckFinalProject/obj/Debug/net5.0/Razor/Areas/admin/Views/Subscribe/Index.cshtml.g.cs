#pragma checksum "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f90c6b09e3b6a1bc8061f6691b4707ac812f3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Subscribe_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Subscribe/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\_ViewImports.cshtml"
using ArchiteckFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\_ViewImports.cshtml"
using ArchiteckFinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\_ViewImports.cshtml"
using ArchiteckFinalProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\_ViewImports.cshtml"
using ArchiteckFinalProject.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f90c6b09e3b6a1bc8061f6691b4707ac812f3a", @"/Areas/admin/Views/Subscribe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bce6e66deb8e2f5948b4d07499bb6529f2c9288b", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Subscribe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Subscribe>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Subscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item border-0 text-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMailAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item border-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-page"">
    <div class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""page-title-box"">
                        <div class=""page-title-right"">
                            <ol class=""breadcrumb m-0"">
                                <li class=""breadcrumb-item""><a href=""javascript: void(0);"">Zircos</a></li>
                                <li class=""breadcrumb-item""><a href=""javascript: void(0);"">Email </a></li>
                                <li class=""breadcrumb-item active"">Inbox</li>
                            </ol>
                        </div>
                        <h4 class=""page-title"">Inbox</h4>
                    </div>
                </div>
            </div>
            <div class=""col-lg-12"">
");
#nullable restore
#line 27 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetString("NullIdError") != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                   Write(HttpContextAccessor.HttpContext.Session.GetString("NullIdError"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 32 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                    HttpContextAccessor.HttpContext.Session.Remove("NullIdError");
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetString("NullDataError") != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                   Write(HttpContextAccessor.HttpContext.Session.GetString("NullDataError"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 40 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                    HttpContextAccessor.HttpContext.Session.Remove("NullDataError");
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <hr />

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""mails card-box"">

                        <div class=""table-box"">
                            <div class=""table-detail d-flex"" style=""justify-content:center;"">
                                <div class=""p-4"">

                                    <div class=""list-group mail-list mt-3"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53f90c6b09e3b6a1bc8061f6691b4707ac812f3a10192", async() => {
                WriteLiteral("<i class=\"fas fa-download font-13 mr-2\"></i>Inbox");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            \r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53f90c6b09e3b6a1bc8061f6691b4707ac812f3a11778", async() => {
                WriteLiteral("<i class=\"far fa-paper-plane font-13 mr-2\"></i>Sent Mail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                     </div>



                                </div>
                            </div>

                            <div class=""table-detail mail-right"">

                                <div class=""table-responsive mt-3 ""  >
                                    <table class=""table table-hover mails m-0 ""  >
                                        <thead class=""thead-light"">
                                            <tr>
                                                <th scope=""col"">#</th>
                                                <th>Email</th>
                                                <th>Date</th>

                                            </tr>
                                        </thead>

                                        <tbody>

");
#nullable restore
#line 79 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                                              
                                                int i = 0;
                                                foreach (var subscribe in Model)
                                                {
                                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                        <tr class=\"unread\">\r\n                                                                                            <td scope=\"row\">");
#nullable restore
#line 85 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                            <td>\r\n                                                                                                <a href=\"email-read.html\" class=\"email-name\">");
#nullable restore
#line 87 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                                                                                                                                        Write(subscribe.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                                                            </td>

                                                                                            <td class=""text-right mail-time"">
                                                                                                ");
#nullable restore
#line 91 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                                                                                           Write(subscribe.CreatedDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                                            </td>\r\n                                                                                        </tr>\r\n");
#nullable restore
#line 94 "C:\Users\CASPER\Desktop\Architeck-BackEnd\ArchiteckFinalProject\ArchiteckFinalProject\Areas\admin\Views\Subscribe\Index.cshtml"
                                                }
                                             

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Subscribe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
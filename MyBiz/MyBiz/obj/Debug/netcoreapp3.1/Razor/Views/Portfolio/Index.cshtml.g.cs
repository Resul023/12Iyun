#pragma checksum "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1588f4bccbb0551ad5a3f4e28613422674e9e70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\_ViewImports.cshtml"
using MyBiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\_ViewImports.cshtml"
using MyBiz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\_ViewImports.cshtml"
using MyBiz.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1588f4bccbb0551ad5a3f4e28613422674e9e70", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c0689abe03c74d7b3a69a5048be20a934e98bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">
                <h2>Portfolio Details</h2>
                <ol>
                    <li><a href=""index.html"">Home</a></li>
                    <li>Portfolio Details</li>
                </ol>
            </div>
             
        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Portfolio Details Section ======= -->
    <section id=""portfolio-details"" class=""portfolio-details"">
        <div class=""container"">

            <div class=""row gy-4"">

                <div class=""col-lg-8"">
                    <div class=""portfolio-details-slider swiper"">
                        <div class=""swiper-wrapper align-items-center"">
                            
                           <div class=""swiper-slide"">
                               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d1588f4bccbb0551ad5a3f4e28613422674e9e704823", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1074, "~/upload/portfolio/", 1074, 19, true);
#nullable restore
#line 33 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 1093, Model.productImage.FirstOrDefault(x=>x.PortfolioId == Model.Id ).Name, 1093, 70, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                        <div class=""swiper-pagination""></div>
                    </div>
                </div>

                <div class=""col-lg-4"">
                    <div class=""portfolio-info"">
                        <h3>");
#nullable restore
#line 43 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\Portfolio\Index.cshtml"
                       Write(Model.ProductTitle1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <ul>\r\n                            <li><strong>Category</strong>: ");
#nullable restore
#line 45 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\Portfolio\Index.cshtml"
                                                      Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><strong>Client</strong>: ");
#nullable restore
#line 46 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\Portfolio\Index.cshtml"
                                                    Write(Model.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><strong>Project date</strong>: ");
#nullable restore
#line 47 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\Portfolio\Index.cshtml"
                                                          Write(Model.ProjectDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><strong>Project URL</strong>: <a href=\"#\">");
#nullable restore
#line 48 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\Portfolio\Index.cshtml"
                                                                     Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"portfolio-description\">\r\n                        <h2>");
#nullable restore
#line 52 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\Portfolio\Index.cshtml"
                       Write(Model.PorjectTitle2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>\r\n                            ");
#nullable restore
#line 54 "C:\Users\User\Desktop\ProjectMybiz\MyBiz\MyBiz\Views\Portfolio\Index.cshtml"
                       Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </section><!-- End Portfolio Details Section -->\r\n\r\n</main><!-- End #main -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591
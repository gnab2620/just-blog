#pragma checksum "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37384d91ff4f9630ab0ceb88f6cc5dac3d5b7186"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_PostsByTagUrlSlug), @"mvc.1.0.view", @"/Views/Post/PostsByTagUrlSlug.cshtml")]
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
#line 1 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\_ViewImports.cshtml"
using FA.JustBlog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\_ViewImports.cshtml"
using FA.JustBlog.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37384d91ff4f9630ab0ceb88f6cc5dac3d5b7186", @"/Views/Post/PostsByTagUrlSlug.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0302ab5c6ac4581fd0f3c7205bb5637c4cb2e6e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_PostsByTagUrlSlug : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FA.JustBlog.Web.Models.PostTagMapAndPost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37384d91ff4f9630ab0ceb88f6cc5dac3d5b71865248", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 287, "\"", 297, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 326, "\"", 336, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <title>Clean Blog - Start Bootstrap Theme</title>
    <link rel=""icon"" type=""image/x-icon"" href=""assets/favicon.ico"" />
    <!-- Font Awesome icons (free version)-->
    <script src=""https://use.fontawesome.com/releases/v5.15.4/js/all.js"" crossorigin=""anonymous""></script>
    <!-- Google fonts-->
    <link href=""https://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic"" rel=""stylesheet"" type=""text/css"" />
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800"" rel=""stylesheet"" type=""text/css"" />
    <!-- Core theme CSS (includes Bootstrap)-->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "37384d91ff4f9630ab0ceb88f6cc5dac3d5b71866703", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37384d91ff4f9630ab0ceb88f6cc5dac3d5b71868585", async() => {
                WriteLiteral("\r\n    <!-- Navigation-->\r\n");
                WriteLiteral(@"    <!-- Page Header-->
    <header class=""masthead"" style=""background-image: url('assets/img/home-bg.jpg')"">
        <div class=""container position-relative px-4 px-lg-5"">
            <div class=""row gx-4 gx-lg-5 justify-content-center"">
                <div class=""col-md-10 col-lg-8 col-xl-7"">
                    <div class=""site-heading"">
                        <h1>");
#nullable restore
#line 48 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                       Write(Model.TagName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                        <span class=\"subheading\">Found ");
#nullable restore
#line 49 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                                                  Write(Model.CardForPostVM.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" Result</span>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- Main Content-->
    <div class=""container px-4 px-lg-5"">
        <div class=""row gx-4 gx-lg-5 justify-content-center"">
            <div class=""col-md-10 col-lg-8 col-xl-7"">

");
#nullable restore
#line 60 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                 if (Model.CardForPostVM.Count!=0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"list-group\">\r\n");
#nullable restore
#line 63 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                         foreach (var item in Model.CardForPostVM)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <hr class=\"my-4\" />\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 3408, "\"", 3473, 6);
                WriteAttributeValue("", 3415, "../post/", 3415, 8, true);
#nullable restore
#line 67 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
WriteAttributeValue("", 3423, item.PostOn.Year, 3423, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3440, "/", 3440, 1, true);
#nullable restore
#line 67 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
WriteAttributeValue("", 3441, item.PostOn.Month, 3441, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3459, "/", 3459, 1, true);
#nullable restore
#line 67 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
WriteAttributeValue("", 3460, item.UrlSlug, 3460, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action\">\r\n                                <div class=\"d-flex w-100 justify-content-between\">\r\n                                    <h1 class=\"mb-1\">\r\n                                        ");
#nullable restore
#line 70 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </h1>\r\n\r\n\r\n");
                WriteLiteral("                                </div>\r\n                            </a>\r\n                            <div class=\"list-group-item \">\r\n\r\n                                <div> Category:  <a>");
#nullable restore
#line 82 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                                               Write(item.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></div>\r\n                                <div>\r\n                                    Tag:\r\n");
#nullable restore
#line 85 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                                     foreach (var i in item.ListTag)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span class=\"border border-dark\"> <a>");
#nullable restore
#line 87 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                                                                        Write(i.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></span>\r\n");
#nullable restore
#line 88 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <p class=\"mb-1\">");
#nullable restore
#line 91 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                                           Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <small>");
#nullable restore
#line 92 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                                  Write(item.ViewCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("  views</small>\r\n                            </div>\r\n");
#nullable restore
#line 94 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n");
#nullable restore
#line 97 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div>These is no posts for Tag name: ");
#nullable restore
#line 100 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                                                    Write(Model.TagName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 101 "C:\Users\PTG\Desktop\Fresher.Net\EntityFramework\FA.JustBlog\FA.JustBlog.Web\Views\Post\PostsByTagUrlSlug.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <!-- Divider-->
                <hr class=""my-4"" />
                <!-- Pager-->
                <div class=""d-flex justify-content-end mb-4""><a class=""btn btn-primary text-uppercase"" href=""#!"">Older Posts ???</a></div>
            </div>
        </div>

    </div>
    <!-- Footer-->
    <footer class=""border-top"">
        <div class=""container px-4 px-lg-5"">
            <div class=""row gx-4 gx-lg-5 justify-content-center"">
                <div class=""col-md-10 col-lg-8 col-xl-7"">
                    <ul class=""list-inline text-center"">
                        <li class=""list-inline-item"">
                            <a href=""#!"">
                                <span class=""fa-stack fa-lg"">
                                    <i class=""fas fa-circle fa-stack-2x""></i>
                                    <i class=""fab fa-twitter fa-stack-1x fa-inverse""></i>
                                </span>
                            </a>
                        </li>
               ");
                WriteLiteral(@"         <li class=""list-inline-item"">
                            <a href=""#!"">
                                <span class=""fa-stack fa-lg"">
                                    <i class=""fas fa-circle fa-stack-2x""></i>
                                    <i class=""fab fa-facebook-f fa-stack-1x fa-inverse""></i>
                                </span>
                            </a>
                        </li>
                        <li class=""list-inline-item"">
                            <a href=""#!"">
                                <span class=""fa-stack fa-lg"">
                                    <i class=""fas fa-circle fa-stack-2x""></i>
                                    <i class=""fab fa-github fa-stack-1x fa-inverse""></i>
                                </span>
                            </a>
                        </li>
                    </ul>
                    <div class=""small text-center text-muted fst-italic"">Copyright &copy; Your Website 2021</div>
                </div");
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </footer>\r\n    <!-- Bootstrap core JS-->\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"></script>\r\n    <!-- Core theme JS-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37384d91ff4f9630ab0ceb88f6cc5dac3d5b718618801", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37384d91ff4f9630ab0ceb88f6cc5dac3d5b718619901", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FA.JustBlog.Web.Models.PostTagMapAndPost> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Article\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9ec592a773c3a4d50a7b88860bd08f8e1d3b864"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Details), @"mvc.1.0.view", @"/Views/Article/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Article/Details.cshtml", typeof(AspNetCore.Views_Article_Details))]
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
#line 1 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\_ViewImports.cshtml"
using ecosmetics;

#line default
#line hidden
#line 2 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\_ViewImports.cshtml"
using ecosmetics.Models;

#line default
#line hidden
#line 5 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\_ViewImports.cshtml"
using ecosmetics.Services.Pictures.Models;

#line default
#line hidden
#line 6 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\_ViewImports.cshtml"
using ecosmetics.Services.Articles.Models;

#line default
#line hidden
#line 7 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\_ViewImports.cshtml"
using ecosmetics.Services.Categories.Models;

#line default
#line hidden
#line 1 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Article\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9ec592a773c3a4d50a7b88860bd08f8e1d3b864", @"/Views/Article/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ad5a0d29faae9e45654b802d3de161e6c4bcf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ecosmetics.Services.Articles.Models.ArticleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Article\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(233, 96, true);
            WriteLiteral("\r\n<section class=\"articles-details-wrapper\">\r\n    <div class=\"main-nav\">\r\n        <h1>Articles: ");
            EndContext();
            BeginContext(330, 11, false);
#line 12 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Article\Details.cshtml"
                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(341, 39, true);
            WriteLiteral("</h1>\r\n\r\n        <ul>\r\n            <li>");
            EndContext();
            BeginContext(380, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ec592a773c3a4d50a7b88860bd08f8e1d3b8645997", async() => {
                BeginContext(425, 19, false);
#line 15 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Article\Details.cshtml"
                                                       Write(Localizer["Начало"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(448, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(471, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ec592a773c3a4d50a7b88860bd08f8e1d3b8647773", async() => {
                BeginContext(520, 19, false);
#line 16 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Article\Details.cshtml"
                                                           Write(Localizer["Статии"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(543, 162, true);
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n\r\n    <section class=\"article-details-container\">\r\n        <div class=\"article-content\">\r\n\r\n            <img class=\"article-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 705, "\"", 729, 1);
#line 23 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Article\Details.cshtml"
WriteAttributeValue("", 711, Model.Picture.Url, 711, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(730, 103, true);
            WriteLiteral(" />\r\n\r\n            <div class=\"article-text-wrapper\">\r\n                <p class=\"article-details-text\">");
            EndContext();
            BeginContext(834, 23, false);
#line 26 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Article\Details.cshtml"
                                           Write(Html.Raw(Model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(857, 74, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n</section>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ecosmetics.Services.Articles.Models.ArticleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
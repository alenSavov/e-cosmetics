#pragma checksum "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6deabe4163e67c6eb495275adbbe1922d4daca5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
#line 1 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\_ViewImports.cshtml"
using e_cosmetics;

#line default
#line hidden
#line 2 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\_ViewImports.cshtml"
using e_cosmetics.Models;

#line default
#line hidden
#line 3 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\_ViewImports.cshtml"
using e_cosmetics.Services.Pictures.Models;

#line default
#line hidden
#line 4 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\_ViewImports.cshtml"
using e_cosmetics.Services.Articles.Models;

#line default
#line hidden
#line 5 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\_ViewImports.cshtml"
using e_cosmetics.Services.Categories.Models;

#line default
#line hidden
#line 1 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6deabe4163e67c6eb495275adbbe1922d4daca5b", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490524f201f830d15cf2fa9eafbd8279bf0ffee5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<e_cosmetics.Services.Products.Models.ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(187, 107, true);
            WriteLiteral("\r\n<section class=\"details-wrapper\">\r\n    <div class=\"main-nav\" id=\"main-nav-product-details\">\r\n        <h1>");
            EndContext();
            BeginContext(295, 10, false);
#line 11 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(305, 72, true);
            WriteLiteral("</h1>\r\n\r\n        <ul id=\"main-nav-product-details-ul\">\r\n            <li>");
            EndContext();
            BeginContext(377, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6deabe4163e67c6eb495275adbbe1922d4daca5b6005", async() => {
                BeginContext(422, 19, false);
#line 14 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
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
            BeginContext(445, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(468, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6deabe4163e67c6eb495275adbbe1922d4daca5b7783", async() => {
                BeginContext(552, 21, false);
#line 15 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
                                                                                              Write(Localizer["Продукти"]);

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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
                                                                    WriteLiteral(Model.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(577, 53, true);
            WriteLiteral("</li>\r\n            <li><p id=\"main-nav-product-name\">");
            EndContext();
            BeginContext(631, 10, false);
#line 16 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
                                         Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(641, 160, true);
            WriteLiteral("</p></li>\r\n        </ul>\r\n    </div>\r\n\r\n    <section class=\"product-details-container\">\r\n        <div class=\"product-details-title-box\">\r\n            <h2 id=\"\">");
            EndContext();
            BeginContext(802, 10, false);
#line 22 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(812, 165, true);
            WriteLiteral("</h2>\r\n            <p class=\"sub-title\">Popular</p>\r\n        </div>\r\n\r\n        <div class=\"product-details-content\">\r\n            <div class=\"details-content-box\">\r\n");
            EndContext();
#line 28 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
                 foreach (var picture in Model.Pictures)
                {

#line default
#line hidden
            BeginContext(1054, 50, true);
            WriteLiteral("                    <img class=\"product-image-box\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1104, "\"", 1122, 1);
#line 30 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
WriteAttributeValue("", 1110, picture.Url, 1110, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1123, 27, true);
            WriteLiteral(" alt=\"Product Picture\" />\r\n");
            EndContext();
#line 31 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1740, 162, true);
            WriteLiteral("            </div>\r\n\r\n\r\n            <div class=\"product-description\" id=\"product-description\">\r\n                \r\n                <p id=\"text-styles-description\">");
            EndContext();
            BeginContext(1903, 28, false);
#line 50 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
                                           Write(Localizer[Model.Description]);

#line default
#line hidden
            EndContext();
            BeginContext(1931, 80, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<e_cosmetics.Services.Products.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66efbed35612b846449954ef9f874fe67e521690"
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
#line 1 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66efbed35612b846449954ef9f874fe67e521690", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ad5a0d29faae9e45654b802d3de161e6c4bcf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ecosmetics.Services.Products.Models.ProductViewModel>
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
#line 5 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(186, 124, true);
            WriteLiteral("\r\n<section class=\"details-wrapper\">\r\n    <div class=\"main-nav animated flipInX delay-0.5s\" id=\"main-nav-product-details \">\r\n");
            EndContext();
#line 11 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
          
            var currentCulture = ViewData["Culture"];
            if (currentCulture.ToString() == GlobalConstants.cultureEn)
            {

#line default
#line hidden
            BeginContext(465, 20, true);
            WriteLiteral("                <h1>");
            EndContext();
            BeginContext(486, 12, false);
#line 15 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
               Write(Model.NameEn);

#line default
#line hidden
            EndContext();
            BeginContext(498, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 16 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(553, 20, true);
            WriteLiteral("                <h1>");
            EndContext();
            BeginContext(574, 10, false);
#line 19 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(584, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 20 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
            }


#line default
#line hidden
            BeginContext(608, 71, true);
            WriteLiteral("            <ul id=\"main-nav-product-details-ul\">\r\n                <li>");
            EndContext();
            BeginContext(679, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66efbed35612b846449954ef9f874fe67e5216907329", async() => {
                BeginContext(724, 19, false);
#line 23 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
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
            BeginContext(747, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(774, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66efbed35612b846449954ef9f874fe67e5216909114", async() => {
                BeginContext(858, 21, false);
#line 24 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
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
#line 24 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
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
            BeginContext(883, 9, true);
            WriteLiteral("</li>\r\n\r\n");
            EndContext();
#line 26 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                 if (currentCulture.ToString() == GlobalConstants.cultureEn)
                {

#line default
#line hidden
            BeginContext(989, 54, true);
            WriteLiteral("                    <li><p id=\"main-nav-product-name\">");
            EndContext();
            BeginContext(1044, 12, false);
#line 28 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                                                 Write(Model.NameEn);

#line default
#line hidden
            EndContext();
            BeginContext(1056, 11, true);
            WriteLiteral("</p></li>\r\n");
            EndContext();
#line 29 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1127, 54, true);
            WriteLiteral("                    <li><p id=\"main-nav-product-name\">");
            EndContext();
            BeginContext(1182, 10, false);
#line 32 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                                                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1192, 11, true);
            WriteLiteral("</p></li>\r\n");
            EndContext();
#line 33 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1222, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
            BeginContext(1252, 112, true);
            WriteLiteral("    </div>\r\n\r\n    <section class=\"product-details-container\">\r\n        <div class=\"product-details-title-box\">\r\n");
            EndContext();
#line 40 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
              
                if (currentCulture.ToString() == GlobalConstants.cultureEn)
                {

#line default
#line hidden
            BeginContext(1476, 30, true);
            WriteLiteral("                    <h2 id=\"\">");
            EndContext();
            BeginContext(1507, 12, false);
#line 43 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                         Write(Model.NameEn);

#line default
#line hidden
            EndContext();
            BeginContext(1519, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 44 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1586, 30, true);
            WriteLiteral("                    <h2 id=\"\">");
            EndContext();
            BeginContext(1617, 10, false);
#line 47 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                         Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1627, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 48 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1668, 158, true);
            WriteLiteral("            <p class=\"sub-title\">Popular</p>\r\n        </div>\r\n\r\n        <div class=\"product-details-content\">\r\n            <div class=\"details-content-box\">\r\n");
            EndContext();
#line 56 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                 foreach (var picture in Model.Pictures)
                {

#line default
#line hidden
            BeginContext(1974, 50, true);
            WriteLiteral("                    <img class=\"product-image-box\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2024, "\"", 2042, 1);
#line 58 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
WriteAttributeValue("", 2030, picture.Url, 2030, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2043, 27, true);
            WriteLiteral(" alt=\"Product Picture\" />\r\n");
            EndContext();
#line 59 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(2089, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2117, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 62 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
              
                if (currentCulture.ToString() == GlobalConstants.cultureEn)
                {

#line default
#line hidden
            BeginContext(2251, 53, true);
            WriteLiteral("                    <div class=\"product-description\">");
            EndContext();
            BeginContext(2305, 29, false);
#line 65 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                                                Write(Html.Raw(Model.DescriptionEn));

#line default
#line hidden
            EndContext();
            BeginContext(2334, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 66 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2402, 53, true);
            WriteLiteral("                    <div class=\"product-description\">");
            EndContext();
            BeginContext(2456, 27, false);
#line 69 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                                                Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2483, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 70 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Product\Details.cshtml"
                }
            

#line default
#line hidden
            BeginContext(2525, 52, true);
            WriteLiteral("        </div>\r\n    </section>\r\n\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ecosmetics.Services.Products.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

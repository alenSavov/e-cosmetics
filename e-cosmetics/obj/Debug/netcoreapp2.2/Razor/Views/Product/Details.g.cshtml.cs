#pragma checksum "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d54372d5a621d1e23578d6e7161d206735a7102"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d54372d5a621d1e23578d6e7161d206735a7102", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddbe47edbce130a0ed2f78218a272f2d7d722fba", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<e_cosmetics.Services.Products.Models.ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(105, 77, true);
            WriteLiteral("\r\n<section class=\"details-wrapper\">\r\n    <div class=\"main-nav\">\r\n        <h1>");
            EndContext();
            BeginContext(183, 10, false);
#line 8 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(193, 39, true);
            WriteLiteral("</h1>\r\n\r\n        <ul>\r\n            <li>");
            EndContext();
            BeginContext(232, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d54372d5a621d1e23578d6e7161d206735a71025045", async() => {
                BeginContext(276, 4, true);
                WriteLiteral("Home");
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
            BeginContext(284, 171, true);
            WriteLiteral("</li>\r\n            <li><p>Details</p></li>\r\n        </ul>\r\n    </div>\r\n\r\n    <section class=\"product-details\">\r\n        <section class=\"black-box-title\">\r\n            <h2>");
            EndContext();
            BeginContext(456, 10, false);
#line 18 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(466, 141, true);
            WriteLiteral("</h2>\r\n            <p class=\"sub-title\">Details</p>\r\n        </section>\r\n\r\n        <ul class=\"black-box-content black-box-content-product\">\r\n");
            EndContext();
#line 23 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
             foreach (var picture in @Model.Pictures)
            {

#line default
#line hidden
            BeginContext(677, 74, true);
            WriteLiteral("                <li class=\"image-wrapper\">\r\n                    <span><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 751, "\"", 769, 1);
#line 26 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"
WriteAttributeValue("", 757, picture.Url, 757, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(770, 84, true);
            WriteLiteral(" class=\"product-picture\" width=\"250\" height=\"250\" /></span>\r\n                </li>\r\n");
            EndContext();
#line 28 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\Details.cshtml"

            }

#line default
#line hidden
            BeginContext(871, 49, true);
            WriteLiteral("        </ul>\r\n\r\n\r\n    </section>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<e_cosmetics.Services.Products.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

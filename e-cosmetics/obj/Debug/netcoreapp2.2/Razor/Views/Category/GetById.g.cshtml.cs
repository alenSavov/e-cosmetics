#pragma checksum "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c4da6cf4e5890fc385ef463e78d3d27b5526829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_GetById), @"mvc.1.0.view", @"/Views/Category/GetById.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/GetById.cshtml", typeof(AspNetCore.Views_Category_GetById))]
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
using e_cosmetics.Services.Categories.Models;

#line default
#line hidden
#line 4 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\_ViewImports.cshtml"
using e_cosmetics.Services.Pictures.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c4da6cf4e5890fc385ef463e78d3d27b5526829", @"/Views/Category/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4e0eb136c14b79d033e23078977a60cd4d54d82", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<e_cosmetics.Services.Products.Models.ProductCollectionViewModel>
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
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetById.cshtml"
  

    ViewData["Title"] = "Products";

#line default
#line hidden
            BeginContext(120, 125, true);
            WriteLiteral("\r\n<section class=\"products-wrapper\">\r\n    <div class=\"main-nav\">\r\n        <h1>Products</h1>\r\n\r\n        <ul>\r\n            <li>");
            EndContext();
            BeginContext(245, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c4da6cf4e5890fc385ef463e78d3d27b55268294671", async() => {
                BeginContext(289, 4, true);
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
            BeginContext(297, 186, true);
            WriteLiteral("</li>\r\n            <li><p>Products</p></li>\r\n        </ul>\r\n    </div>\r\n\r\n    <section class=\"products-section-wrapper\">\r\n\r\n        <section class=\"products-section\">\r\n            <ul>\r\n");
            EndContext();
#line 22 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetById.cshtml"
                 foreach (var product in @Model.Products)
                {

#line default
#line hidden
            BeginContext(561, 82, true);
            WriteLiteral("                    <li>\r\n                        <a class=\"product\" href=\"/\">\r\n\r\n");
            EndContext();
#line 27 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetById.cshtml"
                             foreach (var picture in product.Pictures.Take(1))
                            {
                                

#line default
#line hidden
            BeginContext(864, 36, true);
            WriteLiteral("                                <img");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 900, "\"", 942, 3);
            WriteAttributeValue("", 908, "background-image:url(", 908, 21, true);
#line 30 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetById.cshtml"
WriteAttributeValue("", 929, picture.Url, 929, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 941, ")", 941, 1, true);
            EndWriteAttribute();
            BeginContext(943, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 31 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetById.cshtml"

                            }

#line default
#line hidden
            BeginContext(981, 112, true);
            WriteLiteral("                            <div class=\"product-text\">\r\n                                <p class=\"product-name\">");
            EndContext();
            BeginContext(1094, 12, false);
#line 34 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetById.cshtml"
                                                   Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1106, 101, true);
            WriteLiteral("</p>\r\n                            </div>\r\n\r\n                        </a>\r\n                    </li>\r\n");
            EndContext();
#line 39 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetById.cshtml"
                }

#line default
#line hidden
            BeginContext(1226, 67, true);
            WriteLiteral("            </ul>\r\n        </section>\r\n    </section>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<e_cosmetics.Services.Products.Models.ProductCollectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

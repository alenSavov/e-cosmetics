#pragma checksum "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Category\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5b70729253a786c8ebaec147ee3fe0ff8e4220c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_GetAll), @"mvc.1.0.view", @"/Views/Category/GetAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/GetAll.cshtml", typeof(AspNetCore.Views_Category_GetAll))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b70729253a786c8ebaec147ee3fe0ff8e4220c", @"/Views/Category/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ad5a0d29faae9e45654b802d3de161e6c4bcf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoriesCollectionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Category\GetAll.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
            BeginContext(79, 11, true);
            WriteLiteral("\r\n<div>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Category\GetAll.cshtml"
     foreach (var category in Model.Categories)
    {

#line default
#line hidden
            BeginContext(146, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(158, 13, false);
#line 11 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Category\GetAll.cshtml"
      Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(171, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(189, 20, false);
#line 12 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Category\GetAll.cshtml"
      Write(category.Description);

#line default
#line hidden
            EndContext();
            BeginContext(209, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(217, 12, true);
            WriteLiteral("        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 229, "\"", 256, 1);
#line 14 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Category\GetAll.cshtml"
WriteAttributeValue("", 235, category.Picture.Url, 235, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(257, 38, true);
            WriteLiteral(" width=\"800\" height=\"400\" />\r\n        ");
            EndContext();
            BeginContext(295, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5b70729253a786c8ebaec147ee3fe0ff8e4220c6527", async() => {
                BeginContext(372, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Category\GetAll.cshtml"
                                                           WriteLiteral(category.Id);

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
            BeginContext(382, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(392, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5b70729253a786c8ebaec147ee3fe0ff8e4220c9102", async() => {
                BeginContext(467, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Category\GetAll.cshtml"
                                                         WriteLiteral(category.Id);

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
            BeginContext(475, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Category\GetAll.cshtml"

    }

#line default
#line hidden
            BeginContext(486, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoriesCollectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

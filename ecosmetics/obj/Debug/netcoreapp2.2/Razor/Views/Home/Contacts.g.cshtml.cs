#pragma checksum "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b1469dce4792c51c74f864c00c8ba67853a8e45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacts), @"mvc.1.0.view", @"/Views/Home/Contacts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contacts.cshtml", typeof(AspNetCore.Views_Home_Contacts))]
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
#line 1 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Home\Contacts.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b1469dce4792c51c74f864c00c8ba67853a8e45", @"/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ad5a0d29faae9e45654b802d3de161e6c4bcf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Home\Contacts.cshtml"
  
    ViewData["Title"] = "Contacts";

#line default
#line hidden
            BeginContext(126, 78, true);
            WriteLiteral("\r\n<section class=\"contacts-wrapper\">\r\n    <div class=\"main-nav\">\r\n        <h1>");
            EndContext();
            BeginContext(205, 21, false);
#line 10 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Home\Contacts.cshtml"
       Write(Localizer["Контакти"]);

#line default
#line hidden
            EndContext();
            BeginContext(226, 39, true);
            WriteLiteral("</h1>\r\n\r\n        <ul>\r\n            <li>");
            EndContext();
            BeginContext(265, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1469dce4792c51c74f864c00c8ba67853a8e455261", async() => {
                BeginContext(310, 19, false);
#line 13 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Home\Contacts.cshtml"
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
            BeginContext(333, 26, true);
            WriteLiteral("</li>\r\n            <li><p>");
            EndContext();
            BeginContext(360, 21, false);
#line 14 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Home\Contacts.cshtml"
              Write(Localizer["Контакти"]);

#line default
#line hidden
            EndContext();
            BeginContext(381, 165, true);
            WriteLiteral("</p></li>\r\n        </ul>\r\n    </div>\r\n\r\n    <section class=\"contacts-main\">\r\n        <div class=\"info\">\r\n            <div>\r\n                <h2 id=\"contacts-info-p\">");
            EndContext();
            BeginContext(547, 21, false);
#line 21 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Home\Contacts.cshtml"
                                    Write(Localizer["Контакти"]);

#line default
#line hidden
            EndContext();
            BeginContext(568, 46, true);
            WriteLiteral("</h2>\r\n            </div>\r\n            <div>\r\n");
            EndContext();
            BeginContext(667, 113, true);
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div class=\"contacts-down\">\r\n            <ul>\r\n                <li>");
            EndContext();
            BeginContext(781, 20, false);
#line 30 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Home\Contacts.cshtml"
               Write(Localizer["Телефон"]);

#line default
#line hidden
            EndContext();
            BeginContext(801, 72, true);
            WriteLiteral("<a href=\"tel:+359897779974\">+359897779974</a></li>\r\n                <li>");
            EndContext();
            BeginContext(874, 18, false);
#line 31 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Home\Contacts.cshtml"
               Write(Localizer["Имейл"]);

#line default
#line hidden
            EndContext();
            BeginContext(892, 154, true);
            WriteLiteral("<a href=\"mailto:office@elizabeth-cosmetics.com\">office@elizabeth-cosmetics.com</a></li>\r\n            </ul>\r\n        </div>\r\n    </section>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

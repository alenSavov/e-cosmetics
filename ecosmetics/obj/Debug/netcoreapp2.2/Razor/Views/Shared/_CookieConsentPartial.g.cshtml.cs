#pragma checksum "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Shared\_CookieConsentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4649c47dde4ee806aa969f0a76686018109d9432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CookieConsentPartial), @"mvc.1.0.view", @"/Views/Shared/_CookieConsentPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CookieConsentPartial.cshtml", typeof(AspNetCore.Views_Shared__CookieConsentPartial))]
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
#line 1 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Shared\_CookieConsentPartial.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#line 2 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Shared\_CookieConsentPartial.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4649c47dde4ee806aa969f0a76686018109d9432", @"/Views/Shared/_CookieConsentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ad5a0d29faae9e45654b802d3de161e6c4bcf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CookieConsentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(123, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Shared\_CookieConsentPartial.cshtml"
  
    var consentFeature = Context.Features.Get<ITrackingConsentFeature>();
    var showBanner = !consentFeature?.CanTrack ?? false;
    var cookieString = consentFeature?.CreateConsentCookie();

#line default
#line hidden
            BeginContext(328, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Shared\_CookieConsentPartial.cshtml"
 if (showBanner)
{

#line default
#line hidden
            BeginContext(351, 146, true);
            WriteLiteral("    <div id=\"cookieConsent\" class=\"alert alert-info alert-dismissible fade show\" role=\"alert\">\r\n        <p id=\"cookie-consent-text\">\r\n            ");
            EndContext();
            BeginContext(498, 142, false);
#line 15 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Shared\_CookieConsentPartial.cshtml"
       Write(Localizer["Ние използваме бисквитки, за да гарантираме, че получавате най-доброто изживяване. Използвайки нашия уебсайт, вие приемате нашата"]);

#line default
#line hidden
            EndContext();
            BeginContext(640, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(641, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4649c47dde4ee806aa969f0a76686018109d94326474", async() => {
                BeginContext(699, 21, true);
                WriteLiteral("Политика за бисквитки");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(724, 159, true);
            WriteLiteral(".\r\n        </p>\r\n        <button type=\"button\" id=\"cookie-btn\" class=\"@*accept-policy close*@\" data-dismiss=\"alert\" aria-label=\"@*Close*@\" data-cookie-string=\"");
            EndContext();
            BeginContext(884, 12, false);
#line 17 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Shared\_CookieConsentPartial.cshtml"
                                                                                                                                         Write(cookieString);

#line default
#line hidden
            EndContext();
            BeginContext(896, 404, true);
            WriteLiteral(@""">
            <span aria-hidden=""true"">Разбрах</span>
        </button>
    </div>
    <script>
        (function () {
            var button = document.querySelector(""#cookieConsent button[data-cookie-string]"");
            button.addEventListener(""click"", function (event) {
                document.cookie = button.dataset.cookieString;
            }, false);
        })();
    </script>
");
            EndContext();
#line 29 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\ecosmetics\Views\Shared\_CookieConsentPartial.cshtml"
}

#line default
#line hidden
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

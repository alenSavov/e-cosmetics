#pragma checksum "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b7291915dd649368ea872d60e1cecdcc01786bb"
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
#line 1 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\_ViewImports.cshtml"
using e_cosmetics;

#line default
#line hidden
#line 2 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\_ViewImports.cshtml"
using e_cosmetics.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7291915dd649368ea872d60e1cecdcc01786bb", @"/Views/Category/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55dae080c30c99e3cc1672d05f4a66ce6d7fd8c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<e_cosmetics.Services.Categories.Models.CategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetAll.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
            BeginContext(119, 15, true);
            WriteLiteral("\r\n    <div>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetAll.cshtml"
         foreach (var category in Model)
        {

#line default
#line hidden
            BeginContext(187, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(203, 13, false);
#line 11 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetAll.cshtml"
          Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(216, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(238, 20, false);
#line 12 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetAll.cshtml"
          Write(category.Description);

#line default
#line hidden
            EndContext();
            BeginContext(258, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(278, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 294, "\"", 321, 1);
#line 14 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetAll.cshtml"
WriteAttributeValue("", 300, category.PictureName, 300, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(322, 29, true);
            WriteLiteral(" width=\"800\" height=\"400\" /> ");
            EndContext();
#line 14 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Category\GetAll.cshtml"
                                                                         }

#line default
#line hidden
            BeginContext(354, 12, true);
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<e_cosmetics.Services.Categories.Models.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
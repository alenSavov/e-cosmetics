#pragma checksum "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "420d86f773f54becbbbcf4c7fef050dea60d1229"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetAll), @"mvc.1.0.view", @"/Views/Product/GetAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/GetAll.cshtml", typeof(AspNetCore.Views_Product_GetAll))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420d86f773f54becbbbcf4c7fef050dea60d1229", @"/Views/Product/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a5d90e1a77e141cf5cf3ef1e8317ff705a6671b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<e_cosmetics.Services.Products.Models.ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alenSavov\Desktop\SoftUni-Hub\e-cosmetics\e-cosmetics\Views\Product\GetAll.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
            BeginContext(116, 15, true);
            WriteLiteral("\r\n    <div>\r\n\r\n");
            EndContext();
            BeginContext(547, 10, true);
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<e_cosmetics.Services.Products.Models.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

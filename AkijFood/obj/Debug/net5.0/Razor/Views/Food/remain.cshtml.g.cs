#pragma checksum "C:\Users\Akib\source\repos\AkijFood\AkijFood\Views\Food\remain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4183ef4c46ec9b7dd0fc27d3aa64ed4ecad496ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_remain), @"mvc.1.0.view", @"/Views/Food/remain.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Akib\source\repos\AkijFood\AkijFood\Views\_ViewImports.cshtml"
using AkijFood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akib\source\repos\AkijFood\AkijFood\Views\_ViewImports.cshtml"
using AkijFood.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4183ef4c46ec9b7dd0fc27d3aa64ed4ecad496ae", @"/Views/Food/remain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b02234011e919f4a4a0819ee07d50b9bf738606", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_remain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AkijFood.Models.FoodClass>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Akib\source\repos\AkijFood\AkijFood\Views\Food\remain.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cold Drinks List</h1>\r\n\r\n<\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Akib\source\repos\AkijFood\AkijFood\Views\Food\remain.cshtml"
           Write(Html.DisplayNameFor(model => model.StrColdDrinksName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\Akib\source\repos\AkijFood\AkijFood\Views\Food\remain.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Akib\source\repos\AkijFood\AkijFood\Views\Food\remain.cshtml"
               Write(Html.DisplayFor(modelItem => item.StrColdDrinksName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Akib\source\repos\AkijFood\AkijFood\Views\Food\remain.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AkijFood.Models.FoodClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591

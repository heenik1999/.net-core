#pragma checksum "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e0c252829e135c62701c9ab536e150371a3949e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Di_Result), @"mvc.1.0.view", @"/Views/Di/Result.cshtml")]
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
#line 1 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\_ViewImports.cshtml"
using _1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\_ViewImports.cshtml"
using _1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e0c252829e135c62701c9ab536e150371a3949e", @"/Views/Di/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c27d4ee955ad092561690b92a01e746257c84ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Di_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_1.DBContext.Stud>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
   
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
           Write(Html.DisplayNameFor(Model => Model.StudId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
           Write(Html.DisplayNameFor(Model => Model.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
           Write(Html.DisplayNameFor(Model => Model.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
           Write(Html.DisplayNameFor(Model => Model.MobileNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
           Write(Html.DisplayNameFor(Model => Model.StateId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
           Write(Html.DisplayNameFor(Model => Model.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <thead>\r\n");
#nullable restore
#line 43 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
         foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
                   Write(Html.DisplayFor(modelItem =>item.StudId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
                   Write(Html.DisplayFor(modelItem =>item.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
                   Write(Html.DisplayFor(modelItem =>item.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
                   Write(Html.DisplayFor(modelItem =>item.MobileNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
                   Write(Html.DisplayFor(modelItem =>item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
                   Write(Html.DisplayFor(modelItem =>item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
                   Write(Html.DisplayFor(modelItem =>item.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
                   Write(Html.DisplayFor(modelItem =>item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
                   Write(Html.DisplayFor(modelItem =>item.StateId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
                   Write(Html.DisplayFor(modelItem =>item.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 77 "E:\.net Core Assignment\.net-core\MODULE-4\1\1\Views\Di\Result.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </thead>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_1.DBContext.Stud>> Html { get; private set; }
    }
}
#pragma warning restore 1591

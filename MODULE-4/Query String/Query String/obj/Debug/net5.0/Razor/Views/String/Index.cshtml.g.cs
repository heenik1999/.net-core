#pragma checksum "E:\.net Core Assignment\.net-core\MODULE-4\Query String\Query String\Views\String\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfa104bc3c6b20067b0c5ee2e3200fd099888a9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_String_Index), @"mvc.1.0.view", @"/Views/String/Index.cshtml")]
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
#line 1 "E:\.net Core Assignment\.net-core\MODULE-4\Query String\Query String\Views\_ViewImports.cshtml"
using Query_String;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.net Core Assignment\.net-core\MODULE-4\Query String\Query String\Views\_ViewImports.cshtml"
using Query_String.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa104bc3c6b20067b0c5ee2e3200fd099888a9b", @"/Views/String/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563340e8c36ab2255b7cc7c3dab9619009058f50", @"/Views/_ViewImports.cshtml")]
    public class Views_String_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\.net Core Assignment\.net-core\MODULE-4\Query String\Query String\Views\String\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<h3>");
#nullable restore
#line 8 "E:\.net Core Assignment\.net-core\MODULE-4\Query String\Query String\Views\String\Index.cshtml"
Write(Context.Request.Query["uname"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

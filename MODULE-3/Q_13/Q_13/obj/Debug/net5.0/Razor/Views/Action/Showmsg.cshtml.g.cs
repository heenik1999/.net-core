#pragma checksum "E:\.net Core Assignment\.net-core\MODULE-3\Q_13\Q_13\Views\Action\Showmsg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb4d9baba7458fff61916209fe73173c05d32b8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Action_Showmsg), @"mvc.1.0.view", @"/Views/Action/Showmsg.cshtml")]
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
#line 1 "E:\.net Core Assignment\.net-core\MODULE-3\Q_13\Q_13\Views\_ViewImports.cshtml"
using Q_13;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.net Core Assignment\.net-core\MODULE-3\Q_13\Q_13\Views\_ViewImports.cshtml"
using Q_13.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb4d9baba7458fff61916209fe73173c05d32b8e", @"/Views/Action/Showmsg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c17125cf523ebe2baa470be6dfb21893062855", @"/Views/_ViewImports.cshtml")]
    public class Views_Action_Showmsg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\.net Core Assignment\.net-core\MODULE-3\Q_13\Q_13\Views\Action\Showmsg.cshtml"
  
    ViewData["Title"] = "Showmsg";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Showmsg</h1>\r\n<h2>");
#nullable restore
#line 7 "E:\.net Core Assignment\.net-core\MODULE-3\Q_13\Q_13\Views\Action\Showmsg.cshtml"
Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
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
#pragma checksum "E:\.net Core Assignment\.net-core\Doctor_Finder\Doctor_Finder\Areas\Admin\Views\Dr\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "208feaa29c8276477e12527249d543decfec1c77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dr_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dr/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"208feaa29c8276477e12527249d543decfec1c77", @"/Areas/Admin/Views/Dr/Index.cshtml")]
    public class Areas_Admin_Views_Dr_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\.net Core Assignment\.net-core\Doctor_Finder\Doctor_Finder\Areas\Admin\Views\Dr\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Dr/admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row four-grids"">
    <div class=""col-md-3 ticket-grid"">
        <div class=""tickets"">
            <div class=""grid-left"">
                <div class=""book-icon"">
                    <i class=""fa fa-book""></i>
                </div>
            </div>
            <div class=""grid-right"">
                <h3>Tickets <span>Answered</span></h3>
                <p>452</p>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
    <div class=""col-md-3 ticket-grid"">
        <div class=""tickets"">
            <div class=""grid-left"">
                <div class=""book-icon"">
                    <i class=""fa fa-rocket""></i>
                </div>
            </div>
            <div class=""grid-right"">
                <h3>New <span>Projects</span></h3>
                <p>745</p>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
    <div class=""col-md-3 ticket-grid"">
        <div class=""tickets"">
            <");
            WriteLiteral(@"div class=""grid-left"">
                <div class=""book-icon"">
                    <i class=""fa fa-bar-chart""></i>
                </div>
            </div>
            <div class=""grid-right"">
                <h3>Our <span>Status</span></h3>
                <p>125</p>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
    <div class=""col-md-3 ticket-grid"">
        <div class=""tickets"">
            <div class=""grid-left"">
                <div class=""book-icon"">
                    <i class=""fa fa-user""></i>
                </div>
            </div>
            <div class=""grid-right"">
                <h3>Daily <span>Visitors</span></h3>
                <p>7462</p>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
    <div class=""clearfix""> </div>
</div>

");
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

#pragma checksum "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acb23046e5369a6a4d8e977db468c97c07573643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_logs), @"mvc.1.0.view", @"/Views/Home/logs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/logs.cshtml", typeof(AspNetCore.Views_Home_logs))]
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
#line 1 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\_ViewImports.cshtml"
using CurrencyConvertor;

#line default
#line hidden
#line 2 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\_ViewImports.cshtml"
using CurrencyConvertor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb23046e5369a6a4d8e977db468c97c07573643", @"/Views/Home/logs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef1e212c58ff52a1e28fca94ed8062ced11c3a48", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_logs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CurrencyConvertor.Models.Logs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
  
    ViewData["Title"] = "Logs";

#line default
#line hidden
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
 using (Html.BeginForm("Logs", "Home", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(141, 8, true);
            WriteLiteral("    <h1>");
            EndContext();
            BeginContext(150, 17, false);
#line 8 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(167, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
            BeginContext(176, 264, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""card"">
        <div class=""card-header"">
            <p>Search the logs</p>
            <div class=""row"">
                <div class=""col-4"">
                    <label for=""FromDate"">From</label>
                    ");
            EndContext();
            BeginContext(441, 31, false);
#line 17 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
               Write(Html.EditorFor(m => m.FromDate));

#line default
#line hidden
            EndContext();
            BeginContext(472, 139, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    <label for=\"FromDate\">From</label>\r\n                    ");
            EndContext();
            BeginContext(612, 29, false);
#line 21 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
               Write(Html.EditorFor(m => m.ToDate));

#line default
#line hidden
            EndContext();
            BeginContext(641, 744, true);
            WriteLiteral(@"
                </div>
                <div class=""col-4"">
                    <input type=""submit"" id=""btnConvert"" />
                </div>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-3 bg-primary"" >
                    <label>User Name</label>
                </div>
                <div class=""col-3 bg-primary"">
                    <label>From Currency</label>
                </div>
                <div class=""col-3 bg-primary"">
                    <label>To Currency</label>
                </div>
                <div class=""col-3 bg-primary"">
                    <label>Amount</label>
                </div>
            </div>
");
            EndContext();
#line 43 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
             foreach (var log in Model.AuditLogs)
            {

#line default
#line hidden
            BeginContext(1451, 114, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-3 border-bottom\">\r\n                        ");
            EndContext();
            BeginContext(1566, 24, false);
#line 47 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
                   Write(Html.Label(log.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 109, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-3 border-bottom\">\r\n                        ");
            EndContext();
            BeginContext(1700, 41, false);
#line 50 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
                   Write(Html.Label(log.FromCurrencyId.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 109, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-3 border-bottom\">\r\n                        ");
            EndContext();
            BeginContext(1851, 39, false);
#line 53 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
                   Write(Html.Label(log.ToCurrencyId.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 109, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-3 border-bottom\">\r\n                        ");
            EndContext();
            BeginContext(2000, 33, false);
#line 56 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
                   Write(Html.Label(log.Amount.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(2033, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 59 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
            }

#line default
#line hidden
            BeginContext(2102, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 63 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\logs.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CurrencyConvertor.Models.Logs> Html { get; private set; }
    }
}
#pragma warning restore 1591

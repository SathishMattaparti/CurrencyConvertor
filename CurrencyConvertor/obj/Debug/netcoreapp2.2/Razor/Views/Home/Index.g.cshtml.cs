#pragma checksum "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "876901bab50935cd37a140a1ae785e4bb38c5672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876901bab50935cd37a140a1ae785e4bb38c5672", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef1e212c58ff52a1e28fca94ed8062ced11c3a48", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CurrencyConvertorModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(76, 67, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    $(\"#ecForm\").\r\n</script>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\Index.cshtml"
 using (Html.BeginForm("Convert", "Home", FormMethod.Post, htmlAttributes: new { id="ecForm"}))
{

#line default
#line hidden
            BeginContext(243, 323, true);
            WriteLiteral(@"<div class=""text-left"">
    <div class=""card"">
        <div class=""card-header"">
            <h1 class=""display-4"">Exchange rate convertor</h1>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <label for=""valueToConvert"">Enter a value to convert </label>
                ");
            EndContext();
            BeginContext(567, 184, false);
#line 20 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(m => m.ValueToConvert, "", htmlAttributes: new { id = "valueToConvert", @class = "form-control", placeholder = "Enter a number", required = "required", type="number" }));

#line default
#line hidden
            EndContext();
            BeginContext(751, 287, true);
            WriteLiteral(@"
            </div>
            <div class=""invalid-feedback"">
                Please provide a valid number.
            </div>
            <div class=""row"">
                <div class=""col-4"">
                    <label for=""Date"">Select date</label><br />
                    ");
            EndContext();
            BeginContext(1039, 27, false);
#line 28 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\Index.cshtml"
               Write(Html.EditorFor(m => m.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 156, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    <label for=\"fromCurrencyCode\">From currency</label>\r\n                    ");
            EndContext();
            BeginContext(1223, 272, false);
#line 32 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\Index.cshtml"
               Write(Html.DropDownListFor(x => Model.FromCurrencyCode, new SelectList(Model.FromCurrencyCodes, "Id", "CurrencyCode"), "", htmlAttributes: new { id = "FromCurrencyCodes", @class = "form-control", name = "FromCurrencyCodes", required = "required", placeholder = "Convert from" }));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 152, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    <label for=\"toCurrencyCode\">To currency</label>\r\n                    ");
            EndContext();
            BeginContext(1648, 262, false);
#line 36 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\Index.cshtml"
               Write(Html.DropDownListFor(x => Model.ToCurrencyCode, new SelectList(Model.ToCurrencyCodes, "Id", "CurrencyCode"), "", htmlAttributes: new { id = "ToCurrencyCodes", @class = "form-control", name = "ToCurrencyCodes", required = "required", placeholder = "Convert to" }));

#line default
#line hidden
            EndContext();
            BeginContext(1910, 352, true);
            WriteLiteral(@"

                </div>
            </div>
            <div class=""row"">
                <div class=""col pt-3 pl-3"">
                    <input type=""submit"" id=""btnConvert"" />
                </div>
            </div><br />
            <div class=""row"">
                <label for=""convertedValue"">Converted value </label>
                ");
            EndContext();
            BeginContext(2263, 137, false);
#line 47 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(m => m.ConvertedValue, "", htmlAttributes: new { id = "convertedValue", @class = "form-control", disabled = "disabled" }));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 52 "C:\Users\sathi\Source\Repos\SathishMattaparti\CurrencyConvertor\CurrencyConvertor\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CurrencyConvertorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

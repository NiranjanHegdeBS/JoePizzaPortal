#pragma checksum "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99140cd213b878c7365426a4eb1a2f97d8b17a31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Index), @"mvc.1.0.view", @"/Views/Pizza/Index.cshtml")]
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
#line 1 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\_ViewImports.cshtml"
using JoePizzaPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\_ViewImports.cshtml"
using JoePizzaPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99140cd213b878c7365426a4eb1a2f97d8b17a31", @"/Views/Pizza/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ffe9cb2e8233a35f03819074a85cc3d5ebedac0", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JoePizzaPortal.Models.Pizza>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 align=\"center\">Exotic Pizzas in our Kitchen</h1>\r\n<div class=\"container mx-auto align-content-center justify-content-center\">\r\n");
#nullable restore
#line 9 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row justify-content-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99140cd213b878c7365426a4eb1a2f97d8b17a315278", async() => {
                WriteLiteral("\r\n                <div class=\"card w-50 mt-4\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 490, "\"", 516, 1);
#nullable restore
#line 14 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 496, item.PizzaImageLink, 496, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\"");
                BeginWriteAttribute("alt", " alt=\"", 538, "\"", 559, 1);
#nullable restore
#line 14 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 544, item.PizzaName, 544, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
                                          Write(item.PizzaName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 721, "\"", 744, 1);
#nullable restore
#line 17 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 729, item.PizzaName, 729, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""PizzaName"" hidden />
                        <span class=""badge badge-pill badge-success mr-1"">VEG</span>
                        <span class=""badge badge-pill badge-danger"">NON VEG</span>
                        <span class=""badge badge-pill badge-info"">MEDIUM</span>
                        <p class=""card-text mb-2"">");
#nullable restore
#line 21 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
                                             Write(item.PizzaDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <label for=\"customRange2\" class=\"form-label\">Choose Quantity : </label>\r\n                        <input type=\"number\" class=\"form-range\" min=\"1\"");
                BeginWriteAttribute("max", " max=\"", 1271, "\"", 1291, 1);
#nullable restore
#line 23 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1277, item.Quantity, 1277, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  value=\"0\" name=\"Quantity\"");
                BeginWriteAttribute("id", " id=\"", 1319, "\"", 1346, 2);
#nullable restore
#line 23 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1324, item.PizzaId, 1324, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1337, "-Quantity", 1337, 9, true);
                EndWriteAttribute();
                WriteLiteral(" required><br />\r\n                        <label for=\"customRange\" class=\"form-label\">Choose Type : </label>\r\n                        <input type=\"radio\" value=\"Veg\"");
                BeginWriteAttribute("id", " id=\"", 1512, "\"", 1539, 3);
                WriteAttributeValue("", 1517, "Type-", 1517, 5, true);
#nullable restore
#line 25 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1522, item.PizzaId, 1522, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1535, "-Veg", 1535, 4, true);
                EndWriteAttribute();
                WriteLiteral(" name=\"Type\" />Veg\r\n                        <input type=\"radio\" value=\"NonVeg\"");
                BeginWriteAttribute("id", " id=\"", 1618, "\"", 1648, 3);
                WriteAttributeValue("", 1623, "Type-", 1623, 5, true);
#nullable restore
#line 26 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1628, item.PizzaId, 1628, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1641, "-NonVeg", 1641, 7, true);
                EndWriteAttribute();
                WriteLiteral(" name=\"Type\" />Non Veg<br />\r\n                    </div>\r\n                    <input type=\"submit\" value=\"Proceed\"");
                BeginWriteAttribute("name", " name=\"", 1763, "\"", 1791, 2);
                WriteAttributeValue("", 1770, "Proceed-", 1770, 8, true);
#nullable restore
#line 28 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1778, item.PizzaId, 1778, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\11035908\source\PhaseFour\Project\JoePizzaPortal\JoePizzaPortal\Views\Pizza\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JoePizzaPortal.Models.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591

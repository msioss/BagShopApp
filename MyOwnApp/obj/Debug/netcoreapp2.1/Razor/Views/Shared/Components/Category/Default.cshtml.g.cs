#pragma checksum "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3473ee48116770c8a1db116f8dd4be77134f7c73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Category/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Category_Default))]
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
#line 1 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\_ViewImports.cshtml"
using MyOwnApp;

#line default
#line hidden
#line 2 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\_ViewImports.cshtml"
using MyOwnApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3473ee48116770c8a1db116f8dd4be77134f7c73", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89f785f8d9fdcf99730d89829f8a55d9b8ff0f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdownForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 254, true);
            WriteLiteral("\r\n<div class=\"sideB\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col\">\r\n                <h5 class=\"pl-2\">Material</h5>\r\n                <div class=\"container p-0\">\r\n                    <div class=\"control-group\">\r\n");
            EndContext();
#line 10 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                          
                            foreach (var item in Model.Materials)
                            {

#line default
#line hidden
            BeginContext(380, 111, true);
            WriteLiteral("                                <label class=\"control control--checkbox\">\r\n                                    ");
            EndContext();
            BeginContext(492, 9, false);
#line 14 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(501, 183, true);
            WriteLiteral("\r\n                                    <input type=\"checkbox\" />\r\n                                    <div class=\"control__indicator\"></div>\r\n                                </label>\r\n");
            EndContext();
#line 18 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(742, 245, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col\">\r\n                <h5 class=\"pl-2\">Type</h5>\r\n                <div class=\"container p-0\">\r\n                    <div class=\"control-group\">\r\n");
            EndContext();
#line 29 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                          
                            foreach (var item in Model.TypeOfProducts)
                            {

#line default
#line hidden
            BeginContext(1118, 111, true);
            WriteLiteral("                                <label class=\"control control--checkbox\">\r\n                                    ");
            EndContext();
            BeginContext(1230, 9, false);
#line 33 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1239, 183, true);
            WriteLiteral("\r\n                                    <input type=\"checkbox\" />\r\n                                    <div class=\"control__indicator\"></div>\r\n                                </label>\r\n");
            EndContext();
#line 37 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1480, 244, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col\">\r\n                <h5 class=\"pl-2\">Model</h5>\r\n                <div class=\"container p-0\">\r\n                    <div class=\"control-group\">\r\n");
            EndContext();
#line 47 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                          
                            foreach (var item in Model.ProductModels)
                            {

#line default
#line hidden
            BeginContext(1854, 111, true);
            WriteLiteral("                                <label class=\"control control--checkbox\">\r\n                                    ");
            EndContext();
            BeginContext(1966, 9, false);
#line 51 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1975, 183, true);
            WriteLiteral("\r\n                                    <input type=\"checkbox\" />\r\n                                    <div class=\"control__indicator\"></div>\r\n                                </label>\r\n");
            EndContext();
#line 55 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2216, 134, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"range-slider\">\r\n");
            EndContext();
#line 64 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
          
            var addition = (@Model.MaxPrice + @Model.MinPrice) / 2;
            var Fval = @Model.MinPrice+(addition-@Model.MinPrice)/2;
            var Sval = addition;

            

#line default
#line hidden
            BeginContext(2549, 44, true);
            WriteLiteral("<input class=\"priceRangePrint\" type=\"number\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2593, "\"", 2606, 1);
#line 69 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2601, Fval, 2601, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("min", " min=\"", 2607, "\"", 2628, 1);
#line 69 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2613, Model.MinPrice, 2613, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("max", " max=\"", 2629, "\"", 2650, 1);
#line 69 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2635, Model.MaxPrice, 2635, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2651, 61, true);
            WriteLiteral(" />\r\n            <input class=\"priceRangePrint\" type=\"number\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2712, "\"", 2725, 1);
#line 70 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2720, Sval, 2720, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("min", " min=\"", 2726, "\"", 2747, 1);
#line 70 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2732, Model.MinPrice, 2732, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("max", " max=\"", 2748, "\"", 2769, 1);
#line 70 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2754, Model.MaxPrice, 2754, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2770, 23, true);
            WriteLiteral(" />\r\n            <input");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2793, "\"", 2806, 1);
#line 71 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2801, Fval, 2801, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("min", " min=\"", 2807, "\"", 2828, 1);
#line 71 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2813, Model.MinPrice, 2813, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("max", " max=\"", 2829, "\"", 2850, 1);
#line 71 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2835, Model.MaxPrice, 2835, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2851, 47, true);
            WriteLiteral(" step=\"100\" type=\"range\" />\r\n            <input");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2898, "\"", 2911, 1);
#line 72 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2906, Sval, 2906, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("min", " min=\"", 2912, "\"", 2933, 1);
#line 72 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2918, Model.MinPrice, 2918, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("max", " max=\"", 2934, "\"", 2955, 1);
#line 72 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2940, Model.MaxPrice, 2940, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2956, 29, true);
            WriteLiteral(" step=\"100\" type=\"range\" />\r\n");
            EndContext();
            BeginContext(2996, 16, true);
            WriteLiteral("    </div>\r\n    ");
            EndContext();
            BeginContext(3012, 340, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f341716a4b452b948a204e8f31fb38", async() => {
                BeginContext(3039, 123, true);
                WriteLiteral("\r\n        <input class=\"chosen-value\" type=\"text\" value=\"\" placeholder=\"Type to filter\">\r\n        <ul class=\"value-list\">\r\n");
                EndContext();
#line 78 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
              
                foreach(var item in Model.Producers)
                {

#line default
#line hidden
                BeginContext(3251, 24, true);
                WriteLiteral("                    <li>");
                EndContext();
                BeginContext(3276, 9, false);
#line 81 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                   Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3285, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 82 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                }
            

#line default
#line hidden
                BeginContext(3326, 19, true);
                WriteLiteral("        </ul>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3352, 12, true);
            WriteLiteral("\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

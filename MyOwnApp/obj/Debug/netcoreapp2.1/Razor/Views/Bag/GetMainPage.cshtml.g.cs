#pragma checksum "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7a07aa73bf17383b2031cb6f1f32dca57ba2b88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bag_GetMainPage), @"mvc.1.0.view", @"/Views/Bag/GetMainPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bag/GetMainPage.cshtml", typeof(AspNetCore.Views_Bag_GetMainPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a07aa73bf17383b2031cb6f1f32dca57ba2b88", @"/Views/Bag/GetMainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89f785f8d9fdcf99730d89829f8a55d9b8ff0f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Bag_GetMainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(63, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8e5b91da817482080fddb57d8c74ab7", async() => {
                BeginContext(69, 93, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>GetMainPage</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(171, 10323, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c715fbad5c974f86948a52b8733d5887", async() => {
                BeginContext(177, 3772, true);
                WriteLiteral(@"
    <div class=""main"">
        <div class=""carouselBlock"">
            <div id=""carouselExampleCaptions"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselExampleCaptions"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleCaptions"" data-slide-to=""1""></li>
                    <li data-target=""#carouselExampleCaptions"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        <img src=""images/WinterShoes.jpg"" class=""d-block "">
                        <div class=""carousel-caption d-none d-md-block"">
                            <h5>
                                Mountinebike - Winter shoes tested
                            </h5>
                        </div>
                    </div>
                    <div class=""carousel-item"">
                  ");
                WriteLiteral(@"      <img src=""images/AirJordan.png"" class=""d-block"">
                        <div class=""carousel-caption d-none d-md-block"">
                            <h5 class=""text-dark"">
                                Nike - Air Jordan women release
                            </h5>
                        </div>
                    </div>
                    <div class=""carousel-item"">
                        <img src=""images/WomenShoes.jpg"" class=""d-block "">
                        <div class=""carousel-caption d-none d-md-block"">
                            <h5 class=""text-dark"">Women shoes</h5>
                            <p class=""text-dark"">
                                Classic variant of style shoes
                            </p>
                        </div>
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-h");
                WriteLiteral(@"idden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
            <div class=""carouselAdvert"">
                <div class=""AdvCard""
                     style=""background-image: url(https://www.famousfootwear.com/c/-/media/project/famousfootwear/homepage/desktop/2019/holiday/size-3/promo/desktop-story3.jpg?h=240&w=600&la=en&hash=7ECAFFAE6A7792B879C123E7F0B13BB9E746AA75);"">
                    <div class=""under uL"">
                        <a href=""#"">
                            <span>asdsadasdassd</span>
                        </a>
                        <p>
                            asdasd
                        </p>
                    </div>
    ");
                WriteLiteral(@"            </div>
                <div class=""AdvCard""
                     style=""background-image:url(https://www.famousfootwear.com/c/-/media/project/famousfootwear/homepage/desktop/2019/bts/size-3/hp-banner-story3.jpg?h=240&w=600&la=en&hash=2846DAF1C55C74E821A7FE715C8E0A0DA5D58393)"">
                    <div class=""under uR"">
                        <a href=""#"">
                            <span>link</span>
                        </a>
                        <p>
                            asdasd
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <h1>More to love</h1>
        <div class=""mainAdvert"">
");
                EndContext();
#line 85 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
              
                string classUnder = "mainUnderBlack";
                for (int i = 0; i < 3; i++)
                {
                    if (i == 1)
                    {
                        classUnder = "mainUnder";
                    }
                    else
                    {
                        classUnder = "mainUnderBlack";
                    }

#line default
#line hidden
                BeginContext(4342, 316, true);
                WriteLiteral(@"                    <div class=""AdvBlock""
                         style=""background-image: url(https://www.famousfootwear.com/c/-/media/project/famousfootwear/homepage/desktop/2019/fall/size-2/hp-banner-story2a.jpg?h=258&w=316&la=en&hash=2F565EDD9B394289BB253E819A4CBD19DCC7586A);"">

                        <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4658, "\"", 4683, 2);
                WriteAttributeValue("", 4666, "under", 4666, 5, true);
#line 100 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
WriteAttributeValue(" ", 4671, classUnder, 4672, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4684, 308, true);
                WriteLiteral(@">
                            <h3>
                                asdasd
                            </h3>
                            <a href=""#"">
                                <span>asdsadasdassd</span>
                            </a>
                        </div>
                    </div>
");
                EndContext();
#line 109 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
                }
            

#line default
#line hidden
                BeginContext(5026, 499, true);
                WriteLiteral(@"        </div>
        <h2>Recommended for you</h2>
        <div class=""container mb-4 mt-3 delPad"">
            <div id=""multi-item-example"" class=""carousel slide carousel-multi-item"" data-ride=""carousel"">
                <div class=""controls-top"">
                    <a class=""btn-floating"" href=""#multi-item-example"" data-slide=""prev"">
                        <i class=""fa fa-chevron-left""></i>
                    </a>

                    <div class=""carousel-inner"" role=""listbox"">
");
                EndContext();
#line 121 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
                          
                            string activeStr = "active";
                            //var recommended = Model.GetRecommendedProducts;
                            for (int i = 1; i <= Model.RecommendedProductsCount / 5; i++)
                            {
                                if (i != 1)
                                {
                                    activeStr = "";
                                }

#line default
#line hidden
                BeginContext(5980, 36, true);
                WriteLiteral("                                <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 6016, "\"", 6049, 3);
                WriteAttributeValue("", 6024, "carousel-item", 6024, 13, true);
#line 130 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
WriteAttributeValue(" ", 6037, activeStr, 6038, 10, false);

#line default
#line hidden
                WriteAttributeValue(" ", 6048, "", 6049, 1, true);
                EndWriteAttribute();
                BeginContext(6050, 85, true);
                WriteLiteral(">\r\n                                    <div class=\"row row-cols-1 row-cols-md-2\">\r\n\r\n");
                EndContext();
#line 133 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
                                          
                                            for (int j = (i - 1) * 5; j < i * 5; j++)
                                            {

#line default
#line hidden
                BeginContext(6313, 1333, true);
                WriteLiteral(@"                                                <div class=""col"">
                                                    <div class=""card recommendCard"">
                                                        <img src=""https://www.famousfootwear.com/productimages/shoes_ib95135.jpg?trim.threshold=105&height=160&width=160&anchor=bottomCenter""
                                                             class=""card-img-top imgRecommend"">
                                                        <div class=""card-body"">
                                                            <h5 class=""card-title"">Nike</h5>
                                                            <p class=""card-text""><small class=""text-muted"">abracadabra</small></p>
                                                            <hr>
                                                            <p class=""card-text price"">
                                                                33$
                                                    ");
                WriteLiteral(@"        </p>
                                                            <p hidden=""true"" class=""card-text oldPrice"">40$</p>

                                                        </div>
                                                    </div>
                                                </div>
");
                EndContext();
#line 152 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
                                            }
                                        

#line default
#line hidden
                BeginContext(7736, 84, true);
                WriteLiteral("                                    </div>\r\n                                </div>\r\n");
                EndContext();
#line 156 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"

                            }
                            if (Model.RecommendedProductsCount % 5 != 0)
                            {

#line default
#line hidden
                BeginContext(7958, 141, true);
                WriteLiteral("                                <div class=\"carousel-item\">\r\n                                    <div class=\"row row-cols-1 row-cols-md-2\">\r\n");
                EndContext();
#line 162 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
                                           for (int i = Model.RecommendedProductsCount - Model.RecommendedProductsCount % 5; i < Model.RecommendedProductsCount; i++)
                                            {

#line default
#line hidden
                BeginContext(8313, 1333, true);
                WriteLiteral(@"                                                <div class=""col"">
                                                    <div class=""card recommendCard"">
                                                        <img src=""https://www.famousfootwear.com/productimages/shoes_ib95135.jpg?trim.threshold=105&height=160&width=160&anchor=bottomCenter""
                                                             class=""card-img-top imgRecommend"">
                                                        <div class=""card-body"">
                                                            <h5 class=""card-title"">Nike</h5>
                                                            <p class=""card-text""><small class=""text-muted"">abracadabra</small></p>
                                                            <hr>
                                                            <p class=""card-text price"">
                                                                33$
                                                    ");
                WriteLiteral(@"        </p>
                                                            <p hidden=""true"" class=""card-text oldPrice"">40$</p>

                                                        </div>
                                                    </div>
                                                </div>
");
                EndContext();
#line 180 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
                                            }
                                            for (int i = 0; i < 5 - Model.RecommendedProductsCount % 5; i++)
                                            {

#line default
#line hidden
                BeginContext(9850, 125, true);
                WriteLiteral("                                                <div class=\"col\">\r\n\r\n                                                </div>\r\n");
                EndContext();
#line 186 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
                                            }
                                        

#line default
#line hidden
                BeginContext(10065, 84, true);
                WriteLiteral("                                    </div>\r\n                                </div>\r\n");
                EndContext();
#line 190 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Bag\GetMainPage.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(10207, 280, true);
                WriteLiteral(@"
                    </div>
                    <a class=""btn-floating"" href=""#multi-item-example"" data-slide=""next"">
                        <i class=""fa fa-chevron-right""></i>
                    </a>
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10494, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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

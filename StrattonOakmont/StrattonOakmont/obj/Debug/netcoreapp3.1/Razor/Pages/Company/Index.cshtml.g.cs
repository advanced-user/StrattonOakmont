#pragma checksum "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8594ddf3229ecf8ef00710d20322e20d429979d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StrattonOakmont.Pages.Company.Pages_Company_Index), @"mvc.1.0.razor-page", @"/Pages/Company/Index.cshtml")]
namespace StrattonOakmont.Pages.Company
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
#line 1 "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\_ViewImports.cshtml"
using StrattonOakmont;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\_ViewImports.cshtml"
using StrattonOakmontModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\_ViewImports.cshtml"
using StrattonOakmontServices;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8594ddf3229ecf8ef00710d20322e20d429979d7", @"/Pages/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d6d88539bee650b7744a0c63e59d348be055273", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Company_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-category", "Спортивные велосипеды", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-category", "Горные велосипеды", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-category", "Городские велосипеды", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Company\Index.cshtml"
  
    ViewData["Title"] = "Companies";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""carousel-ex"" class=""carousel slideInDown carousel-fade pt-4"" data-ride=""carousel"">
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""carousel-item active"">
            <div class=""view"" style=""background-image: url('https://images.pexels.com/photos/3100835/pexels-photo-3100835.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940');
         background-repeat: no-repeat; background-size: cover;"">
                <div class=""mask rgba-black-strong d-flex justify-content-center align-items-center"">
                    <div class=""text-center white-text mx-5 wow fadeIn"">
                        <h1 class=""mb-4"">
                            <strong>Shop</strong>
                        </h1>

                        <p>
                            <strong>
                                Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem
                            </strong>
                        </p>

                        <p class=""");
            WriteLiteral(@"mb-4 d-none d-md-block"">
                            <strong>Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem</strong>
                        </p>
                        <a href=""#"" class=""btn btn-outline-white btn-lg"">
                            LoremLoremLOrem
                            <i class=""fa fa-graduation-cap ml-2""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""carousel-item"">
            <div class=""view"" style=""background-image: url('https://images.pexels.com/photos/3937174/pexels-photo-3937174.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500');
         background-repeat: no-repeat; background-size: cover;"">
                <div class=""mask rgba-black-strong d-flex justify-content-center align-items-center"">
                    <div class=""text-center white-text mx-5 wow fadeIn"">
                        <h1 class=""mb-4"">
  ");
            WriteLiteral(@"                          <strong>Shop</strong>
                        </h1>

                        <p>
                            <strong>
                                Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem
                            </strong>
                        </p>

                        <p class=""mb-4 d-none d-md-block"">
                            <strong>Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem</strong>
                        </p>
                        <a href=""#"" class=""btn btn-outline-white btn-lg"">
                            LoremLoremLOrem
                            <i class=""fa fa-graduation-cap ml-2""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""carousel-item "">
            <div class=""view"" style=""background-image: url('https://images.pexels");
            WriteLiteral(@".com/photos/2437299/pexels-photo-2437299.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500');
         background-repeat: no-repeat; background-size: cover;"">
                <div class=""mask rgba-black-strong d-flex justify-content-center align-items-center"">
                    <div class=""text-center white-text mx-5 wow fadeIn"">
                        <h1 class=""mb-4"">
                            <strong>Shop</strong>
                        </h1>

                        <p>
                            <strong>
                                Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem
                            </strong>
                        </p>

                        <p class=""mb-4 d-none d-md-block"">
                            <strong>Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem</strong>
                        </p>
                        <a href=""#"" class=""btn btn-out");
            WriteLiteral(@"line-white btn-lg"">
                            LoremLoremLOrem
                            <i class=""fa fa-graduation-cap ml-2""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <a href=""#carousel-ex"" class=""carousel-control-prev"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    </a>
    <a href=""#carousel-ex"" class=""carousel-control-next"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    </a>
</div>

<main>
    <div class=""container"">

        <nav class=""navbar navbar-expand-lg navbar-dark mdb-color lighten-3 mt-3 mb-5"">
            <span class=""navbar-brand"">Categories:</span>

            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#nextNav""
                    aria-controls=""nextNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">");
            WriteLiteral(@"

                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""navbar-collapse navbar-collapse"" id=""nextNav"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8594ddf3229ecf8ef00710d20322e20d429979d712162", async() => {
                WriteLiteral("Все");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8594ddf3229ecf8ef00710d20322e20d429979d713708", async() => {
                WriteLiteral("Спортивные велосипеды");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8594ddf3229ecf8ef00710d20322e20d429979d715794", async() => {
                WriteLiteral("Горные велосипеды");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8594ddf3229ecf8ef00710d20322e20d429979d717876", async() => {
                WriteLiteral("Городские велосипеды");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8594ddf3229ecf8ef00710d20322e20d429979d719931", async() => {
                WriteLiteral("\r\n                    <div class=\"md-form my-0\">\r\n                        <input type=\"text\" class=\"form-control mr-sm-2\" placeholder=\"Search\" aria-label=\"Search\" />\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </nav>\r\n\r\n        <section class=\"text-center mb-4\">\r\n            <div class=\"row wow fadeIn\">\r\n");
#nullable restore
#line 139 "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Company\Index.cshtml"
                  
                    foreach (var item in Model.Companies)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-3 col-md-6 mb-4\">\r\n                            <div class=\"card\">\r\n                                <div class=\"view overlay\">\r\n                                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 7005, "\"", 7020, 1);
#nullable restore
#line 145 "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Company\Index.cshtml"
WriteAttributeValue("", 7011, item.IMG, 7011, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Js\" />\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8594ddf3229ecf8ef00710d20322e20d429979d722603", async() => {
                WriteLiteral("\r\n                                        <div class=\"mask rgba-white-slight\"></div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Company\Index.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"card-body text-center\">\r\n                                    <a class=\"grey-text\">\r\n                                        <h5>");
#nullable restore
#line 152 "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Company\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </a>\r\n                                    <h5>\r\n                                        <strong>\r\n                                            <a class=\"dark-grey-text\">");
#nullable restore
#line 156 "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Company\Index.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class=""badge-pill danger-color"">NEW</span></a>
                                        </strong>
                                    </h5>
                                    <h4 class=""font-weight-bold blue-text"">
                                        <strong>1400$</strong>
                                    </h4>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 165 "C:\Users\User\Documents\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Company\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </section>\r\n\r\n        <nav class=\"d-flex justify-content-center wow fadeIn\">\r\n            <ul class=\"pagination pg-blue\">\r\n                <li class=\"page-item\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 8381, "\"", 8388, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">&laquo;</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 8609, "\"", 8616, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">1</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 8831, "\"", 8838, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">2</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 9053, "\"", 9060, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">3</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 9275, "\"", 9282, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">4</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 9497, "\"", 9504, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">5</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 9719, "\"", 9726, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Next\">\r\n                        <span aria-hidden=\"true\">&raquo;</span>\r\n                    </a>\r\n                </li>\r\n\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StrattonOakmont.Pages.Company.Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StrattonOakmont.Pages.Company.Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StrattonOakmont.Pages.Company.Index>)PageContext?.ViewData;
        public StrattonOakmont.Pages.Company.Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Home\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4659993ce27aaca3c60e071003015789408863cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StrattonOakmont.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
namespace StrattonOakmont.Pages.Shared
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
#line 1 "C:\Users\Home\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\_ViewImports.cshtml"
using StrattonOakmont;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\_ViewImports.cshtml"
using StrattonOakmontModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Home\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\_ViewImports.cshtml"
using StrattonOakmontServices;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4659993ce27aaca3c60e071003015789408863cd", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"974d72ad2b61c32e2ee344bcf61b2f971ac01939", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Security/Security", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4659993ce27aaca3c60e071003015789408863cd8037", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 6 "C:\Users\Home\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - StrattonOakmont</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4659993ce27aaca3c60e071003015789408863cd8696", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4659993ce27aaca3c60e071003015789408863cd9872", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4659993ce27aaca3c60e071003015789408863cd11750", async() => {
                WriteLiteral("\n    <header>\n        <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\n            <div class=\"container\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4659993ce27aaca3c60e071003015789408863cd12198", async() => {
                    WriteLiteral(@"
                    <img src=""data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUTEhMVFhUWGCAYGBgVGBkfHhkaHSAdIB8hIR0aHSghHSMoHh0eIzEhJSkrLy4uHx81ODMtNyktLisBCgoKBQUFDgUFDisZExkrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrK//AABEIAKAAoAMBIgACEQEDEQH/xAAcAAACAwADAQAAAAAAAAAAAAAGBwAEBQEDCAL/xABLEAACAQIEAwUFAwcKAwgDAAABAgMEEQAFEiEGEzEHQVFhcRQiMoGRQlKxFSNDYoKhwSQzNFNjcpKi0dJUVbMIRXODk5SjwhYXJf/EABQBAQAAAAAAAAAAAAAAAAAAAAD/xAAUEQEAAAAAAAAAAAAAAAAAAAAA/9oADAMBAAIRAxEAPwB44mJiYCYmJiYCYmJivVVKRoXkdURRcs5AAHmTsMBYxxfC9rO01ZXMWV0s1dINi6gpEp83Yf6Dzxh51mGY9cxzely5T+hpgHlt9dfzUnAN0tbrtijLnFOvxVEK+siD8ThGcvK5jsuc5o33vfKk/uYfvxcjySH9FwtOR4y1EgP0YnAOeHOqZjZaiFj+rIh/A4vA36YRM2Sw/pOFpwPGKokJ+i4osmWQm5jznK2+97wUH5+8flgPQ2JhOZJm9ft+Ts3pcwH9TVDlyn0vZyfMkDBBR9pixOIc0pZqGQ7B2BaJj5Oo/wBQPHAMPExXpalJEDxuro24ZCCD6EbHFjATExMTATExMTATExMTATExwcAnGfFkvOGX5cBJWyD3m+zToftv3XtuB6dbgELnF/HEdGywRI1TWSbR08XX1ci+kfv+W+ADPoxrWTPJnqahjeHLKQkqpPTUFN7+fru3TFnKaZopXospbnVjf03MpRqEZPUKT1a/cCd+tyCVyq/iOmysSx5WvtdYAW");
                    WriteLiteral(@"qa2X39O4BIY9dz0Btci+o4DbrYqvkhq6phyei+zT01uaw8NQ3v5L81wHTcaZTRn/8An5cJ5O+esOok+IU3P004AcwzCorJjJK8k0rkDe5JPcAB08gMbJy6nof6UvtFT/w6k8uI/wBq6m7N/ZoRbvbuwF/Mu1rNZdlnWFe5YUVQPQkFv34wJuL8wfdq2qP/AJ0n4A43WPOhSrzIladSy01LAqx8w7atIUWjjBADSEEnoLnpi5tn5mTkx01PBFcHTFENRt01SteRvr8sB1Q8UV43Wsqtt9ppdh/ixs5f2l5tGDaqd1HUSqri3mWBP78DuVZnUUz8ynkeJ7aSUJF1NjY+IuBsdthgx4f4hNRJpOmlrHGlKiNAscxP6OoiA0MGNvf07G1weuA6140oqnbMMtiuf01F+acHx0/Cx9SMFuUVk7R6cuq48zp7e9Q14HOCj7ur4rDvU26WBwDVFNBUu0Usa0NapK7AiCRgbFWG/Ia/ePc8l64G6ummppSjq8UsbbjcFSO8H8CMA3eH5QJWOTytR1QP53LKsnQ5HUIWtv8AQ+ajDH4P44irGaCVGpqyP+cp5djt3qSBqHf4/LfCQpuI1qYohm6MQbrDmEX89Gy22fSfzgFwbH3rG4vcHBHVTcww0+ZygSWBoM2hOzWOwdha4v1vuD166sA/MTAHwbxbKZjl+YgR1iC6uPgqU7nQ9L23I9eliAdg4DnExMTATExMV6uoWNHkdgqIpZiegAFyfpgBbtC4oajiSKnXXWVB5dPGN9za7EeC379r27r4CaPK5ImOVUMl62cc3Mq3qYg25UHrqNzYX777Ekr8U2buRNnciFqipb2XLISLkKSVBt4k3J9G+9ijxpmJyegFDE+qurAZauYH3hqvq3891XyDHYnAZvG3FkcKDJ8ouIgdEsibvNIdioI63Oxbv6DYbhdfX+y6KemcXicPLILHmTL0AvsUQ7AdCdTd4t85Ohp4JKqx5jXhg26MQOZJ+yhAB+84I+HH1wpShOZWSpqSmAKqw2");
                    WriteLiteral(@"kmY2jW3eLgufJCO/AF+YdoeY0kCxPUaquSzteKH+Tp1VbBN5GFib/CCBa97ZeW9pucSyxxLVC8jqg/MQdWIH9X54B6ud3dnkJZ3YsxbqSTck/PHZllaYZoplALROsgB6EqQR+GAYXFXanmK1k6U9QFiSRkQcqI7KdN7sl97avnjqyrjriCpv7O0ktupjpomA9SI7DA9wjkzZlmKREELLIXlKg2VN2bfu2uBfvIw+OKc3hoY1pI6iHL4lWwfRrlI/s4hv6yN39AeuAC6A8WSi49z/xI6Vf3Fb/uxh8RcX8RULBaqQx3+E8mnKt6MqEH64vLxnl8Dfm8yzyQ3vqDRFT+zN/pg8biTLMxy1/aJJXgJ0PJLENcTgXVm5KlU63DW09Qe8YBdcS9pGZJHRSxVAUT04ZxyoTeRHeNj7yEi+gHw3NsfGS9otfVo1M9QFqGN4JOXCA7W/mnulhq+y1r6rA7Hbo4p4BqfZY5qaohrqWnRlVobakQszm6gm9ixJsSR4Wwv6CkllcJCjyP1CxqWbbwC74DSyyv0vJDVX5MrWlFvejcXtIB3MpJ27wWXv218pzY0bSUFcvNo2b31Bvov8M0LdxsQwtswPnizxLwvW1CxVYo6jnSXSoTkvcypb85a3SRSCT98P446puF66ekGujqRNTEILwyXkhY7AbblH/yv4LgC2CAyCLLaiYFwOblGYKSNXTTGW6jewt1UgD7uGb2ecUNWRPHULorKduXURnbcbBwPBrfW/da6R4foKgxDLq2GWBZHvRzSo6CKp6hQxHwyWsR42OCWlz2W0ebBT7VRsKXM4h1kivpDkeNxb1Udy4B9YmK9JULIiSRkMjqGUjoVIuD9DixgJhe9rNW8q02WQm0ldKFcjqsKkFz5d3yDYYJwpqnMwc0zTMDumW03Jiv05hBJ+erUvzwHdSNC9dNUtZaHJojDCO4yhfzh8yoGn10nCcHG9ca2argkKTTtbZVb3SfdQB1IsBYD0wcccTGhyGkpLnm1h50xvuekjX89T");
                    WriteLiteral(@"IPkcLjhAAVAmPSnR59+mqNSUv6yaB88AW8R9p+ZxztDHVbRARseVAdUii0jbx9C+q1u62LGedpOaQ09IBU/nZY2mkblQ/CzlY1ty7Cypq2+/6YWDsSST1O+NjiuvjmmQxElEghiFwRvHEit1/XDYCcR8UVdcVNXLzCl9PuItr2v8CjwHXG9wLw3SOhrMyl5dMr6EjW+uocWJVQvvaRcXK+PUY6+CuziszGzqvKg75pAbH+6Or/AC28xg9434TocuNG9PPNFVKVVFRRMzWveQRP9rV3AgXPzwDa4dggWFfZ4DCltkaIxsPUMAb+ZxbzARaS8wj0ICxaQCygdTc9PXAr2dVWayRu2ZIqrtyroElYb3LqpIXa21r9cd3azQGbKatR1VOZ/wCmQ5/cpwGzm+Q0tZEY54Y5EYbXAuL96sNwfMHCsyXgDNcsrXbLnhkpn2InawZfB1UXuv3h/EjB9wXUSDJ6aT4nFKpGroSE2v8AQYrZlx0iUNLmKLenldFlB+JFe6kg+KOLEW33wGtkXD0UJaXkwxSyC0gg1CNvVdlY/rFb7nxx5v48yqbK8ylELPCpYvC8bFfzb7gBhvt8J9MeiuJ89NCFqXBelJCzFdzFqsFkHit9mXzUjvvQ474YhzeiAjdS4HMp5VNxcjpcdVbofke7AI3hbiqvmFTA1bUlnp3eMmaTUrw/nPdOq4uiOu3W+M/JOOa6OeNpayqePVaRTNIbo2zW97qASQe42OKfD8vsOYIalWTlOUlW24BBVhbv2JwP4De4mr6zmvBU1U03KkIHMldht0Yaieo3B8Dg9yXOkaamrpN4a1TQZgvdzLABz4alKvfykwAcRHWlLP3yQhH/AL8JMf8A01jPzxo8GPzoayiP6aEzRD+2gu4t5mPmL9MA8uyeqeJanLJiTJQylVJ6tC92Q/j6Arhh4SvDWc/y3Ka6+1dTtSTnxmi2BPmWC/LDqwHyxtvhCUV5cnJPxZpmoU+OlnB/FD9cO7PZNNNO33YnP0UnCf4ci/kfDs");
                    WriteLiteral(@"fcaqSQ+qtI38cBmdsfE0lPmyckRnkU6oFkRXUFyWOzCwNtO4xl0PaPVezVEpipAVMca2p0G7lm38RaM7emMjtjk1ZxV+TIv0jQYxIdsul/Wqov8sc3+7Abr9plWQRyaPfb+ix/xFsF/ZX2XRyMJ8w06gA6UpI1aT0eReoU9y9/f4YUuU0vNmii1BOZIqaiL6dRAvbvte+H72NcCvStJWzS6nkDw6LHbTLZixJ3N4xYd2AakUQUBVAAAsABYAeFhj4NOhYOVXUBYNYXAPUA9QMd4xzgJjA45qxHQ1HezxmJF72kl9xFHqzDG8TgGywflKtNWTejpGK0w7pZhs8vmF+FT43OA7eLq1csyZhqF44BBH5uV0Lb97egOFfnN4OFKWN9mnmuAfulpHB9LAH547+K8xfP80ioqYn2SFiWcdCB8cn/ANV9f1sWu1lFqcwy7KYRZItIZR9kPpFv2Y1v6HANaHLRUZesEwuJKZUa/iUAJ9Qd8ef+z3j+bKpmp5rvTByrpfeMg2LJ8+q9D5HfHpxRbHjXixw1dVsvQ1EpHoXa2Ac/a9k0Dxw5xBFHOq6eapvpljYWRm02NwSB16EX6Wwuf/zek/5NRf8Ayf64bHCmXO3C7RzA+9TTMoPcpLuh/Aj5Y834BnHjClai1/kqjtHPoCXew5iE6hv1PKsfQYp5RxpT+1Uxjy6mpyJ01SRl9WgsAw3NrFSQbg9cDFDvQVQ8JoD/AJZx/HGOj2II7jfANJAYMvmUfFlmbK6+S3K2/wAS3x6LQ338cef85UFOJE7i0Evz5mr+OHpkUmqmgY9WiQ/VQcBxnseqmnUfaicfVSMKHh6X+R8Oydwqnj+bNIo/DDsZbix6HCFoyYsob72VZqGI7wquB+Ln6YDH48yujkzmuFZWGlGqNkIheTXqjUn4T7ttvW/lj5iyHKfYpFGbsUE8ZL+xy7MUlAXTe5uAxv3afPH3/wBoGh0Ziko+GaBWuO8qSp/cF+uAvJjqpqyPwRJgPEpIF/csrH0BwGrmOT");
                    WriteLiteral(@"ZXHGz0+avJKouieySrqYdBqJsvrht8AcTZlW05kpvYHsx5qSc6Nlc7n4dYIY3a+25O3djzpjd4T4oqMvm51OwBIsysLq6+DD+I3GA9Q0uY5itufRRMO809QCfksqIP82N+KXUAbEXF7EWI9QemPOk/bpmR+GOlX0Ryf3yfwxnx8aZ3mcns0Mzkt9iBVQAd5LKAQPMtbAMbtK4reerhyeikAaZglRIp3RSd0BHT3blvKw8cffa7nIoKCHL6NdLzjlKq3uIhYG3iWJC+d2wD8D5bDQ53S07SCWdWdZnX4EcxuAi97EMRdj37AbE4Os3ys1PE8HM3SClEyg9DpZgD8pGB+WA2ez7hiLKKBpJiBKU5tQ/gFBOkeSi/qbnvwE9j9O9fmlXmkqmykhL9zPsAD+rGLfMY3e37PjFRpSoffqWsQP6tLE/Vio+uC7s74dFBQQwEWe2uXzkbdvpsvoowHdxzxAtDRTVBPvKpEY8ZG2UfXf0Bwo+zLsmaXTV5ipEZ95IDcM/fd+8L+r1PfYdXDXZElROktRZ1hN4Yz8If+sYfaa2y/d3PU7COcZxU5rM9Flr8qmjOmprB3nvji8T4sD9B8QU+1DtGp4IJqKmAllaMxuU+CEMNO5G2rewUd/W3QpvIzlHKHtorzNc39n5Oi19ra9+mCXtjpIaFqfLqVQsSx86Q9XkkYsoLnvIUEgd2s7dMLHAM2lfIRSTELmfLMsStf2fVq0zFbb2tYNe/6vngX4gGWMqDLxW8wtZvaeTp0+XL3ve3l1xXn9zL4h3y1Dv+zGqKp+ruPkcccFUPPr6WPuaZNX90EFv8oOAYmctZeJH7g0EXz5mn+GHnkUemmgX7sSD6KMIFLz5fOw+LM82VF81BLX/xNbHoxVsLDAcnClqsrAzTM8vawTMqbnRE/wBaAQfnr1N8hht4XnaxSvEtNmcIvJQyhnA6tC9g4/D0BbAAfHEJrsgpKux51EeTMD1HSNr+d1jPzwt+DzeqSM30zBoW2vYSqUv+yWDfLDypEh");
                    WriteLiteral(@"SvmpmIagzmIzQnu5pUcwA9xYEN66MJOqWryqtkRJGimiJTWu2pT0Iv3MLHAZkmUVCkqYJbg2PuN1HyxYgyCpdJZBC+mJQzXUg2LBdgRvuR09cFue9oGZ2hnirJFjmjGw02WVLLIvTxs9vCRcdvCXHuZTyyQPVys0sEixdLiUKXS1h1JXT+1gFvh69gqAZfXSQ6PadRAL7AAJePUe5dRYn0OEUTgn4N4ialjrYg1hU0zR/tDcH/AAlx+1gLPBtOZM4pVidpCKlWMh216W1uwB3AIBO+/ja9h6jky2NpkntaVFZAw70axKnxFwD6jzN1j2FcGxxQLmEgvNLq5d/sR3te3i1jv4W8Tdu4BJZhH+UeKFjO8VGASO783Zv+q4U4dmFL2R0xbNM5nb4hOYx5XkkJH+VcGfaHxN+TqKSoADPcJGp6F26X8gLm3lgOO0Oo00Trz0p+aVjaV2A0RswEhW53bRewHjhe5l2t0FDTilyqFn0LpRmGmMH72/vOb7m4F/HCaz3PKislM1TI0jnvY7AeCjoo8hjMwBNlWXVWbVr3cvM6vKzEX+FbgW2AudKDuFx3Ytf/AKxzb/gpP8Sf7sVuEnMUNbU3tog5SkdeZOQgt+wJD+zjq4YqJGm5kkjmKBTNIC7bqlrL1+25VP2sAR8Q9n2ZkQRpSSMkMCrcFN2a8kn2rmzyFb/qjGRwYvJhrK07cqHkxec090FvRNbfTGDU5nPK7M0rszsSfeO5Y3O3qemGZk+TIJaagk2holNfmDd3MsCEP91dKW83wG9w1k/8uyqgI2oac1c48JpdwD5qxX5YdAwveyameVanM5ltJXSllB+zCmyD8fkFww8BMV6umWVGjkUMjqVZT0KkWI+hxYxMAk6fJ3tNkkrlZ6dvassmPUqCSFv5G4P7X3Rinxrlv5YoRXRR6a6jvFVw2s3u/Ft12N2HkWG5GGR2h8LtVxLJTty6ynPMp3G246oT4NYfO3dfAVR5lLKxzSij01sNo8youhlC7Fgv3hYkHrtbcg");
                    WriteLiteral(@"hgXXBWSR1lNLBJWU8LNIvISViH5uwuBaxV1YqQDe6rttvZoeDI4ZUkTOcvWSNwynW2zKbj7PjjU484PiqYvyrlPvQt700S7NE46kL3W717uo907BmaD2uM1SD86v8ASVHedgJh5N0bwbf7WwbfaBwpDDqrIKymeKZy0cUbMW3NmC7WIVrjc9AMYFJl6Nl9RPa8kc8KA3OyOspNx03KLv5Y7OH6yOSNqKoYLHI2qKQ9IZrWDH9RhZW/ZP2d+6gb2Q1lHWKyiWOxAAJWVDriYb2IO4uDurkjAejuyucPlNGV7ogvzUlT+8HBZhRf9nXNi9JPTMb8mQMvksg6f4lY/PBT2gdoEGWINQ5k7i6RBrG33mNjpX5b93fYJVx0+UyVtfLIFhqNDFPtc5dQIQfa13vbuIJ6dEFx9x9UZnJ79kgVrxxL9nqLk9Wax69PADGdxfxbU5jNzahthska30IPIfiTucD+A1+GcrWpn5TMVHLke48Y43cfUrbFLLo42lRZXMcZYB3C6iq9503F/S+CHhqP2elqa19tcbUtOD1eSUWkI8kiLXPiyjHTkNGkEft1QoKgkU0TfppR3kf1aGxY95svebAX5rk+UwQLRPmUiMH58n8lYlmZF0BrH3dKk+7e4LtjprMmymnhalbM5FZ2WWQ+yuSRpvGhF/dtqJK+JF7FcCmX+7qr6r84xcmJX35017lmB6opN28TZe82tcPZCajmV1c7JSIxMsp+KZzvy47/ABOx6noNycBf4cyyKk5mYE86ONzHRBk0mon+y2i5IVNmPnYXwW0+RykR5SCTV1rCqzOXqY4r6ghPjve3ifBsdMM3L5WZVEIEhAiyqgUE6R0VyvU7736sTfb3cM7s+4WakieWobXWVLcyoc7+8dwg8lv9fK2AKaSmWNEjRQqIoVVHQACwH0xYxMTATExMTAcEYBOM+E5ecMwy0iOsjHvLtoqU70cdL22BPluLAg8xwRgE1ldU0sklblI5Nau1dlsp0iUjqVBtZr/aFtzvYkhs6b");
                    WriteLiteral(@"h+mzCQ1WVFaWvS/PophpBPRxpI6HcHbSQdwpvhjcX8Dx1jLURO1NWJ/N1EWx8g4HxDu8flsQLPJAJETPIHpqlSBDmdHcKxHTUVHXyI8dl64BYcVZEIZVGkwM7WeCW4MLd9ifjiPVXF9tjuLkwouGoZ4BBW5llp5a2gmWpHMjH3GDKNcfgCQV3se7BdVtV8kLXU8Wc0RHuVFNbmqPHSvU+an1bAbLwXlNZvl+YiCT+orBpsfAMbH6asAQcCZDNlazVIrstaOePlxuagiMyBgQSdNmsNWwN9/ngUzfg16iV5ps5yuSRzdmaqFz/l2A6ADYY7o+AM8oCWpl1ow97kujo4/Wjf4x6qcCuZcL5jzGd6CoUsSxCU7hRfwCrYDyGA1h2dj/m2U/8Auh/txt5F2cUNwajNaKV/sww1CKHPcDIbsAfJL+GAWLhWuY2Wiqj6QSf7cFHDnBmdxh/Z4JIOYAGkYpGwAv0ZiHUb76bX2vgCTM+EFae+YV2XRrAloaNKjlqo6hTqGpFPVmALN4jqA3OKYPWE1VTDOqouiOhYsGFyEhistktbc9wN/eY2Nw8HUVOdWY5nGW74aO8shPgXI0qfUHBZk9HOiFsupI8sp7WauriOcynvGr4bjuUW8xgB2oyFY2Wpzf3bgLBl8H84yj4EIH80niT7xOr7R33qiLlmGozOEGTZcvymEbLf4S6Dpv1uLk9fuj74djHNZcmiesqibS5nVg6EJ6lA199/M/3hhj8H8Dx0bNPK7VFY/wDOVEu5ueoS/wAI/f8ALbAVODOE5RMcwzEiStkFlUfBTJ9xO69jufXrcknmJiYCYmJiYCYmJiYCYmJiYCYr1VMkiFJEV0YWKuAQR5g7HFjEwC8rOzNYnMuVVUtDIdyqnXE3qjH/AFA8MYWdZfmPTMcopcxUfpqYhJbfTX8lAGHBjg4Dz7zMrhOzZzlbfdBcKD5dWOLkWeQW/N8UVAHhLTyE/VgMPQrfruPPFKXJqdt2p4WPnGh/EYBLz51Db85xTOR/ZU");
                    WriteLiteral("0gP1XFI/kyc7vnOaN933tJPnezDD1iyanU3WnhX0jQfgMXlW3TAJ7JMor/APu/J6TLx3TVTcyUel7uD5EEYIKPszWVxNmlVLXSDcKxKxKfKMH+IB8MMPEwFelpkjUJGioiiwVAAAPIDYYsYmJgJiYmJgJiYmJgP//Z\" width=\"60\" height=\"60\"/>\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4659993ce27aaca3c60e071003015789408863cd24055", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </li>\n                        <li class=\"nav-item\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4659993ce27aaca3c60e071003015789408863cd25672", async() => {
                    WriteLiteral("Security");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </li>\n                        <li class=\"nav-item\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4659993ce27aaca3c60e071003015789408863cd27293", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </li>\n                    </ul>\n                </div>\n            </div>\n        </nav>\n    </header>\n    <div class=\"container\">\n        <main role=\"main\" class=\"pb-3\">\n            ");
#nullable restore
#line 39 "C:\Users\Home\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </main>\n    </div>\n\n    <footer class=\"border-top footer text-muted\">\n        <div class=\"container\">\n            &copy; 1999 - StrattonOakmont - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4659993ce27aaca3c60e071003015789408863cd29434", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n    </footer>\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4659993ce27aaca3c60e071003015789408863cd30896", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4659993ce27aaca3c60e071003015789408863cd31994", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4659993ce27aaca3c60e071003015789408863cd33093", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#nullable restore
#line 51 "C:\Users\Home\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    ");
#nullable restore
#line 53 "C:\Users\Home\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
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
            WriteLiteral("\n</html>\n");
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

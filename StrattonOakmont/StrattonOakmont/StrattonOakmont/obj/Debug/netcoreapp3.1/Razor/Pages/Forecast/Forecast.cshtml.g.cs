#pragma checksum "C:\Users\Admin\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Forecast\Forecast.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49f90e7488dfa302267381c1e7d019c4efde20ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StrattonOakmont.Pages.Forecast.Pages_Forecast_Forecast), @"mvc.1.0.razor-page", @"/Pages/Forecast/Forecast.cshtml")]
namespace StrattonOakmont.Pages.Forecast
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
#line 1 "C:\Users\Admin\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\_ViewImports.cshtml"
using StrattonOakmont;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\_ViewImports.cshtml"
using StrattonOakmontModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\_ViewImports.cshtml"
using StrattonOakmontServices;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49f90e7488dfa302267381c1e7d019c4efde20ac", @"/Pages/Forecast/Forecast.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d6d88539bee650b7744a0c63e59d348be055273", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Forecast_Forecast : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script src=\"https://cdn.jsdelivr.net/npm/chart.js@2.8.0\"></script>\r\n\r\n<div style=\"margin-top: 100px;\">\r\n    <h1>Predicting stock prices for ");
#nullable restore
#line 8 "C:\Users\Admin\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Forecast\Forecast.cshtml"
                               Write(Model.Company.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<canvas id=\"myChart\" width=\"400\" height=\"200\"></canvas>\r\n\r\n<input id=\"dates\"");
            BeginWriteAttribute("value", " value=\"", 318, "\"", 339, 1);
#nullable restore
#line 12 "C:\Users\Admin\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Forecast\Forecast.cshtml"
WriteAttributeValue("", 326, Model.Prices, 326, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  />

<script>
let x_vals = []
let y_vals = []

epoch = 10000
let a, b, c, d

const leatningRate = 0.2
const optimizer = tf.train.adam(leatningRate)

setup()

function setup(){
     a = tf.variable(tf.scalar(-0.5))
     b = tf.variable(tf.scalar(0.5))
     c = tf.variable(tf.scalar(-0.3))
     d = tf.variable(tf.scalar(0.4))

    x_vals = JSON.parse(document.getElementById(""dates"").value);

    for (var i = 0; i < x_vals.length; i++){
        y_vals.push(i+1)
    }

    for (var i = 0; i < epoch; i++){
         fit()
    }
    a.print()
    b.print()
    c.print()
    d.print()
}

function loss(predict, labels){
    return predict.sub(labels).square().mean()
}

function predict(x){
      const xs = tf.tensor1d(x)

      const ys = xs.pow(tf.scalar(3)).mul(a)
                   .add(xs.square().mul(b))
                   .add(xs.mul(c))
                   .add(d)
      return ys
}

function fit(){
      tf.tidy(() => {
          if (x_vals.length > 0){
      ");
            WriteLiteral(@"      const ys = tf.tensor1d(y_vals)
            optimizer.minimize(() => loss(predict(x_vals), ys))
          }
        })


      const curveX = []
      for (let x = -1; x < 1.01; x+=0.05){
        curveX.push(x)
      }

      const ys = tf.tidy(() => predict(curveX))
      let curveY = ys.dataSync()
      ys.dispose()

      for (let i = 0; i < curveX.length; i++){
        let x = map(curveX[i], -1, 1, 0, width)
        let y = map(curveY[i], -1, 1, height, 0)
        vertex(x, y)
      } 
    }


    /*
    set()

    async function set() {
    const ctx = document.getElementById('myChart').getContext('2d');
    const globalTemps = await getData();
    const myChart = new Chart(ctx, {
        type: 'line',
        data: {
        labels: globalTemps.years,
        datasets: [
            {
            label: 'Temperature in °C',
            data: globalTemps.temps,
            fill: false,
            borderColor: 'rgba(255, 99, 132, 1)',
            backgroundColo");
            WriteLiteral("r: \'rgba(255, 99, 132, 0.5)\',\r\n            borderWidth: 1\r\n            }\r\n        ]\r\n        },\r\n        options: {}\r\n    });\r\n    }\r\n\r\n    async function getData() {\r\n    years = ");
#nullable restore
#line 113 "C:\Users\Admin\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Forecast\Forecast.cshtml"
       Write(Model.Dates);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    temps = ");
#nullable restore
#line 114 "C:\Users\Admin\Desktop\StrattonOakmont\StrattonOakmont\StrattonOakmont\StrattonOakmont\Pages\Forecast\Forecast.cshtml"
       Write(Model.Prices);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    console.log(years);\r\n    console.log(temps);\r\n\r\n    return { years, temps };\r\n    }\r\n    */\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StrattonOakmont.Pages.Forecast.ForecastModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StrattonOakmont.Pages.Forecast.ForecastModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StrattonOakmont.Pages.Forecast.ForecastModel>)PageContext?.ViewData;
        public StrattonOakmont.Pages.Forecast.ForecastModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

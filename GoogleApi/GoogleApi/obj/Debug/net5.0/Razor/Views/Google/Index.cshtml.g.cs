#pragma checksum "C:\Users\303BUSRA_AKSAM\source\repos\GoogleApi\GoogleApi\Views\Google\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85bda499674d33a99b5f6de0332035139b755565"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Google_Index), @"mvc.1.0.view", @"/Views/Google/Index.cshtml")]
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
#line 1 "C:\Users\303BUSRA_AKSAM\source\repos\GoogleApi\GoogleApi\Views\_ViewImports.cshtml"
using GoogleApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\303BUSRA_AKSAM\source\repos\GoogleApi\GoogleApi\Views\Google\Index.cshtml"
using GoogleApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85bda499674d33a99b5f6de0332035139b755565", @"/Views/Google/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38e8fd721301da6d72572250f196da1c1209ac82", @"/Views/_ViewImports.cshtml")]
    public class Views_Google_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hotels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\303BUSRA_AKSAM\source\repos\GoogleApi\GoogleApi\Views\Google\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TemplateLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"googleMap\" style=\"width:100%; height:400px;\"></div>\r\n<script>\r\n    function myMap() {\r\n        var a = new Array();\r\n        var a = [];\r\n        var b = new Array();\r\n        var b = [];\r\n");
#nullable restore
#line 14 "C:\Users\303BUSRA_AKSAM\source\repos\GoogleApi\GoogleApi\Views\Google\Index.cshtml"
         foreach(var x in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("a.push(");
#nullable restore
#line 16 "C:\Users\303BUSRA_AKSAM\source\repos\GoogleApi\GoogleApi\Views\Google\Index.cshtml"
                    Write(x.lat.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n");
#nullable restore
#line 17 "C:\Users\303BUSRA_AKSAM\source\repos\GoogleApi\GoogleApi\Views\Google\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\303BUSRA_AKSAM\source\repos\GoogleApi\GoogleApi\Views\Google\Index.cshtml"
         foreach(var x in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("b.push(");
#nullable restore
#line 20 "C:\Users\303BUSRA_AKSAM\source\repos\GoogleApi\GoogleApi\Views\Google\Index.cshtml"
                    Write(x.lng.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n");
#nullable restore
#line 21 "C:\Users\303BUSRA_AKSAM\source\repos\GoogleApi\GoogleApi\Views\Google\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        var mapProp = {
            center: new google.maps.LatLng(40.98867000000007, 29.02732000000003),
            zoom:1,
        };
        var map = new google.maps.Map(document.getElementById(""googleMap""), mapProp);
        for (var i = 0; i < a.length; i++) {
            var data = a[i];
            var data1 = b[i];
            var marker = new google.maps.Marker({ position: { lat: data, lng: data1 }, map: map, });
            marker.setIcon('http://maps.google.com/mapfiles/ms/icons/blue-dot.png')
        }


    }
</script>
<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDBT1ly4d7imB7Yy3W2vLnyMlWIv5gCcFI&callback=myMap""></script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hotels>> Html { get; private set; }
    }
}
#pragma warning restore 1591

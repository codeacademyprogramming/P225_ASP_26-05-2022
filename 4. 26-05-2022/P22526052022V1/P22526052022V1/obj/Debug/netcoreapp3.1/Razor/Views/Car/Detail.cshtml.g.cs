#pragma checksum "C:\Users\hamid.mammadov\Desktop\P22526052022V1\P22526052022V1\Views\Car\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ebae6933fe0736cbfa7cdd4c99c3d8fdbb50186"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Detail), @"mvc.1.0.view", @"/Views/Car/Detail.cshtml")]
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
#line 2 "C:\Users\hamid.mammadov\Desktop\P22526052022V1\P22526052022V1\Views\_ViewImports.cshtml"
using P22526052022V1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ebae6933fe0736cbfa7cdd4c99c3d8fdbb50186", @"/Views/Car/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f05131b0ccb0f996f178ee2fd43e05e156c2b12", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hamid.mammadov\Desktop\P22526052022V1\P22526052022V1\Views\Car\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Car Detail</h1>\r\n\r\n<h3>Id: ");
#nullable restore
#line 8 "C:\Users\hamid.mammadov\Desktop\P22526052022V1\P22526052022V1\Views\Car\Detail.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Ad: ");
#nullable restore
#line 9 "C:\Users\hamid.mammadov\Desktop\P22526052022V1\P22526052022V1\Views\Car\Detail.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Suretler Qutusu: ");
#nullable restore
#line 10 "C:\Users\hamid.mammadov\Desktop\P22526052022V1\P22526052022V1\Views\Car\Detail.cshtml"
                Write(Model.EngineType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Ili: ");
#nullable restore
#line 11 "C:\Users\hamid.mammadov\Desktop\P22526052022V1\P22526052022V1\Views\Car\Detail.cshtml"
    Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7974f908a593a83b656ea196051c24ca41577d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detail), @"mvc.1.0.view", @"/Views/Student/Detail.cshtml")]
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
#line 2 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\_ViewImports.cshtml"
using P22525052022V1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\_ViewImports.cshtml"
using P22525052022V1.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7974f908a593a83b656ea196051c24ca41577d7", @"/Views/Student/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be1d6a943a98a397de5d2ff6f392d093823869df", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Student\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n<h3>Ad: ");
#nullable restore
#line 8 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Student\Detail.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>SoyAd: ");
#nullable restore
#line 9 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Student\Detail.cshtml"
      Write(Model.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Yas: ");
#nullable restore
#line 10 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Student\Detail.cshtml"
    Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Ortalama Qiymet: ");
#nullable restore
#line 11 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Student\Detail.cshtml"
                Write(Model.AvgPoint);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
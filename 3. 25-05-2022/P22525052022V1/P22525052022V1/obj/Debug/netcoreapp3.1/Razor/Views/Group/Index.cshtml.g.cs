#pragma checksum "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Group\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "299efc8b417e2396e3940a71073bbc0f407edad7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Index), @"mvc.1.0.view", @"/Views/Group/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299efc8b417e2396e3940a71073bbc0f407edad7", @"/Views/Group/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be1d6a943a98a397de5d2ff6f392d093823869df", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Group\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<ul>\r\n");
#nullable restore
#line 9 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Group\Index.cshtml"
     foreach (Group item in Model.Groups)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 11 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Group\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 12 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Group\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<ul>\r\n");
#nullable restore
#line 16 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Group\Index.cshtml"
     foreach (Student item in Model.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 18 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Group\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\Users\hamid.mammadov\Desktop\P22525052022V1\P22525052022V1\Views\Group\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

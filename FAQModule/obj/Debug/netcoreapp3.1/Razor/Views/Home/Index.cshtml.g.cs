#pragma checksum "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "11bf53566a9a21f5181b827e35da5c71d9fd061dbdc895bf407e54a7152acdd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 11 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\_ViewImports.cshtml"
using FAQModule.ViewModels

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"11bf53566a9a21f5181b827e35da5c71d9fd061dbdc895bf407e54a7152acdd6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"905fd9e3594fdb15fa40909db136cd691ede280ee7b8b0f5eb6bd92c3a8ed737", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Home_Index : 
#nullable restore
#line 6 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\_ViewImports.cshtml"
OrchardCore.DisplayManagement.Razor.RazorPage

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\_ViewImports.cshtml"
<

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\Home\Index.cshtml"
       List<FAQModule.Models.FAQPart>

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\_ViewImports.cshtml"
>

#line default
#line hidden
#nullable disable

    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"faq-container\">\r\n");
#nullable restore
#line 4 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\Home\Index.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <p class=\"faq-empty\">");
            Write(
#nullable restore
#line 6 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\Home\Index.cshtml"
                              T["It's a desert. There are no questions yet."]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\Home\Index.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable

#nullable restore
#line 10 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\Home\Index.cshtml"
         foreach (var faq in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <div class=\"faq-item\">\r\n                <p class=\"faq-question\">");
            Write(
#nullable restore
#line 13 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\Home\Index.cshtml"
                                         faq.Question

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                <p class=\"faq-answer\">");
            Write(
#nullable restore
#line 14 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\Home\Index.cshtml"
                                       faq.Answer

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

#nullable restore
#line 16 "C:\Users\lordn\Desktop\OrchardCMS\FAQModule\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FAQModule.Models.FAQPart>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\lordn\Desktop\OrchardCMS\FAQTheme\Views\Layout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "79396d8d49c7dfca8c52607c8d405cb1967f627cfda8cae890481a284068fea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Layout), @"mvc.1.0.view", @"/Views/Layout.cshtml")]
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
#line 10 "C:\Users\lordn\Desktop\OrchardCMS\FAQTheme\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\lordn\Desktop\OrchardCMS\FAQTheme\Views\_ViewImports.cshtml"
using FAQModule.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"79396d8d49c7dfca8c52607c8d405cb1967f627cfda8cae890481a284068fea7", @"/Views/Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fc3c6c92e64557050b851f3a23b902fe01f67e34237f9dc0d63c4c9e2af824f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Layout : 
#nullable restore
#line 5 "C:\Users\lordn\Desktop\OrchardCMS\FAQTheme\Views\_ViewImports.cshtml"
OrchardCore.DisplayManagement.Razor.RazorPage

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lordn\Desktop\OrchardCMS\FAQTheme\Views\_ViewImports.cshtml"
<

#line default
#line hidden
#nullable disable
    dynamic
#nullable restore
#line 5 "C:\Users\lordn\Desktop\OrchardCMS\FAQTheme\Views\_ViewImports.cshtml"
>

#line default
#line hidden
#nullable disable

    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("dir", new global::Microsoft.AspNetCore.Html.HtmlString("ltr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n\n<html lang=\"en-US\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79396d8d49c7dfca8c52607c8d405cb1967f627cfda8cae890481a284068fea75093", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>F.A.Q. - FAQWebsite</title>
    <link type=""image/x-icon"" rel=""shortcut icon"" href=""/TheBlogTheme/favicon.ico"">

    <link href=""https://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800"" rel=""stylesheet"" type=""text/css"">

    <link href=""https://localhost:5001/Contents/Lists/4p0yn0k7yhh00z9224a76wh6w2/rss"" rel=""alternate"" title=""Blog"" type=""application/rss+xml"">
    <link crossorigin=""anonymous"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.css"" integrity=""sha384-t4IGnnWtvYimgcRMiXD2ZD04g28Is9vYsVaHo5LcWWJkoQGmMwGg+QS0mYlhbVv3"" rel=""stylesheet"" type=""text/css"">
    <link href=""/TheBlogTheme/css/bootstrap-oc.css?v=WbNUpcML-AqW_KWqGYhR3gtacOn8j8cE2VZuI2qOC1Q"" rel=""stylesheet""");
                WriteLiteral(" type=\"text/css\">\n    <link crossorigin=\"anonymous\"");
                BeginWriteAttribute("href", " href=\"", 1118, "\"", 1203, 2);
                WriteAttributeValue("", 1125, "https://cdn.jsdelivr.net/npm/", 1125, 29, true);
                WriteLiteral("@");
                WriteAttributeValue("", 1156, "fortawesome/fontawesome-free@5.10.2/css/all.css", 1156, 47, true);
                EndWriteAttribute();
                WriteLiteral(@" integrity=""sha384-Ex0vLvgbKZTFlqEetkjk2iUgM+H5udpQKFKjBoGFwPaHRGhiWyVI6jLz/3fBm5ht"" rel=""stylesheet"" type=""text/css"">
    <link href=""/TheBlogTheme/css/clean-blog.css?v=BhpWeMISyBL_o9iXSzWjQwXGlTrqmFzvt9150gJHqEo"" rel=""stylesheet"" type=""text/css"">
    <link type=""text/css"" rel=""stylesheet"" id=""dark-mode-custom-link"">
    <link type=""text/css"" rel=""stylesheet"" id=""dark-mode-general-link"">
    <style lang=""en"" type=""text/css"" id=""dark-mode-custom-style""></style>
    <style lang=""en"" type=""text/css"" id=""dark-mode-native-style""></style>
    <style lang=""en"" type=""text/css"" id=""dark-mode-native-sheet""></style>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79396d8d49c7dfca8c52607c8d405cb1967f627cfda8cae890481a284068fea77594", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79396d8d49c7dfca8c52607c8d405cb1967f627cfda8cae890481a284068fea79496", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-light fixed-top"" id=""mainNav"">
        <div class=""container active"">
            <a class=""navbar-brand"" href=""/"">FAQWebsite</a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""sr-only"">Toggle navigation</span>
                Menu <i class=""fa fa-bars""></i>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/"">Home</a>

                    </li>
                    <li class=""nav-item "">
                        <a class=""nav-link"" href=""/about"">About</a>

                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <header class=""masthead""");
                WriteLiteral(@" style=""background-image: url('../msc/questions.jpg')"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 col-md-10 mx-auto"">
                    <div class=""site-heading"">
                        <h1>");
                Write(
#nullable restore
#line 54 "C:\Users\lordn\Desktop\OrchardCMS\FAQTheme\Views\Layout.cshtml"
                             T["Frequently Asked Questions"]

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"</h1>
                        <span class=""subheading"">
                            Ask your questions with #askmefaq on twitter!
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 col-md-10 mx-auto"">
                ");
                Write(
#nullable restore
#line 66 "C:\Users\lordn\Desktop\OrchardCMS\FAQTheme\Views\Layout.cshtml"
                 await RenderSectionAsync("Messages", required: false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n                ");
                Write(
#nullable restore
#line 67 "C:\Users\lordn\Desktop\OrchardCMS\FAQTheme\Views\Layout.cshtml"
                 await RenderBodyAsync()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
            </div>
        </div>
    </div>
    <footer>


        <div class=""widget-container"">

            <div class=""row"">
                <div class=""col-lg-8 col-md-10 mx-auto"">
                    <p class=""copyright text-muted"">Copyright � FAQ Website ");
                Write(
#nullable restore
#line 78 "C:\Users\lordn\Desktop\OrchardCMS\FAQTheme\Views\Layout.cshtml"
                                                                             DateTime.UtcNow.Year

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"</p>
                </div>
            </div>

        </div>
    </footer>
    <script crossorigin=""anonymous"" integrity=""sha384-mlceH9HlqLp7GMKHrj5Ara1+LvdTZVMx4S1U43/NxCvAkzIo8WJ0FE7duLel3wVo"" src=""https://code.jquery.com/jquery-3.4.1.js"" type=""text/javascript""></script>
    <script crossorigin=""anonymous"" integrity=""sha384-szbKYgPl66wivXHlSpJF+CKDAVckMVnlGrP25Sndhe+PwOBcXV9LlFh4MUpRhjIB"" src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.js"" type=""text/javascript""></script>
    <script src=""/TheBlogTheme/js/clean-blog.js?v=tkp25Y3lQFc5HcsuZD8ZrgIT-lFBR42ujZ3pgaugvjA"" type=""text/javascript""></script>
    <script src=""/OrchardCore.Menu/Scripts/activate-links.js?v=bA97Ku-wd8s60CbBXnPvUtRoaoBKCkyIPRpAUSyhSb8"" type=""text/javascript""></script>
    <script src=""/TheBlogTheme/js/clean-blog-ext.js?v=AYd5Nlh_uolBL5ujHBpdyiTYUdUahomLSxwS9cJJVZk"" type=""text/javascript""></script>
    <!-- Visual Studio Browser Link -->
    <script type=""text/javascript"" src=""/_vs/browserLink"" async=""async"" id");
                WriteLiteral(@"=""__browserLink_initializationData"" data-requestid=""520cdc22770e4265a879169cafb83b19"" data-requestmappingfromserver=""false"" data-connecturl=""http://localhost:52464/668718463b274f259a540e9b5257466b/browserLink""></script>
    <!-- End Browser Link -->
    <script src=""/_framework/aspnetcore-browser-refresh.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "F:\projects\c#\TirdaadSchool\TirdaadSchool\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99ea6a47c62656d0a097d433aee04a71432bb85a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99ea6a47c62656d0a097d433aee04a71432bb85a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\projects\c#\TirdaadSchool\TirdaadSchool\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "خانه";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("SearchBox", async() => {
                WriteLiteral("\r\n    <header>\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 95, "\"", 102, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""logo""><img src=""/images/logo.png""></a>
        <h1> با اساتید مجرب و کارآزموده در خودآموز تاپ لرن </h1>
        <h2> آموزش ببینید ، تجربه کسب کنید و بازار کار شوید </h2>
        <h3> با کمترین هزینه خودت یاد بگیر </h3>
    </header>
    <div class=""search-form"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ea6a47c62656d0a097d433aee04a71432bb85a3663", async() => {
                    WriteLiteral("\r\n            <input type=\"text\"");
                    BeginWriteAttribute("name", " name=\"", 426, "\"", 433, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"چی دوست داری یاد بگیری ؟\">\r\n            <button><i class=\"zmdi zmdi-search\"></i></button>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            WriteLiteral("<main id=\"home-page\">\r\n    <div class=\"container\">\r\n        <section class=\"terms-items\">\r\n            <header>\r\n                <h2> آخرین دوره های تاپ لرن </h2>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 753, "\"", 760, 0);
            EndWriteAttribute();
            WriteLiteral("> مشاهده همه دوره ها </a>\r\n            </header>\r\n            <div class=\"row\">\r\n                <!-- col -->\r\n                <div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n                    <article>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1006, "\"", 1013, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/1.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 1098, "\"", 1105, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1487, "\"", 1494, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/2.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 1579, "\"", 1586, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1968, "\"", 1975, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/3.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 2060, "\"", 2067, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 150.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2456, "\"", 2463, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/4.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 2548, "\"", 2555, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2937, "\"", 2944, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/5.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 3029, "\"", 3036, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 15.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 3424, "\"", 3431, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/6.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 3516, "\"", 3523, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 3905, "\"", 3912, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/7.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 3997, "\"", 4004, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 20.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 4392, "\"", 4399, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/8.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 4484, "\"", 4491, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 75.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
            </div>
        </section>

        <hr>

        <section class=""terms-items"">
            <header>
                <h2> دوره های محبوب تاپ لرن </h2>
                <a");
            BeginWriteAttribute("href", " href=\"", 4903, "\"", 4910, 0);
            EndWriteAttribute();
            WriteLiteral("> مشاهده همه دوره ها </a>\r\n            </header>\r\n            <div class=\"row\">\r\n                <!-- col -->\r\n                <div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n                    <article>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5156, "\"", 5163, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/1.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 5248, "\"", 5255, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 5637, "\"", 5644, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/2.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 5729, "\"", 5736, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 6118, "\"", 6125, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/3.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 6210, "\"", 6217, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 150.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 6606, "\"", 6613, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/4.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 6698, "\"", 6705, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 7087, "\"", 7094, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/5.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 7179, "\"", 7186, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 15.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 7574, "\"", 7581, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/6.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 7666, "\"", 7673, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 8055, "\"", 8062, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/7.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 8147, "\"", 8154, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 20.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 8542, "\"", 8549, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/8.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 8634, "\"", 8641, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 75.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
            </div>
        </section>
    </div>
</main>

");
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

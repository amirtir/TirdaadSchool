#pragma checksum "C:\Users\Amir\source\repos\TirdaadSchool\TirdaadSchool\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99ea6a47c62656d0a097d433aee04a71432bb85a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Amir\source\repos\TirdaadSchool\TirdaadSchool\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "خانه";

#line default
#line hidden
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SearchBox", async() => {
                BeginContext(69, 319, true);
                WriteLiteral(@"
    <header>
        <a href="""" class=""logo""><img src=""/images/logo.png""></a>
        <h1> با اساتید مجرب و کارآزموده در خودآموز تاپ لرن </h1>
        <h2> آموزش ببینید ، تجربه کسب کنید و بازار کار شوید </h2>
        <h3> با کمترین هزینه خودت یاد بگیر </h3>
    </header>
    <div class=""search-form"">
        ");
                EndContext();
                BeginContext(388, 166, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca3698d75499c8db5759208c4557c", async() => {
                    BeginContext(394, 153, true);
                    WriteLiteral("\r\n            <input type=\"text\" name=\"\" placeholder=\"چی دوست داری یاد بگیری ؟\">\r\n            <button><i class=\"zmdi zmdi-search\"></i></button>\r\n        ");
                    EndContext();
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
                EndContext();
                BeginContext(554, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(571, 8357, true);
            WriteLiteral(@"<main id=""home-page"">
    <div class=""container"">
        <section class=""terms-items"">
            <header>
                <h2> آخرین دوره های تاپ لرن </h2>
                <a href=""""> مشاهده همه دوره ها </a>
            </header>
            <div class=""row"">
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/1.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/2.jpg""></a>
                        <h2><a href=""""> آموزش ");
            WriteLiteral(@"متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/3.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 150.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/4.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                    ");
            WriteLiteral(@"    <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/5.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 15.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/6.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:");
            WriteLiteral(@"52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/7.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 20.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/8.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 75.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
       ");
            WriteLiteral(@"         </div>
                <!-- /col -->
            </div>
        </section>

        <hr>

        <section class=""terms-items"">
            <header>
                <h2> دوره های محبوب تاپ لرن </h2>
                <a href=""""> مشاهده همه دوره ها </a>
            </header>
            <div class=""row"">
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/1.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/2.jpg");
            WriteLiteral(@"""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/3.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 150.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/4.jpg""></a>
                        <h2><a href=""""> آموزش م");
            WriteLiteral(@"تریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/5.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 15.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/6.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                      ");
            WriteLiteral(@"  <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/7.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 20.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a href="""" class=""img-layer""><img src=""/images/pic/8.jpg""></a>
                        <h2><a href=""""> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 75.000 تومان </span>
                        <");
            WriteLiteral("i>1:52:32</i>\r\n                    </article>\r\n                </div>\r\n                <!-- /col -->\r\n            </div>\r\n        </section>\r\n    </div>\r\n</main>\r\n\r\n");
            EndContext();
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

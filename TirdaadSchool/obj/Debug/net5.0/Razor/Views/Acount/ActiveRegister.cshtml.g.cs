#pragma checksum "C:\Users\Amir\source\repos\TirdaadSchool\TirdaadSchool\Views\Acount\ActiveRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba5f986aa25da1b2be0413a233eae8286f2867a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acount_ActiveRegister), @"mvc.1.0.view", @"/Views/Acount/ActiveRegister.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba5f986aa25da1b2be0413a233eae8286f2867a6", @"/Views/Acount/ActiveRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Acount_ActiveRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Amir\source\repos\TirdaadSchool\TirdaadSchool\Views\Acount\ActiveRegister.cshtml"
  
    ViewData["Title"] = "فعالسازی حساب کاربری";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<nav aria-label=\"breadcrumb\">\r\n    <ul class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\"><a href=\"#\">آموزشگاه تیرداد</a></li>\r\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">  فعالسازی حساب کاربری</li>\r\n    </ul>\r\n</nav>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Amir\source\repos\TirdaadSchool\TirdaadSchool\Views\Acount\ActiveRegister.cshtml"
 if(ViewBag.IsActive==true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class="" alert alert-success"">

    <h2>کاربر عزیز حساب کاربری شما با موفقیت فعال شد. در حال حاضر شما می توانید از امکانات سایت استفاده کنید.  </h2>
    <hr />
    
    <div class=""link"">

        <a href=""/Login""> <i class=""zmdi zmdi-account""></i> ورود به سایت </a>
    </div>
</div>
");
#nullable restore
#line 27 "C:\Users\Amir\source\repos\TirdaadSchool\TirdaadSchool\Views\Acount\ActiveRegister.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class="" alert alert-danger"">

    <h2>  متاسفانه حساب کاربری با مشخصات وارد شده پیدا نشد. لطفا لینک فعالسازی را مجددا بررسی و امتحان کنید. </h2>
    <hr />
    
    <div class=""link"">

        <a href=""/Login""> <i class=""zmdi zmdi-account""></i> ورود به سایت </a>
    </div>
</div>
");
#nullable restore
#line 40 "C:\Users\Amir\source\repos\TirdaadSchool\TirdaadSchool\Views\Acount\ActiveRegister.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
#pragma checksum "F:\projects\c#\TirdaadSchool\TirdaadSchool\Views\Shared\_ForgotPasswordEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a5aef55d737ff91a563faa8d3031c84a089982d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ForgotPasswordEmail), @"mvc.1.0.view", @"/Views/Shared/_ForgotPasswordEmail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a5aef55d737ff91a563faa8d3031c84a089982d", @"/Views/Shared/_ForgotPasswordEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ForgotPasswordEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TirdaadSchool.DataLayer.Entities.User.User>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\projects\c#\TirdaadSchool\TirdaadSchool\Views\Shared\_ForgotPasswordEmail.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<div class=\"container-content\" style=\"direction:rtl; padding:20px\">\r\n\r\n    <h3>");
#nullable restore
#line 10 "F:\projects\c#\TirdaadSchool\TirdaadSchool\Views\Shared\_ForgotPasswordEmail.cshtml"
   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  عزیز !</h3>\r\n\r\n\r\n    <p> برای بازیابی رمز عبور خود، روی لینک زیر کلیک  کنید.   </p>\r\n    <hr />\r\n    <p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 311, "\"", 373, 2);
            WriteAttributeValue("", 318, "https://localhost:44324/ResetPassword/", 318, 38, true);
#nullable restore
#line 16 "F:\projects\c#\TirdaadSchool\TirdaadSchool\Views\Shared\_ForgotPasswordEmail.cshtml"
WriteAttributeValue("", 356, Model.ActiveCode, 356, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">بازیابی کلمه عبور</a>\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TirdaadSchool.DataLayer.Entities.User.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

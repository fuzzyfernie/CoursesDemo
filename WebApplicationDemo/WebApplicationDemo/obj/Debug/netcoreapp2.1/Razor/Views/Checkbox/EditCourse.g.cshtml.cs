#pragma checksum "C:\Users\Fernie\Documents\Visual Studio 2017\Projects\WebApplicationDemo\WebApplicationDemo\Views\Checkbox\EditCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0d989a2100557e3437e38c380fd6f6debc75549"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkbox_EditCourse), @"mvc.1.0.view", @"/Views/Checkbox/EditCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Checkbox/EditCourse.cshtml", typeof(AspNetCore.Views_Checkbox_EditCourse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d989a2100557e3437e38c380fd6f6debc75549", @"/Views/Checkbox/EditCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkbox_EditCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplicationDemo.Models.Courselist>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Fernie\Documents\Visual Studio 2017\Projects\WebApplicationDemo\WebApplicationDemo\Views\Checkbox\EditCourse.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(72, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(101, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d1ba50bf0b941719ca15309613f4e12", async() => {
                BeginContext(107, 92, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>EditCourse</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(206, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(208, 597, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dceb69bad84648bd909cbf78008db76a", async() => {
                BeginContext(214, 18, true);
                WriteLiteral("\r\n    <center>\r\n\r\n");
                EndContext();
#line 16 "C:\Users\Fernie\Documents\Visual Studio 2017\Projects\WebApplicationDemo\WebApplicationDemo\Views\Checkbox\EditCourse.cshtml"
         using (Html.BeginForm())
        {
            for (int i = 0; i < Model.courses.Count; i++)
            {
                

#line default
#line hidden
                BeginContext(369, 48, false);
#line 20 "C:\Users\Fernie\Documents\Visual Studio 2017\Projects\WebApplicationDemo\WebApplicationDemo\Views\Checkbox\EditCourse.cshtml"
           Write(Html.CheckBoxFor(m =>Model.courses[i].ischecked));

#line default
#line hidden
                EndContext();
                BeginContext(436, 26, false);
#line 21 "C:\Users\Fernie\Documents\Visual Studio 2017\Projects\WebApplicationDemo\WebApplicationDemo\Views\Checkbox\EditCourse.cshtml"
           Write(Model.courses[i].ClassName);

#line default
#line hidden
                EndContext();
                BeginContext(481, 45, false);
#line 22 "C:\Users\Fernie\Documents\Visual Studio 2017\Projects\WebApplicationDemo\WebApplicationDemo\Views\Checkbox\EditCourse.cshtml"
           Write(Html.HiddenFor(m => Model.courses[i].ClassID));

#line default
#line hidden
                EndContext();
                BeginContext(545, 46, false);
#line 23 "C:\Users\Fernie\Documents\Visual Studio 2017\Projects\WebApplicationDemo\WebApplicationDemo\Views\Checkbox\EditCourse.cshtml"
           Write(Html.HiddenFor(m=> Model.courses[i].ClassName));

#line default
#line hidden
                EndContext();
                BeginContext(593, 24, true);
                WriteLiteral("                <br />\r\n");
                EndContext();
#line 25 "C:\Users\Fernie\Documents\Visual Studio 2017\Projects\WebApplicationDemo\WebApplicationDemo\Views\Checkbox\EditCourse.cshtml"
            }


#line default
#line hidden
                BeginContext(634, 112, true);
                WriteLiteral("            <input type=\"submit\" value=\"Get Selected Checkboxlist Items\" />\r\n            <hr/>\r\n            <h1>");
                EndContext();
                BeginContext(747, 14, false);
#line 29 "C:\Users\Fernie\Documents\Visual Studio 2017\Projects\WebApplicationDemo\WebApplicationDemo\Views\Checkbox\EditCourse.cshtml"
           Write(ViewBag.chkmsg);

#line default
#line hidden
                EndContext();
                BeginContext(761, 7, true);
                WriteLiteral("</h1>\r\n");
                EndContext();
#line 30 "C:\Users\Fernie\Documents\Visual Studio 2017\Projects\WebApplicationDemo\WebApplicationDemo\Views\Checkbox\EditCourse.cshtml"
        }

#line default
#line hidden
                BeginContext(779, 19, true);
                WriteLiteral("    </center>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(805, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationDemo.Models.Courselist> Html { get; private set; }
    }
}
#pragma warning restore 1591
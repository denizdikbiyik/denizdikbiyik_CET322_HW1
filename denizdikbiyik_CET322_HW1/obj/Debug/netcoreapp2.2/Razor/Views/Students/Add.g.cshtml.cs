#pragma checksum "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18a696763249e7c2546a4470c32994b3723bfcd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Add), @"mvc.1.0.view", @"/Views/Students/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Add.cshtml", typeof(AspNetCore.Views_Students_Add))]
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
#line 1 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\_ViewImports.cshtml"
using denizdikbiyik_CET322_HW1;

#line default
#line hidden
#line 2 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\_ViewImports.cshtml"
using denizdikbiyik_CET322_HW1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18a696763249e7c2546a4470c32994b3723bfcd8", @"/Views/Students/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9c7c60c74243eb8534453e6ea65d3528b856af4", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Students", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(20, 33, true);
            WriteLiteral("    <h2> Öğrenci Ekle </h2>\r\n    ");
            EndContext();
            BeginContext(53, 1310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18a696763249e7c2546a4470c32994b3723bfcd84353", async() => {
                BeginContext(120, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(131, 28, false);
#line 5 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
                EndContext();
                BeginContext(159, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(170, 25, false);
#line 6 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
                EndContext();
                BeginContext(195, 91, true);
                WriteLiteral("\r\n        <div class=\"editor-field\">\r\n            Adınız:\r\n            <br />\r\n            ");
                EndContext();
                BeginContext(287, 35, false);
#line 10 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(322, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(337, 46, false);
#line 11 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(383, 110, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            Soyadınız:\r\n            <br />\r\n            ");
                EndContext();
                BeginContext(494, 38, false);
#line 16 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.EditorFor(model => model.Surname));

#line default
#line hidden
                EndContext();
                BeginContext(532, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(547, 49, false);
#line 17 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Surname));

#line default
#line hidden
                EndContext();
                BeginContext(596, 118, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            Öğrenci Numaranız:\r\n            <br />\r\n            ");
                EndContext();
                BeginContext(715, 40, false);
#line 22 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.EditorFor(model => model.StudentNo));

#line default
#line hidden
                EndContext();
                BeginContext(755, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(770, 51, false);
#line 23 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.StudentNo));

#line default
#line hidden
                EndContext();
                BeginContext(821, 115, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            Mail Adresiniz:\r\n            <br />\r\n            ");
                EndContext();
                BeginContext(937, 36, false);
#line 28 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(973, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(988, 47, false);
#line 29 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1035, 118, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            Telefon Numaranız:\r\n            <br />\r\n            ");
                EndContext();
                BeginContext(1154, 36, false);
#line 34 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.EditorFor(model => model.TelNo));

#line default
#line hidden
                EndContext();
                BeginContext(1190, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1205, 47, false);
#line 35 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.TelNo));

#line default
#line hidden
                EndContext();
                BeginContext(1252, 104, true);
                WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <button type=\"submit\" class=\"btn btn-dark\">Ekle</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1363, 26, true);
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n");
            EndContext();
#line 42 "C:\Users\Deniz\Desktop\denizdikbiyik_CET322_HW1\denizdikbiyik_CET322_HW1\Views\Students\Add.cshtml"
    ViewData["Title"] = "Öğrenci Ekle";

#line default
#line hidden
            BeginContext(1433, 92, true);
            WriteLiteral("<h4>Eklenen öğrenciyi CET Bölümü Öğrencileri sayfasından kontrol edebilirsiniz.</h4>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
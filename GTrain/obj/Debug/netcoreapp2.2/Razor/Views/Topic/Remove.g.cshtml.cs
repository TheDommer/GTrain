#pragma checksum "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Remove.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e822ec7394efc45c619cdee03a83b188c354187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_Remove), @"mvc.1.0.view", @"/Views/Topic/Remove.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Topic/Remove.cshtml", typeof(AspNetCore.Views_Topic_Remove))]
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
#line 1 "C:\Users\Dominick\source\repos3\GTrain\Views\_ViewImports.cshtml"
using GTrain;

#line default
#line hidden
#line 2 "C:\Users\Dominick\source\repos3\GTrain\Views\_ViewImports.cshtml"
using GTrain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e822ec7394efc45c619cdee03a83b188c354187", @"/Views/Topic/Remove.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33f08bab36f2df692bb3696aff6b1521f139955", @"/Views/_ViewImports.cshtml")]
    public class Views_Topic_Remove : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Remove.cshtml"
  
    ViewData["Title"] = "Remove A Topic";

#line default
#line hidden
            BeginContext(52, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(59, 13, false);
#line 6 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Remove.cshtml"
Write(ViewBag.title);

#line default
#line hidden
            EndContext();
            BeginContext(72, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
            BeginContext(81, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e822ec7394efc45c619cdee03a83b188c3541874142", async() => {
                BeginContext(101, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 10 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Remove.cshtml"
     foreach (var topic in ViewBag.topics)
    {

#line default
#line hidden
                BeginContext(156, 46, true);
                WriteLiteral("        <input type=\"checkbox\" name=\"topicIds\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 202, "\"", 216, 1);
#line 12 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Remove.cshtml"
WriteAttributeValue("", 207, topic.ID, 207, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 217, "\"", 234, 1);
#line 12 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Remove.cshtml"
WriteAttributeValue("", 225, topic.ID, 225, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(235, 19, true);
                WriteLiteral(" />\r\n        <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 254, "\"", 269, 1);
#line 13 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Remove.cshtml"
WriteAttributeValue("", 260, topic.ID, 260, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(270, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(272, 10, false);
#line 13 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Remove.cshtml"
                          Write(topic.Name);

#line default
#line hidden
                EndContext();
                BeginContext(282, 26, true);
                WriteLiteral("</label>\r\n        <br />\r\n");
                EndContext();
#line 15 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Remove.cshtml"
    }

#line default
#line hidden
                BeginContext(315, 64, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Remove Selected Topic(s)\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(386, 4, true);
            WriteLiteral("\r\n\r\n");
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

#pragma checksum "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a91967100290e934eb502b9deadc692024a36c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_Index), @"mvc.1.0.view", @"/Views/Topic/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Topic/Index.cshtml", typeof(AspNetCore.Views_Topic_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91967100290e934eb502b9deadc692024a36c50", @"/Views/Topic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33f08bab36f2df692bb3696aff6b1521f139955", @"/Views/_ViewImports.cshtml")]
    public class Views_Topic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GTrain.Models.Topic>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Index.cshtml"
  
    ViewData["Title"] = "TopicIndex";

#line default
#line hidden
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(86, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(93, 13, false);
#line 9 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(106, 144, true);
            WriteLiteral("</h1>\r\n\r\n<table class=\"table\">\r\n\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Description</th>\r\n        <!--<td>Category</td>-->\r\n    </tr>\r\n\r\n");
            EndContext();
#line 19 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Index.cshtml"
     foreach (var topic in Model)
    {

#line default
#line hidden
            BeginContext(292, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(323, 10, false);
#line 22 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Index.cshtml"
           Write(topic.Name);

#line default
#line hidden
            EndContext();
            BeginContext(333, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(357, 17, false);
#line 23 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Index.cshtml"
           Write(topic.Description);

#line default
#line hidden
            EndContext();
            BeginContext(374, 75, true);
            WriteLiteral("</td>\r\n            <!--<td>(at)topic.Category.Name</td>-->\r\n        </tr>\r\n");
            EndContext();
#line 26 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(456, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
#line 29 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(495, 45, true);
            WriteLiteral("    <p>No topics have been created yet!</p>\r\n");
            EndContext();
#line 32 "C:\Users\Dominick\source\repos3\GTrain\Views\Topic\Index.cshtml"
}

#line default
#line hidden
            BeginContext(543, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(546, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a91967100290e934eb502b9deadc692024a36c506600", async() => {
                BeginContext(589, 9, true);
                WriteLiteral("Add Topic");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(602, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(611, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a91967100290e934eb502b9deadc692024a36c508185", async() => {
                BeginContext(657, 12, true);
                WriteLiteral("Remove Topic");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(673, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GTrain.Models.Topic>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Dominick\source\repos3\GTrain\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45393f36e6eb449655deac6852daca2719a17598"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45393f36e6eb449655deac6852daca2719a17598", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33f08bab36f2df692bb3696aff6b1521f139955", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Dominick\source\repos3\GTrain\Views\Home\Privacy.cshtml"
  
    //ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(52, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(57, 17, false);
#line 4 "C:\Users\Dominick\source\repos3\GTrain\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(74, 1393, true);
            WriteLiteral(@"</h1>

<h1><b>Capstone Project Goals</b></h1>
<div>
    <ul><b>User Login</b>-Users will be able to log into their own profile, based on their training role.</ul>
    <ul>
        <b>Due Date</b>-Categories and topics will have due dates assigned to them to ensure that training is completed
        within a certain timeline.
    </ul>
    <ul>
        <b>Topic Time Stamp </b>-Once a topic is completed, a time stamp will show that the training has been completed,
        as well as the time and date it was completed.
    </ul>
</div>
<h1><b>Project Stretch Goals</b></h1>
<div>
    <ul>
        <b>Additional Training Materials</b>-Trainers and Administrators will be able to add addtional training materials, 
        such as attaching PDF files, links to websites, or videos. 
    </ul>
    <ul>
        <b>Custom Development Testing</b>-Administrators will be able to develop custom tests on topics and categories,
        including multiple choice or qualitative testing.
    </ul>
    <ul>");
            WriteLiteral(@"
        <b>Training Due Date Alerts</b>-Automatically generates alerts for when assigned topics are nearing their
        due date.
    </ul>
    <ul>
        <b>Message System</b>-A messaging system within the website where questions can be sent and replied to allow
        enhancment of training information based questions that may arise.
    </ul>
</div>
");
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

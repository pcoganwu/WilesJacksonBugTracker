#pragma checksum "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b226fd2937c20cb03bf65efff5c57ac6530e48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bugs_Details), @"mvc.1.0.view", @"/Views/Bugs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bugs/Details.cshtml", typeof(AspNetCore.Views_Bugs_Details))]
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
#line 1 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\_ViewImports.cshtml"
using WilesJacksonBugTracker.Client_APP;

#line default
#line hidden
#line 2 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\_ViewImports.cshtml"
using WilesJacksonBugTracker.Client_APP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b226fd2937c20cb03bf65efff5c57ac6530e48", @"/Views/Bugs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2802f7d2184d33a18877fbc06e19d013f219d38", @"/Views/_ViewImports.cshtml")]
    public class Views_Bugs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WilesJacksonBugTracker.Repository.Domain.Bugs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(99, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Bugs</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(227, 48, false);
#line 14 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugCreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(275, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(339, 44, false);
#line 17 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugCreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(383, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(446, 48, false);
#line 20 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugCreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(494, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(558, 44, false);
#line 23 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugCreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(602, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(665, 47, false);
#line 26 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugClosedBy));

#line default
#line hidden
            EndContext();
            BeginContext(712, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(776, 43, false);
#line 29 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugClosedBy));

#line default
#line hidden
            EndContext();
            BeginContext(819, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(882, 47, false);
#line 32 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugClosedOn));

#line default
#line hidden
            EndContext();
            BeginContext(929, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(993, 43, false);
#line 35 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugClosedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1099, 56, false);
#line 38 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugResolutionSummary));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1219, 52, false);
#line 41 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugResolutionSummary));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1334, 47, false);
#line 44 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugPriority));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1445, 59, false);
#line 47 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugPriority.BugPriorityType));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1567, 45, false);
#line 50 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1676, 55, false);
#line 53 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugStatus.BugStatusType));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1794, 43, false);
#line 56 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1901, 51, false);
#line 59 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1952, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1999, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b226fd2937c20cb03bf65efff5c57ac6530e4811758", async() => {
                BeginContext(2045, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2053, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2061, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b226fd2937c20cb03bf65efff5c57ac6530e4814111", async() => {
                BeginContext(2083, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(2099, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WilesJacksonBugTracker.Repository.Domain.Bugs> Html { get; private set; }
    }
}
#pragma warning restore 1591
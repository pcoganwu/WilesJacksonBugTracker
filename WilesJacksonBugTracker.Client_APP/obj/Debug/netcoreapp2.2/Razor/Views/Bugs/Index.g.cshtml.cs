#pragma checksum "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80676fa846f31e1a0bd1d484143998a5927d911c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bugs_Index), @"mvc.1.0.view", @"/Views/Bugs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bugs/Index.cshtml", typeof(AspNetCore.Views_Bugs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80676fa846f31e1a0bd1d484143998a5927d911c", @"/Views/Bugs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2802f7d2184d33a18877fbc06e19d013f219d38", @"/Views/_ViewImports.cshtml")]
    public class Views_Bugs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WilesJacksonBugTracker.Repository.Domain.Bugs>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(110, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(139, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80676fa846f31e1a0bd1d484143998a5927d911c4886", async() => {
                BeginContext(162, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(176, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(269, 48, false);
#line 16 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BugCreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(317, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(373, 48, false);
#line 19 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BugCreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(421, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(477, 47, false);
#line 22 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BugClosedBy));

#line default
#line hidden
            EndContext();
            BeginContext(524, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(580, 47, false);
#line 25 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BugClosedOn));

#line default
#line hidden
            EndContext();
            BeginContext(627, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(683, 56, false);
#line 28 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BugResolutionSummary));

#line default
#line hidden
            EndContext();
            BeginContext(739, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(795, 47, false);
#line 31 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BugPriority));

#line default
#line hidden
            EndContext();
            BeginContext(842, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(898, 45, false);
#line 34 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BugStatus));

#line default
#line hidden
            EndContext();
            BeginContext(943, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(999, 48, false);
#line 37 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Project.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1165, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1214, 47, false);
#line 46 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BugCreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1317, 47, false);
#line 49 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BugCreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1420, 46, false);
#line 52 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BugClosedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1522, 46, false);
#line 55 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BugClosedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1624, 55, false);
#line 58 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BugResolutionSummary));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1735, 62, false);
#line 61 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BugPriority.BugPriorityType));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1853, 58, false);
#line 64 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BugStatus.BugStatusType));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1967, 54, false);
#line 67 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Project.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2021, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2076, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80676fa846f31e1a0bd1d484143998a5927d911c14020", async() => {
                BeginContext(2121, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(2129, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2149, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80676fa846f31e1a0bd1d484143998a5927d911c16395", async() => {
                BeginContext(2197, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(2208, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2228, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80676fa846f31e1a0bd1d484143998a5927d911c18776", async() => {
                BeginContext(2275, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(2285, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 75 "C:\Users\Peter\source\repos\WilesJacksonBugTracker\WilesJacksonBugTracker.Client_APP\Views\Bugs\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2324, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WilesJacksonBugTracker.Repository.Domain.Bugs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
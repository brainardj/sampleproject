#pragma checksum "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fc535f732beb69a94dc70ad2f8b89d31be26f82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hikes_Details), @"mvc.1.0.view", @"/Views/Hikes/Details.cshtml")]
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
#nullable restore
#line 1 "c:\Users\beats\Desktop\sampleproject\Views\_ViewImports.cshtml"
using sampleproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\beats\Desktop\sampleproject\Views\_ViewImports.cshtml"
using sampleproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fc535f732beb69a94dc70ad2f8b89d31be26f82", @"/Views/Hikes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22d4dc31e3c119ffe7da11f6bf0aa5b0fb33265", @"/Views/_ViewImports.cshtml")]
    public class Views_Hikes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sampleproject.Models.Hike>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("  \r\n");
#nullable restore
#line 3 "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml"
    
    ViewData["Title"] = "Details";  

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Details</h2>  \r\n<div>  \r\n    <h4>Employees</h4>  \r\n    <hr />  \r\n    <dl class=\"dl-horizontal\">  \r\n        <dt>  \r\n            ");
#nullable restore
#line 12 "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HikeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </dt>  \r\n        <dd>  \r\n            ");
#nullable restore
#line 15 "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml"
       Write(Html.DisplayFor(model => model.HikeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </dd>  \r\n        <dt>  \r\n            ");
#nullable restore
#line 18 "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </dt>  \r\n        <dd>  \r\n            ");
#nullable restore
#line 21 "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </dd>  \r\n        <dt>  \r\n            ");
#nullable restore
#line 24 "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HikeLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </dt>  \r\n        <dd>  \r\n            ");
#nullable restore
#line 27 "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml"
       Write(Html.DisplayFor(model => model.HikeLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </dd>  \r\n        <dt>  \r\n            ");
#nullable restore
#line 30 "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ElevationGain));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </dt>  \r\n        <dd>  \r\n            ");
#nullable restore
#line 33 "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ElevationGain));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </dd>  \r\n    </dl>  \r\n</div>  \r\n<div>  \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fc535f732beb69a94dc70ad2f8b89d31be26f826364", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 38 "c:\Users\beats\Desktop\sampleproject\Views\Hikes\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |  \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fc535f732beb69a94dc70ad2f8b89d31be26f828492", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("  \r\n</div>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sampleproject.Models.Hike> Html { get; private set; }
    }
}
#pragma warning restore 1591

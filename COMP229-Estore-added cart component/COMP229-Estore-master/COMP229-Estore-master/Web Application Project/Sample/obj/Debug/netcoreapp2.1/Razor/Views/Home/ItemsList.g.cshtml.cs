#pragma checksum "D:\Game programming\COMP229-Estore\COMP229-Estore-added cart component\COMP229-Estore-master\COMP229-Estore-master\Web Application Project\Sample\Views\Home\ItemsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fcb48e71655e534ef463a9059ec702542088593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ItemsList), @"mvc.1.0.view", @"/Views/Home/ItemsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ItemsList.cshtml", typeof(AspNetCore.Views_Home_ItemsList))]
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
#line 1 "D:\Game programming\COMP229-Estore\COMP229-Estore-added cart component\COMP229-Estore-master\COMP229-Estore-master\Web Application Project\Sample\Views\_ViewImports.cshtml"
using Sample;

#line default
#line hidden
#line 2 "D:\Game programming\COMP229-Estore\COMP229-Estore-added cart component\COMP229-Estore-master\COMP229-Estore-master\Web Application Project\Sample\Views\_ViewImports.cshtml"
using Sample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fcb48e71655e534ef463a9059ec702542088593", @"/Views/Home/ItemsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb18ec7718e9e031ec81c603586868f77986d15", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ItemsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomerDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisplayPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Game programming\COMP229-Estore\COMP229-Estore-added cart component\COMP229-Estore-master\COMP229-Estore-master\Web Application Project\Sample\Views\Home\ItemsList.cshtml"
  
    ViewData["Title"] = "ItemsList";

#line default
#line hidden
#line 6 "D:\Game programming\COMP229-Estore\COMP229-Estore-added cart component\COMP229-Estore-master\COMP229-Estore-master\Web Application Project\Sample\Views\Home\ItemsList.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(108, 49, true);
            WriteLiteral("<div class=\"center\">\n    <table>\n        <tbody>\n");
            EndContext();
#line 12 "D:\Game programming\COMP229-Estore\COMP229-Estore-added cart component\COMP229-Estore-master\COMP229-Estore-master\Web Application Project\Sample\Views\Home\ItemsList.cshtml"
             foreach(CustomerDetails stu in Model)
    {

#line default
#line hidden
            BeginContext(214, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(251, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75b788e850f2495295a5ac45b8be6e0c", async() => {
                BeginContext(322, 11, true);
                WriteLiteral("See details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-StudentNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "D:\Game programming\COMP229-Estore\COMP229-Estore-added cart component\COMP229-Estore-master\COMP229-Estore-master\Web Application Project\Sample\Views\Home\ItemsList.cshtml"
                                                             WriteLiteral(stu.PhoneNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["StudentNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-StudentNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["StudentNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(337, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(364, 13, false);
#line 16 "D:\Game programming\COMP229-Estore\COMP229-Estore-added cart component\COMP229-Estore-master\COMP229-Estore-master\Web Application Project\Sample\Views\Home\ItemsList.cshtml"
               Write(stu.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(377, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 18 "D:\Game programming\COMP229-Estore\COMP229-Estore-added cart component\COMP229-Estore-master\COMP229-Estore-master\Web Application Project\Sample\Views\Home\ItemsList.cshtml"
    }

#line default
#line hidden
            BeginContext(407, 36, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomerDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
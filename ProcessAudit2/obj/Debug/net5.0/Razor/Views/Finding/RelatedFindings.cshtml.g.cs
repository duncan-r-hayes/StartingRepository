#pragma checksum "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b95f5313bf3c6bcdb45afcc3337b400737323ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finding_RelatedFindings), @"mvc.1.0.view", @"/Views/Finding/RelatedFindings.cshtml")]
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
#line 1 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\_ViewImports.cshtml"
using ProcessAudit2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\_ViewImports.cshtml"
using ProcessAudit2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95f5313bf3c6bcdb45afcc3337b400737323ae4", @"/Views/Finding/RelatedFindings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dde8a4d5f7a7e0a641756f0bb85ce5801b87373", @"/Views/_ViewImports.cshtml")]
    public class Views_Finding_RelatedFindings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProcessAudit2.Models.PaFinding>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReturnToAudit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Finding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
  
    ViewData["Title"] = "RelatedFindings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Findings for Audit # ");
#nullable restore
#line 7 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                    Write(ViewBag.Audit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b95f5313bf3c6bcdb45afcc3337b400737323ae45327", async() => {
                WriteLiteral("Return to audit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-auditId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                                                  WriteLiteral(ViewBag.Audit);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["auditId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-auditId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["auditId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<hr>\r\n<div class=\"outer1\">\r\n");
#nullable restore
#line 14 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"bodie\">\r\n        <div class=\"title\">\r\n            <div class=\"top\">\r\n                <p class=\"title\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
               Write(Html.Raw("Audit #: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
               Write(Html.DisplayFor(modelItem => item.AuditId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 20 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                                             Write(Html.Raw("Finding # "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                                                                    Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <hr>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <div class=\"inner\">\r\n                    <p style=\"font-weight:bold\">");
#nullable restore
#line 28 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                           Write(Html.Raw("Type: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 29 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div class=\"long\">\r\n                    <p style=\"font-weight:bold\">");
#nullable restore
#line 33 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                           Write(Html.Raw("Description: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 34 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div class=\"long\">\r\n                    <p style=\"font-weight:bold\">");
#nullable restore
#line 38 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                           Write(Html.Raw("Action Required: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 39 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Action));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-3\" id=\"left\">\r\n");
#nullable restore
#line 43 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                 if (item.Image == null || item.Image == "")
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
           Write(Html.Raw("No Image Was Taken"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                               ;
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1686, "\"", 1748, 2);
#nullable restore
#line 49 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
WriteAttributeValue("", 1693, Html.Raw("/"), 1693, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
WriteAttributeValue("", 1707, Html.DisplayFor(modelItem => item.Image), 1707, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1792, "\"", 1853, 2);
#nullable restore
#line 50 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
WriteAttributeValue("", 1798, Html.Raw("/"), 1798, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
WriteAttributeValue("", 1812, Html.DisplayFor(modelItem => item.Image), 1812, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\" alt=\"car\">\r\n                </a>\r\n");
#nullable restore
#line 52 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3\" id=\"test\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b95f5313bf3c6bcdb45afcc3337b400737323ae414382", async() => {
                WriteLiteral("Edit&nbsp;|&nbsp;");
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
#nullable restore
#line 54 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b95f5313bf3c6bcdb45afcc3337b400737323ae416670", async() => {
                WriteLiteral("Remove");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            \r\n        </div>\r\n    </div>\r\n    <hr>\r\n");
#nullable restore
#line 62 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"outer2\">\r\n");
#nullable restore
#line 65 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"bodie\">\r\n        <div class=\"col-md-3\">\r\n            <div class=\"top\">\r\n                <p class=\"title\">\r\n                    ");
#nullable restore
#line 70 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
               Write(Html.Raw("Audit #: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 71 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
               Write(Html.DisplayFor(modelItem => item.AuditId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 71 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                                             Write(Html.Raw("Finding # "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                                                                    Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <hr>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <div class=\"inner\">\r\n                    <p style=\"font-weight:bold\">");
#nullable restore
#line 79 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                           Write(Html.Raw("Type: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 80 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <br>\r\n                <div class=\"inner\">\r\n                    <p style=\"font-weight:bold\">");
#nullable restore
#line 84 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                           Write(Html.Raw("Assignee: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 85 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Assignee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <br>\r\n                <div class=\"inner\">\r\n                    <p style=\"font-weight:bold\">");
#nullable restore
#line 89 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                           Write(Html.Raw("Date: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 90 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-3\" style=\"min-width:400px;max-width:400px;\">\r\n                <div class=\"long\">\r\n                    <p style=\"font-weight:bold\">");
#nullable restore
#line 95 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                           Write(Html.Raw("Description: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 96 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <br />\r\n                <div class=\"long\">\r\n                    <p style=\"font-weight:bold\">");
#nullable restore
#line 100 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                           Write(Html.Raw("Action Required: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 101 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Action));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n");
#nullable restore
#line 105 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                 if (item.Image == null || item.Image == "")
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
               Write(Html.Raw("No Image Was Taken"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                                   ;
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 4259, "\"", 4321, 2);
#nullable restore
#line 111 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
WriteAttributeValue("", 4266, Html.Raw("/"), 4266, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
WriteAttributeValue("", 4280, Html.DisplayFor(modelItem => item.Image), 4280, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 4365, "\"", 4426, 2);
#nullable restore
#line 112 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
WriteAttributeValue("", 4371, Html.Raw("/"), 4371, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
WriteAttributeValue("", 4385, Html.DisplayFor(modelItem => item.Image), 4385, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\" alt=\"car\">\r\n                    </a>\r\n");
#nullable restore
#line 114 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                }   

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-1\" id=\"butts\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b95f5313bf3c6bcdb45afcc3337b400737323ae427514", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 117 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                       WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b95f5313bf3c6bcdb45afcc3337b400737323ae429699", async() => {
                WriteLiteral("<i class=\"fa fa-minus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 123 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\RelatedFindings.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<style>\r\n    \r\n    ");
            WriteLiteral(@"@media only screen and (max-width:600px) {
        .outer1 {
            display: inline;
        }
        .col-md-1 {
            text-align: center;
            margin-left:15px;
        }

        .title {
            margin-left: 10px;
            font-weight: bold;
            margin-bottom: 0px;
            margin-top: 7px;
        }

        .test {
            margin-top: 50px;
            text-align: center;
        }

        .outer2 {
            display: none;
        }

        .col-md-3 {
            max-width: 50%;
        }

        img {
            max-height: 100%;
            max-width: 100%;
            float: right;
            clear: both;
            vertical-align: central;
            padding-bottom: 10px;
        }

        .bodie {
            background-color: #f2f3f4;
            border-radius: 8px;
            margin: auto;
        }

        .long {
            max-width: 95%;
        }
        #test {
            display: flex;
            WriteLiteral("\n            margin-left: 15px;\r\n        }\r\n        .row {\r\n            width: 100%;\r\n            height: auto;\r\n            border-radius: 8px;\r\n            margin-bottom: 25px;\r\n            margin-left: 4px;\r\n        }\r\n    }\r\n    ");
            WriteLiteral(@"@media only screen and (min-width:601px) and (max-width:999px) {
        .outer1 {
            display: inline;
        }
        #left {
            margin-left:150px;
        }
        .col-md-1 {
            text-align: center;
        }

        .title {
            margin-left: 10px;
            font-weight: bold;
            margin-bottom: 0px;
            margin-top: 7px;
        }
        #test {
            display:flex;
        }
        .test {
            margin-top: 50px;
            text-align: center;
        }

        .outer2 {
            display: none;
        }

        .col-md-3 {
            width:200%;
        }

        img {
            max-height: 100%;
            max-width: 100%;
            float: right;
            clear: both;
            vertical-align: central;
            padding-bottom: 10px;
            margin-left:40px;
        }

        .bodie {
            background-color: #f2f3f4;
            border-radius: 8px;
          ");
            WriteLiteral(@"  margin: auto;
        }

        .long {
            max-width: 95%;
        }

        .row {
            width: 100%;
            height: auto;
            border-radius: 8px;
            margin-bottom: 25px;
            margin-left: 4px;
        }
    }
    ");
            WriteLiteral(@"@media only screen and (min-width:1000px) {
        .outer1 {
            display: none;
        }

        .outer2 {
            display: block;
        }

        .outer {
            overflow: auto;
        }

        p {
            display: inline;
        }

        .bodie {
            background-color: #f2f3f4;
            padding-left: 15px;
            border-radius: 8px;
        }

        .edit {
        }

        a {
            display: block;
            margin-bottom: 5px;
            margin-right: 4px;
        }

        i {
            display: block;
            margin-left: 12%;
        }

        img {
            max-height: 100%;
            max-width: 100%;
            float: right;
            position: absolute;
            top: 0;
            bottom: 0;
            margin: auto;
            padding-bottom: 10px;
        }

        .row {
            width: 100%;
            height: 150px;
            background-color: #f2f3f4;
   ");
            WriteLiteral(@"         border-radius: 8px;
            margin-bottom: 25px;
        }

        .col-md-3 {
            min-width: 200px;
        }

        .col-md-1 {
            margin-left: 50px;
            margin-top: 30px;
        }

        .col-md-6 {
            max-width: 350px;
            max-height: 200px;
            float: right;
            display: block;
        }

        .title {
            font-weight: bold;
            text-decoration: underline;
            font-size: 16px;
        }
    }
    
    
</style>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProcessAudit2.Models.PaFinding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de3ffea0e5140950eadba4c8ca43fd8e457e8b4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finding_MyActions), @"mvc.1.0.view", @"/Views/Finding/MyActions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de3ffea0e5140950eadba4c8ca43fd8e457e8b4c", @"/Views/Finding/MyActions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dde8a4d5f7a7e0a641756f0bb85ce5801b87373", @"/Views/_ViewImports.cshtml")]
    public class Views_Finding_MyActions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProcessAudit2.Models.PaFinding>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteFinding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Finding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
  
    ViewData["Title"] = "RelatedFindings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>My Avaliable Tasks</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3ffea0e5140950eadba4c8ca43fd8e457e8b4c5017", async() => {
                WriteLiteral("Return home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<hr/>\r\n");
#nullable restore
#line 10 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
 if(Model.Count() == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
Write(Html.Raw("<h3>You have no tasks to complete!</h3>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                                        ;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"outer1\">\r\n");
#nullable restore
#line 15 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"bodie\">\r\n            <div class=\"title\">\r\n                <div class=\"top\">\r\n                    <p class=\"title\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                   Write(Html.Raw("Audit #: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 22 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AuditId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 22 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                                                 Write(Html.Raw("Finding # "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <hr>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    <div class=\"inner\">\r\n                        <p style=\"font-weight:bold\">");
#nullable restore
#line 30 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                               Write(Html.Raw("Type: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 31 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div class=\"long\">\r\n                        <p style=\"font-weight:bold\">");
#nullable restore
#line 35 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                               Write(Html.Raw("Description: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 36 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div class=\"long\">\r\n                        <p style=\"font-weight:bold\">");
#nullable restore
#line 40 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                               Write(Html.Raw("Action Required: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 41 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Action));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-3\" id=\"left\">\r\n");
#nullable restore
#line 45 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                     if (item.Image == null || item.Image == "")
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                   Write(Html.Raw("No Image Was Taken"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                                       ;
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 1842, "\"", 1904, 2);
#nullable restore
#line 51 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
WriteAttributeValue("", 1849, Html.Raw("/"), 1849, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
WriteAttributeValue("", 1863, Html.DisplayFor(modelItem => item.Image), 1863, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1956, "\"", 2017, 2);
#nullable restore
#line 52 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
WriteAttributeValue("", 1962, Html.Raw("/"), 1962, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
WriteAttributeValue("", 1976, Html.DisplayFor(modelItem => item.Image), 1976, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\" alt=\"car\">\r\n                        </a>\r\n");
#nullable restore
#line 54 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-1\" id=\"test\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3ffea0e5140950eadba4c8ca43fd8e457e8b4c13822", async() => {
                WriteLiteral("Complete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <hr>\r\n");
#nullable restore
#line 62 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"outer2\">\r\n");
#nullable restore
#line 65 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"bodie\">\r\n            <div class=\"col-md-3\">\r\n                <div class=\"top\">\r\n                    <p class=\"title\">\r\n                        ");
#nullable restore
#line 71 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                   Write(Html.Raw("Audit #: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 72 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AuditId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 72 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                                                 Write(Html.Raw("Finding # "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <hr>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    <div class=\"inner\">\r\n                        <p style=\"font-weight:bold\">");
#nullable restore
#line 80 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                               Write(Html.Raw("Type: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 81 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <br>\r\n                    <div class=\"inner\">\r\n                        <p style=\"font-weight:bold\">");
#nullable restore
#line 85 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                               Write(Html.Raw("Assignee: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 86 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Assignee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <br>\r\n                    <div class=\"inner\">\r\n                        <p style=\"font-weight:bold\">");
#nullable restore
#line 90 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                               Write(Html.Raw("Date: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 91 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-3\" style=\"min-width:400px;max-width:400px;\">\r\n                    <div class=\"long\">\r\n                        <p style=\"font-weight:bold\">");
#nullable restore
#line 96 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                               Write(Html.Raw("Description: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 97 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <br />\r\n                    <br />\r\n                    <div class=\"long\">\r\n                        <p style=\"font-weight:bold\">");
#nullable restore
#line 102 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                               Write(Html.Raw("Action Required: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 103 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Action));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n");
#nullable restore
#line 107 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                     if (item.Image == null || item.Image == "")
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                   Write(Html.Raw("No Image Was Taken"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                                       ;
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 4580, "\"", 4642, 2);
#nullable restore
#line 113 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
WriteAttributeValue("", 4587, Html.Raw("/"), 4587, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
WriteAttributeValue("", 4601, Html.DisplayFor(modelItem => item.Image), 4601, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 4694, "\"", 4755, 2);
#nullable restore
#line 114 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
WriteAttributeValue("", 4700, Html.Raw("/"), 4700, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
WriteAttributeValue("", 4714, Html.DisplayFor(modelItem => item.Image), 4714, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\" alt=\"car\">\r\n                        </a>\r\n");
#nullable restore
#line 116 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-md-1\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3ffea0e5140950eadba4c8ca43fd8e457e8b4c24986", async() => {
                WriteLiteral("Complete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 123 "C:\Users\duncan.hayes\source\repos\ProcessAudit2\ProcessAudit2\Views\Finding\MyActions.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<style>\r\n    ");
            WriteLiteral(@"@media only screen and (max-width:600px) {
        #comp {
            margin-top:10px;
        }
        .outer1 {
            display: inline;
        }

        .col-md-1 {
            text-align: center;
            margin-left: 15px;
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
            max-width: ");
            WriteLiteral(@"95%;
        }

        #test {
            display: flex;
            margin-left: 15px;
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
            WriteLiteral(@"@media only screen and (min-width:601px) and (max-width:999px) {
        .outer1 {
            display: inline;
        }

        #left {
            margin-left: 150px;
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
            display: flex;
        }

        .test {
            margin-top: 50px;
            text-align: center;
        }

        .outer2 {
            display: none;
        }

        .col-md-3 {
            width: 200%;
        }

        img {
            max-height: 100%;
            max-width: 100%;
            float: right;
            clear: both;
            vertical-align: central;
            padding-bottom: 10px;
            margin-left: 40px;
        }

        .bodie {
            background-color: #f2f3f4;
            border-radius: 8px;");
            WriteLiteral(@"
            margin: auto;
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
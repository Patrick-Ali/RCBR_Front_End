#pragma checksum "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eff1ccd2ccc0c4545a3182940aadefe0cccb8e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Teams), @"mvc.1.0.view", @"/Views/Team/Teams.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/Teams.cshtml", typeof(AspNetCore.Views_Team_Teams))]
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
#line 1 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\_ViewImports.cshtml"
using Race_boat_app;

#line default
#line hidden
#line 2 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\_ViewImports.cshtml"
using Race_boat_app.Models;

#line default
#line hidden
#line 1 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eff1ccd2ccc0c4545a3182940aadefe0cccb8e3", @"/Views/Team/Teams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5a3f5aabc245a5c220e2b6dae0dc8c7387a054", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Teams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Join>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
  
    ViewData["Title"] = "Teams";
    var users = ViewData["users"] as List<User>;
    var recruiting = ViewData["recruiting"] as List<string>;

#line default
#line hidden
            BeginContext(200, 335, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""heading-title text-center"">
            <h3 class=""text-uppercase"">Team List</h3>
            <p class=""p-top-30 half-txt"">Nam pulvinar vitae neque et porttitor. Praesent sed nisi eleifend. Nam pulvinar vitae neque et porttitor. Praesent sed nisi eleifend. </p>
");
            EndContext();
#line 14 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
             if (@Context.Session.GetString("_Posistion") == "Captain" && Context.Session.GetString("_LoggedIn") == "true" && Context.Session.GetString("_Team") == "null")
            {

#line default
#line hidden
            BeginContext(723, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(739, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eff1ccd2ccc0c4545a3182940aadefe0cccb8e35078", async() => {
                BeginContext(788, 125, true);
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-success btn-lg float-right\">Create Team</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
AddHtmlAttributeValue("", 753, Url.Action("CreateTeam", "Team"), 753, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(920, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
            }

#line default
#line hidden
            BeginContext(937, 50, true);
            WriteLiteral("        </div>\r\n        <!--var user in users-->\r\n");
            EndContext();
#line 22 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
         for (int i  = 0; i < users.Count; i++)
        {

#line default
#line hidden
            BeginContext(1047, 453, true);
            WriteLiteral(@"            <div class=""col-md-3 col-sm-3"">
                <div class=""team-member"">
                    <div class=""team-img"">
                        <img src=""https://image.freepik.com/free-photo/man-standing-with-a-black-t-shirt_1187-1045.jpg"" alt=""team member"" class=""img-responsive"">
                    </div>
                    <div class=""team-hover"">
                        <div class=""desk"">
                            <h4>Captain ");
            EndContext();
            BeginContext(1501, 18, false);
#line 31 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                                   Write(users[i].FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1519, 45, true);
            WriteLiteral("</h4>\r\n                            <p>Email: ");
            EndContext();
            BeginContext(1565, 14, false);
#line 32 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                                 Write(users[i].Email);

#line default
#line hidden
            EndContext();
            BeginContext(1579, 44, true);
            WriteLiteral("</p>\r\n                            <p>Phone: ");
            EndContext();
            BeginContext(1624, 26, false);
#line 33 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                                 Write(users[i].MobilePhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1650, 45, true);
            WriteLiteral("</p>\r\n                            <p>Points: ");
            EndContext();
            BeginContext(1696, 15, false);
#line 34 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                                  Write(users[i].Points);

#line default
#line hidden
            EndContext();
            BeginContext(1711, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 35 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                             if (Context.Session.GetString("_LoggedIn") == "true" && Context.Session.GetString("_Team") == users[i].Team)
                            {

#line default
#line hidden
            BeginContext(1887, 52, true);
            WriteLiteral("                                <p>Your Team</p>  \r\n");
            EndContext();
#line 38 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                            }

#line default
#line hidden
            BeginContext(1970, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#line 40 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                         if (Context.Session.GetString("_LoggedIn") == "true" && Context.Session.GetString("_Team") == "null" && recruiting[i] == "true"
                            && Context.Session.GetString("_Posistion") == "Pit")
                        {

#line default
#line hidden
            BeginContext(2265, 82, true);
            WriteLiteral("                            <div class=\"s-link\">\r\n                                ");
            EndContext();
            BeginContext(2347, 404, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eff1ccd2ccc0c4545a3182940aadefe0cccb8e311241", async() => {
                BeginContext(2394, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2432, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7eff1ccd2ccc0c4545a3182940aadefe0cccb8e311662", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
#line 45 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                                     WriteLiteral(users[i].Team);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 45 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TeamID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2493, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2531, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7eff1ccd2ccc0c4545a3182940aadefe0cccb8e314207", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
#line 46 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                                     WriteLiteral(users[i].Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 46 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Joiner);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2590, 154, true);
                WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn btn-success btn-sm float-left\">Join Team</button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 44 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
AddHtmlAttributeValue("", 2361, Url.Action("JoinTeam", "Team"), 2361, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2751, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 50 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                        }

#line default
#line hidden
            BeginContext(2816, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(3035, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 59 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
        }

#line default
#line hidden
            BeginContext(3066, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Join> Html { get; private set; }
    }
}
#pragma warning restore 1591

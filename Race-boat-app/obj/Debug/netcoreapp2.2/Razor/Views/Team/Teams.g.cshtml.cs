#pragma checksum "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96e1bf61543bac03683f13e788febf66c0e909c6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e1bf61543bac03683f13e788febf66c0e909c6", @"/Views/Team/Teams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5a3f5aabc245a5c220e2b6dae0dc8c7387a054", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Teams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
  
    ViewData["Title"] = "Teams";
    var users = ViewData.Model;

#line default
#line hidden
            BeginContext(71, 345, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <div class=""heading-title text-center"">
            <h3 class=""text-uppercase"">Team List</h3>
            <p class=""p-top-30 half-txt"">Nam pulvinar vitae neque et porttitor. Praesent sed nisi eleifend. Nam pulvinar vitae neque et porttitor. Praesent sed nisi eleifend. </p>
        </div>
");
            EndContext();
#line 14 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
         foreach (var user in users)
        {

#line default
#line hidden
            BeginContext(463, 446, true);
            WriteLiteral(@"            <div class=""col-md-3 col-sm-3"">
                <div class=""team-member"">
                    <div class=""team-img"">
                        <img src=""https://image.freepik.com/free-photo/man-standing-with-a-black-t-shirt_1187-1045.jpg"" alt=""team member"" class=""img-responsive"">
                    </div>
                    <div class=""team-hover"">
                        <div class=""desk"">
                            <h4>Captain ");
            EndContext();
            BeginContext(910, 14, false);
#line 23 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                                   Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(924, 37, true);
            WriteLiteral("</h4>\n                            <p>");
            EndContext();
            BeginContext(962, 10, false);
#line 24 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                          Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(972, 36, true);
            WriteLiteral("</p>\n                            <p>");
            EndContext();
            BeginContext(1009, 22, false);
#line 25 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
                          Write(user.MobilePhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 249, true);
            WriteLiteral("</p>\n                        </div>\n                        <div class=\"s-link\">\n                            <button class=\"btn btn-outline-primary\">Join Team</button>\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
            BeginContext(1441, 19, true);
            WriteLiteral("            </div>\n");
            EndContext();
#line 37 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Team\Teams.cshtml"
        }

#line default
#line hidden
            BeginContext(1470, 22, true);
            WriteLiteral("\n    </div>\n\n</div>\n\n\n");
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

#pragma checksum "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Event\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f3f1e2feb6b61108abd991accc5dc7a2bab40f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Events), @"mvc.1.0.view", @"/Views/Event/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/Events.cshtml", typeof(AspNetCore.Views_Event_Events))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f3f1e2feb6b61108abd991accc5dc7a2bab40f", @"/Views/Event/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5a3f5aabc245a5c220e2b6dae0dc8c7387a054", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Events : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Download>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("eventSID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Event\Events.cshtml"
  
    ViewData["Title"] = "Events";
    var events = ViewData.Model;

#line default
#line hidden
            BeginContext(93, 45, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div id=\'calendar\'></div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(786, 1473, true);
            WriteLiteral(@"
<div class=""modal"" id=""calendarModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""modalTitle""></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div id=""modalBody"" class=""modal-body"">
                <div class=""col-md-12"">
                    <span class=""col-md-4"">Location</span>:
                    <span class=""col-md-7"" id=""eventLoc""></span>
                </div>
                <div class=""col-md-12"">
                    <span class=""col-md-4"">Date</span>:
                    <span class=""col-md-7"" id=""eventDate""></span>
                </div>
                <div class=""col-md-12"">
                    <span class=""col-md-4"">Start Time</span>:
                    <span class=""col-md-7"" id=""eventSTime""></span>
                </div");
            WriteLiteral(@">
                <div class=""col-md-12"">
                    <span class=""col-md-4"">End Time</span>:
                    <span class=""col-md-7"" id=""eventETime""></span>
                </div>
                <div class=""col-md-12"">
                    <span class=""col-md-4"">Desc</span>:
                    <span class=""col-md-7"" id=""eventDesc""></span>
                </div>
                <div class=""col-md-12"">

                    ");
            EndContext();
            BeginContext(2259, 274, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3f3f1e2feb6b61108abd991accc5dc7a2bab40f6425", async() => {
                BeginContext(2307, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2333, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3f3f1e2feb6b61108abd991accc5dc7a2bab40f6833", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 66 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Event\Events.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                BeginContext(2391, 135, true);
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-success btn-sm float-left\">Download Flyer</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 65 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Event\Events.cshtml"
AddHtmlAttributeValue("", 2273, Url.Action("Download", "Event"), 2273, 32, false);

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
            BeginContext(2533, 585, true);
            WriteLiteral(@"

                </div>
            </div>

            <!-- Modal footer -->
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" onclick=""RegisterEvent()"">Register</button>
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
            </div>

        </div>
    </div>
</div>

<script>
    function RegisterEvent() {
        //var dataRow = {
        //    'id': EventID,
        //    'NewEventStart': EventStart,
        //    'NewEventEnd': EventEnd
        //}
");
            EndContext();
            BeginContext(3488, 770, true);
            WriteLiteral(@"
        //$.ajax({
        //    type: ""POST"",
        //    url: url,
        //    data: EventID,
        //    cache: false,
        //    dataType: 'json',
        //    success: function (result) {
        //        if (result == '200') {
        //            alert('successfuly inserted');
        //        }
        //        else {
        //            alert('some error occured');
        //        }
        //    }
        //});

        //$.ajax({
        //    url: '/Event/ViewEvent/' + EventID,
        //}).done(function () {

        //});
        var eId = sessionStorage.getItem('e_id');
        console.log(""ssid"", eId);
        $.ajax({
            type: ""POST"",
            url: 'viewEvent/'+eId,
            //url: '");
            EndContext();
            BeginContext(4259, 23, false);
#line 130 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\Event\Events.cshtml"
               Write(Url.Action("ViewEvent"));

#line default
#line hidden
            EndContext();
            BeginContext(4282, 337, true);
            WriteLiteral(@"',
            dataType: ""json"",
            contentType: ""application/json; charset=utf-8"",
            success: function (data) {
                alert(data);
            },
            failure: function (errMsg) {
                alert(errMsg);
            }
        }).done(function () {

        });
    }
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Download> Html { get; private set; }
    }
}
#pragma warning restore 1591

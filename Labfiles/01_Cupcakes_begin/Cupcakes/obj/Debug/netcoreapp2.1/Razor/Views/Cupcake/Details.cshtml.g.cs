#pragma checksum "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7535a64f29a3c3c30d9b236266bf1c8e5e71f50a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cupcake_Details), @"mvc.1.0.view", @"/Views/Cupcake/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cupcake/Details.cshtml", typeof(AspNetCore.Views_Cupcake_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7535a64f29a3c3c30d9b236266bf1c8e5e71f50a", @"/Views/Cupcake/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Cupcake_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cupcakes.Models.Cupcake>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cupcakes-styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(56, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(81, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a73ac623d0754136a062b1b47bff61b8", async() => {
                BeginContext(87, 90, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Details</title>\n    ");
                EndContext();
                BeginContext(177, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1f4ce7938e6149138bb2f81a209f472f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(251, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(259, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(260, 1779, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bb37b19fc1d44beb8cef52b78613158", async() => {
                BeginContext(266, 140, true);
                WriteLiteral("\n    <div class=\"container\">\n        <div class=\"photo-index-card-details\">\n            <h3 class=\"display-picture-title\">\n                \"");
                EndContext();
                BeginContext(407, 51, false);
#line 19 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
            Write(Html.DisplayFor(modelItem => modelItem.CupcakeType));

#line default
#line hidden
                EndContext();
                BeginContext(458, 20, true);
                WriteLiteral("\"\n            </h3>\n");
                EndContext();
#line 21 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
             if (Model.ImageName != null)
            {

#line default
#line hidden
                BeginContext(534, 78, true);
                WriteLiteral("        <div class=\"photo-display\">\n            <img class=\"photo-display-img\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 612, "\"", 682, 1);
#line 24 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
WriteAttributeValue("", 618, Url.Action("GetImage", "Cupcake", new { Id = Model.CupcakeId }), 618, 64, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(683, 30, true);
                WriteLiteral(" />\n        </div>            ");
                EndContext();
#line 25 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
                          }

#line default
#line hidden
                BeginContext(715, 80, true);
                WriteLiteral("            <div>\n                <p class=\"display-label\">\n                    ");
                EndContext();
                BeginContext(796, 47, false);
#line 28 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(843, 107, true);
                WriteLiteral("\n                </p>\n                <br />\n                <p class=\"display-field\">\n                    ");
                EndContext();
                BeginContext(951, 43, false);
#line 32 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(994, 121, true);
                WriteLiteral("\n                </p>\n            </div>\n            <div>\n                <p class=\"display-label\">\n                    ");
                EndContext();
                BeginContext(1116, 46, false);
#line 37 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.GlutenFree));

#line default
#line hidden
                EndContext();
                BeginContext(1162, 84, true);
                WriteLiteral("\n                </p>\n                <p class=\"display-field\">\n                    ");
                EndContext();
                BeginContext(1247, 42, false);
#line 40 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
               Write(Html.DisplayFor(model => model.GlutenFree));

#line default
#line hidden
                EndContext();
                BeginContext(1289, 121, true);
                WriteLiteral("\n                </p>\n            </div>\n            <div>\n                <p class=\"display-label\">\n                    ");
                EndContext();
                BeginContext(1411, 41, false);
#line 45 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1452, 84, true);
                WriteLiteral("\n                </p>\n                <p class=\"display-field\">\n                    ");
                EndContext();
                BeginContext(1537, 37, false);
#line 48 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1574, 121, true);
                WriteLiteral("\n                </p>\n            </div>\n            <div>\n                <p class=\"display-label\">\n                    ");
                EndContext();
                BeginContext(1696, 48, false);
#line 53 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.CaloricValue));

#line default
#line hidden
                EndContext();
                BeginContext(1744, 84, true);
                WriteLiteral("\n                </p>\n                <p class=\"display-field\">\n                    ");
                EndContext();
                BeginContext(1829, 44, false);
#line 56 "C:\Curso\20486\Luismi\LabFiles\Mod07\Labfiles\01_Cupcakes_begin\Cupcakes\Views\Cupcake\Details.cshtml"
               Write(Html.DisplayFor(model => model.CaloricValue));

#line default
#line hidden
                EndContext();
                BeginContext(1873, 75, true);
                WriteLiteral("\n                </p>\n            </div>\n            <div>\n                ");
                EndContext();
                BeginContext(1948, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91889736ffaa43e9bab53d209b2fc7dc", async() => {
                    BeginContext(1970, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1986, 46, true);
                WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2039, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cupcakes.Models.Cupcake> Html { get; private set; }
    }
}
#pragma warning restore 1591

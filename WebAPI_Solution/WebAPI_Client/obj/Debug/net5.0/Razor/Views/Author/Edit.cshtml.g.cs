#pragma checksum "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Author\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "457848ecc32230b544c8c71de46433ab1a5d62c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Edit), @"mvc.1.0.view", @"/Views/Author/Edit.cshtml")]
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
#line 1 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\_ViewImports.cshtml"
using WebAPI_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\_ViewImports.cshtml"
using WebAPI_Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457848ecc32230b544c8c71de46433ab1a5d62c1", @"/Views/Author/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a83f356341a82309f71864c757f7c47bbc0d5a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Author_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAPI_Client.Controllers.AuthorController.AuthorAndPositions>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Author", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Author\Edit.cshtml"
  
    ViewData["Title"] = "AuthorEdit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ИЗМЕНИТЬ АВТОРА</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "457848ecc32230b544c8c71de46433ab1a5d62c14839", async() => {
                WriteLiteral(@"
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td>Фамилия</td>
                <td>Имя</td>
                <td>Отчество</td>
                <td>Должность</td>
                <td>Ученая степень</td>
                <td></td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td style=""user-select:none; text-align:left; min-width:150px"">
                    <input");
                BeginWriteAttribute("value", " value=\"", 710, "\"", 742, 1);
#nullable restore
#line 24 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Author\Edit.cshtml"
WriteAttributeValue("", 718, Model.Author.SecondName, 718, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"SecondName\" name=\"Author.SecondName\" type=\"text\" />\r\n                </td>\r\n                <td style=\"user-select:none; text-align:left; min-width:150px\">\r\n                    <input");
                BeginWriteAttribute("value", " value=\"", 940, "\"", 971, 1);
#nullable restore
#line 27 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Author\Edit.cshtml"
WriteAttributeValue("", 948, Model.Author.FirstName, 948, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"FirstName\" name=\"Author.FirstName\" type=\"text\" />\r\n                </td>\r\n                <td style=\"user-select:none; text-align:left; min-width:150px\">\r\n                    <input");
                BeginWriteAttribute("value", " value=\"", 1167, "\"", 1198, 1);
#nullable restore
#line 30 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Author\Edit.cshtml"
WriteAttributeValue("", 1175, Model.Author.ThirdName, 1175, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"ThirdName\" name=\"Author.ThirdName\" type=\"text\" />\r\n                </td>\r\n                <td style=\"user-select:none; text-align:left; min-width:160px\">\r\n                    ");
#nullable restore
#line 33 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Author\Edit.cshtml"
               Write(Html.DropDownListFor(x => x.Author.PositionId, Model.Positions));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td style=\"user-select:none; text-align:left; min-width:160px\">\r\n                    ");
#nullable restore
#line 36 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Author\Edit.cshtml"
               Write(Html.DropDownListFor(x => x.Author.AcademicDegree, new SelectList(Enum.GetNames<DiplomsClassLibrary.Models.AcademicDegree>(), Model.Author.AcademicDegree)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td style=\"user-select:none; \">\r\n                    <input class=\"commit-button\" type=\"submit\" value=\"Подтвердить\" />\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Author.Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Author\Edit.cshtml"
                                                         WriteLiteral(Model.Author.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Author.Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Author.Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Author.Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "457848ecc32230b544c8c71de46433ab1a5d62c111086", async() => {
                WriteLiteral("\r\n    <input class=\"delete-button d-inline\" type=\"submit\" value=\"Удалить\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Author\Edit.cshtml"
                                                    WriteLiteral(Model.Author.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAPI_Client.Controllers.AuthorController.AuthorAndPositions> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Diplom\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e434c312a60fe952833405057e796606214669f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diplom_Edit), @"mvc.1.0.view", @"/Views/Diplom/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e434c312a60fe952833405057e796606214669f", @"/Views/Diplom/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a83f356341a82309f71864c757f7c47bbc0d5a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Diplom_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAPI_Client.Controllers.DiplomController.Diplom_Authors_Directions>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Diplom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Diplom\Edit.cshtml"
  
    ViewData["Title"] = "DiplomEdit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ИЗМЕНИТЬ ДИПЛОМ</h1>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e434c312a60fe952833405057e796606214669f4850", async() => {
                WriteLiteral(@"
   
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td>Тема работы</td>
                <td>Руководитель</td>
                <td>Год публикации</td>
                <td>Степень работы</td>
                <td>Автор</td>
                <td>Направление</td>
                <td></td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td style=""user-select:none; text-align:left; min-width:150px"">
                    <input type=""text"" placeholder=""Title"" name=""Diplom.Title""");
                BeginWriteAttribute("value", " value=\"", 829, "\"", 856, 1);
#nullable restore
#line 27 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Diplom\Edit.cshtml"
WriteAttributeValue("", 837, Model.Diplom.Title, 837, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n                <td style=\"user-select:none; text-align:left; min-width:150px\">\r\n                    <input type=\"text\" placeholder=\"HeadName\" name=\"Diplom.HeadName\"");
                BeginWriteAttribute("value", " value=\"", 1050, "\"", 1080, 1);
#nullable restore
#line 30 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Diplom\Edit.cshtml"
WriteAttributeValue("", 1058, Model.Diplom.HeadName, 1058, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n                <td style=\"user-select:none; text-align:left; min-width:150px\">\r\n                    ");
#nullable restore
#line 33 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Diplom\Edit.cshtml"
               Write(Html.EditorFor(x => x.Diplom.Release));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td style=\"user-select:none; text-align:left; min-width:160px\">\r\n                    ");
#nullable restore
#line 36 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Diplom\Edit.cshtml"
               Write(Html.DropDownListFor(x => x.Diplom.AcademicDegree, new SelectList(Enum.GetNames<DiplomsClassLibrary.Models.AcademicDegree>(), Model.Diplom.AcademicDegree)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td style=\"user-select:none; text-align:left; min-width:160px\">\r\n                    ");
#nullable restore
#line 39 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Diplom\Edit.cshtml"
               Write(Html.DropDownListFor(x => x.Diplom.AuthorId, Model.Authors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td style=\"user-select:none; text-align:left; min-width:160px\">\r\n                    ");
#nullable restore
#line 42 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Diplom\Edit.cshtml"
               Write(Html.DropDownListFor(x => x.Diplom.DirectionId, Model.Directions));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td tyle=\"user-select:none;\">\r\n                    <input class=\"commit-button\" type=\"submit\" value=\"Подтвердить\" />\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Diplom.Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Diplom\Edit.cshtml"
                                                         WriteLiteral(Model.Diplom.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Diplom.Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Diplom.Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Diplom.Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e434c312a60fe952833405057e796606214669f11354", async() => {
                WriteLiteral("\r\n    <input class=\"delete-button\" type=\"submit\" value=\"Удалить\" />\r\n");
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
#line 52 "E:\Мага\Гурин\WebAPI\WebAPI_Str_Dem\WebAPI_Solution\WebAPI_Client\Views\Diplom\Edit.cshtml"
                                                    WriteLiteral(Model.Diplom.Id);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAPI_Client.Controllers.DiplomController.Diplom_Authors_Directions> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55e7848a8566ea6c2422ec7059f6e42b3d82b597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portrait_Details), @"mvc.1.0.view", @"/Views/Portrait/Details.cshtml")]
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
#line 1 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\_ViewImports.cshtml"
using Web_CRM_Monuments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\_ViewImports.cshtml"
using Web_CRM_Monuments.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\_ViewImports.cshtml"
using DataLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\_ViewImports.cshtml"
using DataLayer.ApplicationEntities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e7848a8566ea6c2422ec7059f6e42b3d82b597", @"/Views/Portrait/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934e7ca0af94def58485c3824f00829c927a85b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Portrait_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PortraitViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Portrait", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleateOn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-box"">
    <h1>Сведения</h1>

    <table class=""table table-hover table-bordered"">
        <thead></thead>
        <tbody>
            <tr>
                <td>
                    Номер договора:
                </td>
                <td>
                    ");
#nullable restore
#line 18 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
               Write(Model.ContractNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Дата заключения договора:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 26 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
               Write(Model.DateConclusionContract.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Фамилия усопшего:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 34 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
               Write(Model.LastNameDeceased);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Тип портрета:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 42 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
               Write(Model.Portrait.TypePortraitName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Художник:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 50 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
               Write(Model.Portrait.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Имя заказчика:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 58 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
               Write(Model.NameCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Телефон заказчика:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 66 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
               Write(Model.PhoneCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Фотография:\n                </td>\n                <td>\n");
#nullable restore
#line 74 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
                     if (Model.Portrait.PhotoName != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 1867, "\"", 1899, 1);
#nullable restore
#line 76 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
WriteAttributeValue("", 1874, Model.Portrait.PhotoPath, 1874, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("download", " download=\"", 1900, "\"", 1936, 1);
#nullable restore
#line 76 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
WriteAttributeValue("", 1911, Model.Portrait.PhotoName, 1911, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                           class=\"download-btn full\">\n                            <input type=\"button\" class=\"full\" value=\"Скачать\" />\n                        </a>\n");
#nullable restore
#line 80 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>Ожидается фото от заказчика...</label>\n");
#nullable restore
#line 84 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            </tr>\n            <tr>\n                <td>\n                    Примечание:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 92 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
               Write(Model.Portrait.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n        </tbody>\n    </table>\n\n");
#nullable restore
#line 98 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
     if (Model.Portrait.DateCompleat < new DateTime(2000, 01, 01))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55e7848a8566ea6c2422ec7059f6e42b3d82b59711261", async() => {
                WriteLiteral("\n            <button type=\"submit\" class=\"btn btn-primary\">Выполнено</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idPortrait", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
                        WriteLiteral(Model.Portrait.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idPortrait"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idPortrait", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idPortrait"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
                                                            WriteLiteral(DateTime.Today.ToShortDateString().ToString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["date"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-date", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["date"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 105 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>Портрет выполнен ");
#nullable restore
#line 108 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
                        Write(Model.Portrait.DateCompleat.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n");
#nullable restore
#line 109 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n</div>\n\n\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortraitViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

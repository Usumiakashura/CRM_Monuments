#pragma checksum "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32755e4695914a2ea67935111a56848dfc8a841e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medallion_Details), @"mvc.1.0.view", @"/Views/Medallion/Details.cshtml")]
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
using BuissnesLayer.Models;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32755e4695914a2ea67935111a56848dfc8a841e", @"/Views/Medallion/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66a0d0fde5a09ad7f405f3b005ef63d81f1ae61", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Medallion_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedallionViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Medallion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
  
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
#line 18 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
               Write(Model.ContractNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Дата заключения договора:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
               Write(Model.DateConclusionContract.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ФИО усопшего:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
               Write(Model.LastNameDeceased);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                                       Write(Model.FirstNameDeceased);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                                                                Write(Model.MiddleNameDeceased);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Имя заказчика:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
               Write(Model.NameCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Телефон заказчика:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
               Write(Model.PhoneCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Материал:\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 58 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                     if (Model.Medallion.MedallionMaterialObj != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>");
#nullable restore
#line 60 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                          Write(Model.Medallion.MedallionMaterialObj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 61 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n");
#nullable restore
#line 64 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                 if (Model.Medallion.Frame)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        Тип рамки:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                   Write(Model.Medallion.TypeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 72 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Размер:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
               Write(Model.Medallion.SizeMedallion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n");
#nullable restore
#line 83 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                 if (Model.Medallion.Frame)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        Размер рамки:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 89 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                   Write(Model.Medallion.SizeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 91 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n            <tr>\r\n                <td>\r\n                    Форма:\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 98 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                     if (Model.Medallion.ShapeMedallionObj != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>");
#nullable restore
#line 100 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                          Write(Model.Medallion.ShapeMedallionObj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 101 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n");
#nullable restore
#line 104 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                 if (Model.Medallion.Frame)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        Форма рамки:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 110 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                   Write(Model.Medallion.ShapeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 112 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n            <tr>\r\n                <td>\r\n                    Цветность:\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 119 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                     if (Model.Medallion.ColorMedallionObj != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>");
#nullable restore
#line 121 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                          Write(Model.Medallion.ColorMedallionObj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 122 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                </td>\r\n\r\n");
#nullable restore
#line 126 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                 if (Model.Medallion.Frame)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        Цвет рамки:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 132 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                   Write(Model.Medallion.ColorFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 134 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n            <tr>\r\n                <td>\r\n                    Фон:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 141 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
               Write(Model.Medallion.BackgroundMedallion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n");
#nullable restore
#line 144 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                 if (Model.Medallion.Frame)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        Вклейка в нишу:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 150 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                   Write(Model.Medallion.GluingIntoNiche);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 152 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n\r\n\r\n\r\n            <tr>\r\n                <td>\r\n                    Фотография:\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 162 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                     if (Model.Medallion.PhotoName != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 4503, "\"", 4536, 1);
#nullable restore
#line 164 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
WriteAttributeValue("", 4510, Model.Medallion.PhotoPath, 4510, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("download", " download=\"", 4537, "\"", 4574, 1);
#nullable restore
#line 164 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
WriteAttributeValue("", 4548, Model.Medallion.PhotoName, 4548, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                           class=\"download-btn full\">\r\n                            <input type=\"button\" class=\"full\" value=\"Скачать\" />\r\n                        </a>\r\n");
#nullable restore
#line 168 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>Ожидается фото от заказчика...</label>\r\n");
#nullable restore
#line 172 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Примечание к медальону:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 180 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
               Write(Model.Medallion.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n");
#nullable restore
#line 183 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                 if (Model.Medallion.Frame)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        Примечание к рамке:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 189 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                   Write(Model.Medallion.NoteFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n");
#nullable restore
#line 192 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n");
#nullable restore
#line 197 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
     if (Model.Medallion.PhotoName != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 199 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
         if (Model.Medallion.DateCompleat < new DateTime(2000, 01, 01))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32755e4695914a2ea67935111a56848dfc8a841e21331", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Выполнено</button>\r\n                ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idMedallion", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 202 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                                 WriteLiteral(Model.Medallion.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idMedallion"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idMedallion", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idMedallion"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 202 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
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
            WriteLiteral("\r\n");
#nullable restore
#line 206 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5>Медальон выполнен ");
#nullable restore
#line 209 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
                                 Write(Model.Medallion.DateCompleat.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 210 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 210 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
         
     }
     else
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5>Ожидается фото от заказчика</h5>\r\n");
#nullable restore
#line 215 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Medallion\Details.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedallionViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

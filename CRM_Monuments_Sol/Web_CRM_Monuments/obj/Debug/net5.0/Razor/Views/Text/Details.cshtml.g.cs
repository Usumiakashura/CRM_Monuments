#pragma checksum "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "212c3d2bb4663065159cfb25b3257cf228af8fe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Text_Details), @"mvc.1.0.view", @"/Views/Text/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"212c3d2bb4663065159cfb25b3257cf228af8fe2", @"/Views/Text/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934e7ca0af94def58485c3824f00829c927a85b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Text_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
  
    ViewData["Title"] = "Details";
    string nameText;
    if (Model.TextEpitaph)
        nameText = "(эпитафия)";
    else
        nameText = "(текст ФИО и даты)";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"content-box\">\n    <h1>Сведения ");
#nullable restore
#line 13 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
            Write(nameText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n    <table class=\"table table-hover table-bordered\">\n        <thead></thead>\n        <tbody>\n            <tr>\n                <td>\n                    Номер договора:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 23 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
               Write(Model.ContractNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Дата заключения договора:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 31 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
               Write(Model.DateConclusionContract.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Фамилия усопшего:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 39 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
               Write(Model.LastNameDeceased);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Имя заказчика:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 47 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
               Write(Model.NameCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    Телефон заказчика:\n                </td>\n                <td>\n                    ");
#nullable restore
#line 55 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
               Write(Model.PhoneCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n\n");
#nullable restore
#line 59 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
             if (Model.TextEpitaph)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        Текст эпитафии:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 66 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.NotesTextEpitaph);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n                <tr>\n                    <td>\n                        Тип текста:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 74 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.TypeNameEpitaph);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n                <tr>\n                    <td>\n                        Гравер:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 82 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.EngraverEpitaph);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 85 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ФИО усопшего:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 93 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 93 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                                             Write(Model.Deceased.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 93 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                                                                      Write(Model.Deceased.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n                <tr>\n                    <td>\n                        Дата рождения:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 101 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.DateBirthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n                <tr>\n                    <td>\n                        Дата смерти:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 109 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.DateRip);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n                <tr>\n                    <td>\n                        Тип текста:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 117 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.TypeNameText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n                <tr>\n                    <td>\n                        Гравер:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 125 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.EngraverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n                <tr>\n                    <td>\n                        Примечание:\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 133 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.NotesTextName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 136 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n\n");
#nullable restore
#line 141 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
      
        DateTime dateBegin, dateCompleate;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
     if (Model.TextEpitaph)
    {
        dateBegin = Model.Deceased.DateBeginTextEpitaph;
        dateCompleate = Model.Deceased.DateCompleatTextEpitaph;
    }
    else
    {
        dateBegin = Model.Deceased.DateBeginTextName;
        dateCompleate = Model.Deceased.DateCompleatTextName;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 155 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
     if (dateCompleate < new DateTime(2000, 01, 01))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "212c3d2bb4663065159cfb25b3257cf228af8fe214609", async() => {
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idDeceaced", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                        WriteLiteral(Model.Deceased.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idDeceaced"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idDeceaced", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idDeceaced"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                                                               WriteLiteral(Model.TextEpitaph);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["epitaph"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-epitaph", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["epitaph"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
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
#line 162 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>Текст выполнен ");
#nullable restore
#line 165 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                      Write(dateCompleate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n");
#nullable restore
#line 166 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
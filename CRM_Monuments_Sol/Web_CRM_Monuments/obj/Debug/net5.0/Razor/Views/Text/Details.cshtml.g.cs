#pragma checksum "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "216f55ede7c02dbadda35228fefd80738e2584cb"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"216f55ede7c02dbadda35228fefd80738e2584cb", @"/Views/Text/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66a0d0fde5a09ad7f405f3b005ef63d81f1ae61", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Text_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextViewModel>
    #nullable disable
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
            WriteLiteral("\r\n");
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
            WriteLiteral("\r\n<div class=\"content-box\">\r\n    <h1>Сведения ");
#nullable restore
#line 13 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
            Write(nameText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <table class=\"table table-hover table-bordered\">\r\n        <thead></thead>\r\n        <tbody>\r\n            <tr>\r\n                <td>\r\n                    Номер договора:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
               Write(Model.ContractNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Дата заключения договора:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
               Write(Model.DateConclusionContract.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ФИО усопшего:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
               Write(Model.Deceased.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                                        Write(Model.Deceased.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                                                                  Write(Model.Deceased.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Имя заказчика:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
               Write(Model.NameCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Телефон заказчика:\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
               Write(Model.PhoneCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 59 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
             if (Model.TextEpitaph)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        Текст эпитафии:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.Epitaph.NotesTextEpitaph);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Тип текста:\r\n                    </td>\r\n                    <td>\r\n                        \r\n");
#nullable restore
#line 75 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                         if(Model.Deceased.Epitaph.TypeTextObj != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 77 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                              Write(Model.Deceased.Epitaph.TypeTextObj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 78 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Гравер:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 86 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.Epitaph.EngraverEpitaph);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 89 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ФИО усопшего:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 97 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 97 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                                             Write(Model.Deceased.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 97 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                                                                      Write(Model.Deceased.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Дата рождения:\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 105 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                         if (Model.Deceased.DateBirthday > new DateTime(1000, 01, 01)) Model.Deceased.DateBirthday.ToShortDateString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Дата смерти:\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 113 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                         if (Model.Deceased.DateRip > new DateTime(1000, 01, 01)) Model.Deceased.DateRip.ToShortDateString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Тип текста:\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 121 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                         if (Model.Deceased.TypeTextObj != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 123 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                              Write(Model.Deceased.TypeTextObj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 124 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Гравер:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 132 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.EngraverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Примечание:\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 140 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                   Write(Model.Deceased.NotesTextName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 143 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n");
#nullable restore
#line 148 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
      
        DateTime dateBegin, dateCompleate;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
     if (Model.TextEpitaph)
    {
        dateBegin = Model.Deceased.Epitaph.DateBeginTextEpitaph;
        dateCompleate = Model.Deceased.Epitaph.DateCompleatTextEpitaph;
    }
    else
    {
        dateBegin = Model.Deceased.DateBeginTextName;
        dateCompleate = Model.Deceased.DateCompleatTextName;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
     if (dateBegin > new DateTime(2000, 01, 01))
     {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
         if (dateCompleate < new DateTime(2000, 01, 01))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "216f55ede7c02dbadda35228fefd80738e2584cb17045", async() => {
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-primary\">Выполнено</button>\r\n            ");
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
#line 166 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                            WriteLiteral(Model.Deceased.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idDeceaced"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idDeceaced", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idDeceaced"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 166 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                                                                   WriteLiteral(Model.TextEpitaph);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["epitaph"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-epitaph", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["epitaph"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 166 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
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
#line 170 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5>Текст выполнен ");
#nullable restore
#line 173 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
                          Write(dateCompleate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 174 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
         
     }
     else
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>Текст ожидает отправки на выполнение</h5>\r\n");
#nullable restore
#line 179 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\Details.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

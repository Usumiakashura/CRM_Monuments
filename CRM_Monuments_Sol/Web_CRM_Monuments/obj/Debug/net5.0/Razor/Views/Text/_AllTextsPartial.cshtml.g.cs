#pragma checksum "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9a54eeb30ffc57d14b566b6223f4770c45fd0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Text__AllTextsPartial), @"mvc.1.0.view", @"/Views/Text/_AllTextsPartial.cshtml")]
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
#line 1 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\_ViewImports.cshtml"
using Web_CRM_Monuments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\_ViewImports.cshtml"
using BuissnesLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\_ViewImports.cshtml"
using DataLayer.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba9a54eeb30ffc57d14b566b6223f4770c45fd0c", @"/Views/Text/_AllTextsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"923dbf204cefbc48cb6b87b63a07fc7697a6240d", @"/Views/_ViewImports.cshtml")]
    public class Views_Text__AllTextsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TextViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h4>Текста</h4>

<table class=""table table-hover table-bordered results full"">
    <thead>
        <tr>
            <th>№ дог-ра</th>
            <th>
                Заключен
            </th>
            <th>
                Усопший
            </th>
            <th>
                Вид
            </th>
            <th>
                Тип текста
            </th>
            <th>
                Заказчик
            </th>
            <th>
                Телефон
            </th>
            <th>
                Исполнитель
            </th>
            <th>
                Статус
            </th>

        </tr>
        <tr class=""warning no-result"">
            <td colspan=""4""><i class=""fa fa-warning""></i> Совпадения не найдены</td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 40 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
         for (int i = Model.Count() - 1; i >= 0; i--)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 932, "\"", 1034, 5);
            WriteAttributeValue("", 942, "location.href=\'/Text/Details?idDeceaced=", 942, 40, true);
#nullable restore
#line 42 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
WriteAttributeValue("", 982, Model[i].Deceased.Id, 982, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1003, "&epitaph=", 1003, 9, true);
#nullable restore
#line 42 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
WriteAttributeValue("", 1012, Model[i].TextEpitaph, 1012, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1033, "\'", 1033, 1, true);
            EndWriteAttribute();
            WriteLiteral("\r\n            class=\"table-stroke\">\r\n            <td class=\"font-weight-bold\">\r\n                ");
#nullable restore
#line 45 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
           Write(Model[i].ContractNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
           Write(Model[i].DateConclusionContract.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
           Write(Model[i].Deceased.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 54 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                 if (Model[i].TextEpitaph)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>эпитафия</label>\r\n");
#nullable restore
#line 57 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>фио, даты</label>\r\n");
#nullable restore
#line 61 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 64 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                 if (Model[i].TextEpitaph)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                     if(Model[i].Deceased.Epitaph.TypeTextObj != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>");
#nullable restore
#line 68 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                          Write(Model[i].Deceased.Epitaph.TypeTextObj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 69 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                     
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                     if (Model[i].Deceased.TypeTextObj != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 75 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                              Write(Model[i].Deceased.TypeTextObj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 76 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                          
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
           Write(Model[i].NameCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
           Write(Model[i].PhoneCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 86 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                 if (Model[i].TextEpitaph)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>");
#nullable restore
#line 88 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                      Write(Model[i].Deceased.Epitaph.EngraverEpitaph);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 89 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>");
#nullable restore
#line 92 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                      Write(Model[i].Deceased.EngraverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 93 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n");
#nullable restore
#line 95 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
              
                DateTime dateCompl, dateBegin;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                 if (Model[i].TextEpitaph)
                {
                    dateCompl = Model[i].Deceased.Epitaph.DateCompleatTextEpitaph;
                    dateBegin = Model[i].Deceased.Epitaph.DateBeginTextEpitaph;
                }

                else
                {
                    dateCompl = Model[i].Deceased.DateCompleatTextName;
                    dateBegin = Model[i].Deceased.DateBeginTextName;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 112 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
             if (dateCompl > new DateTime(2000, 01, 01))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <label>Завершен ");
#nullable restore
#line 115 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                               Write(dateCompl.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n");
#nullable restore
#line 117 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
            }
            else if (dateBegin > new DateTime(2000, 01, 01))
            {
                TimeSpan time = dateBegin.AddDays(15) - DateTime.Today;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                 if (dateBegin.AddDays(12) > DateTime.Today)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"status-green\">\r\n                        <label>В процессе (ост. ");
#nullable restore
#line 124 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                                            Write(time.Days + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" дн.)</label>\r\n                    </td>\r\n");
#nullable restore
#line 126 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }
                else if (dateBegin.AddDays(15) >= DateTime.Today)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"status-orange\">\r\n                        <label>В процессе (ост. ");
#nullable restore
#line 130 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                                            Write(time.Days + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" дн.)</label>\r\n                    </td>\r\n");
#nullable restore
#line 132 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"status-red\">\r\n                        <label>Просрочка ");
#nullable restore
#line 136 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                                    Write(time.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" дн.</label>\r\n                    </td>\r\n");
#nullable restore
#line 138 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"status-blue\">\r\n                    <label>В ожидании</label>\r\n                </td>\r\n");
#nullable restore
#line 146 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 157 "E:\Projects\CRM_Monuments\CRM_Monuments\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TextViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

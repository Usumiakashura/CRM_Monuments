#pragma checksum "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4098abeb69cd5afd8ff6412297d51303a3ab3c09"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4098abeb69cd5afd8ff6412297d51303a3ab3c09", @"/Views/Text/_AllTextsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934e7ca0af94def58485c3824f00829c927a85b0", @"/Views/_ViewImports.cshtml")]
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
                Дата заключ-я
            </th>
            <th>
                Усопший
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
#line 37 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
         for (int i = Model.Count() - 1; i >= 0; i--)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 841, "\"", 943, 5);
            WriteAttributeValue("", 851, "location.href=\'/Text/Details?idDeceaced=", 851, 40, true);
#nullable restore
#line 39 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
WriteAttributeValue("", 891, Model[i].Deceased.Id, 891, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 912, "&epitaph=", 912, 9, true);
#nullable restore
#line 39 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
WriteAttributeValue("", 921, Model[i].TextEpitaph, 921, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 942, "\'", 942, 1, true);
            EndWriteAttribute();
            WriteLiteral("\n            class=\"table-stroke\">\n            <td class=\"font-weight-bold\">\n                ");
#nullable restore
#line 42 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
           Write(Model[i].ContractNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 45 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
           Write(Model[i].DateConclusionContract.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 48 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
           Write(Model[i].Deceased.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n            </td>\n            <td>\n");
#nullable restore
#line 51 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                 if (Model[i].TextEpitaph)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                     if(Model[i].Deceased.Epitaph.TypeTextObj != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>");
#nullable restore
#line 55 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                          Write(Model[i].Deceased.Epitaph.TypeTextObj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 56 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                     
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                     if (Model[i].Deceased.TypeTextObj != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 62 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                              Write(Model[i].Deceased.TypeTextObj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 63 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                          
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n                ");
#nullable restore
#line 67 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
           Write(Model[i].NameCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 70 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
           Write(Model[i].PhoneCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 73 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                 if (Model[i].TextEpitaph)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>");
#nullable restore
#line 75 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                      Write(Model[i].Deceased.Epitaph.EngraverEpitaph);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n");
#nullable restore
#line 76 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>");
#nullable restore
#line 79 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                      Write(Model[i].Deceased.EngraverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n");
#nullable restore
#line 80 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n");
#nullable restore
#line 82 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
              
                DateTime dateCompl, dateBegin;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
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
            WriteLiteral("\n\n");
#nullable restore
#line 99 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
             if (dateCompl > new DateTime(2000, 01, 01))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\n                    <label>Завершен ");
#nullable restore
#line 102 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                               Write(dateCompl.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </td>\n");
#nullable restore
#line 104 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
            }
            else if (dateBegin > new DateTime(2000, 01, 01))
            {
                TimeSpan time = dateBegin.AddDays(15) - DateTime.Today;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                 if (dateBegin.AddDays(12) > DateTime.Today)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"status-green\">\n                        <label>В процессе (ост. ");
#nullable restore
#line 111 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                                            Write(time.Days + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" дн.)</label>\n                    </td>\n");
#nullable restore
#line 113 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }
                else if (dateBegin.AddDays(15) >= DateTime.Today)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"status-orange\">\n                        <label>В процессе (ост. ");
#nullable restore
#line 117 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                                            Write(time.Days + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" дн.)</label>\n                    </td>\n");
#nullable restore
#line 119 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"status-red\">\n                        <label>Просрочка ");
#nullable restore
#line 123 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                                    Write(time.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" дн.</label>\n                    </td>\n");
#nullable restore
#line 125 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"status-blue\">\n                    <label>В ожидании</label>\n                </td>\n");
#nullable restore
#line 133 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("        </tr>\n");
#nullable restore
#line 144 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Text\_AllTextsPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("    </tbody>\n</table>");
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

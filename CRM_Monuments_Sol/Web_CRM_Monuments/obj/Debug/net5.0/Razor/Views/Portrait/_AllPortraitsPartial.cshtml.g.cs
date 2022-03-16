#pragma checksum "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114c086f2317057f66f1ff158eb1a56aef4ec880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portrait__AllPortraitsPartial), @"mvc.1.0.view", @"/Views/Portrait/_AllPortraitsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114c086f2317057f66f1ff158eb1a56aef4ec880", @"/Views/Portrait/_AllPortraitsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934e7ca0af94def58485c3824f00829c927a85b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Portrait__AllPortraitsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PortraitViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h4>Портреты</h4>

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
                Тип портрета
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
#line 37 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
         for (int i = Model.Count() - 1; i >= 0; i--)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 849, "\"", 925, 3);
            WriteAttributeValue("", 859, "location.href=\'/Portrait/Details?idPortrait=", 859, 44, true);
#nullable restore
#line 39 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
WriteAttributeValue("", 903, Model[i].Portrait.Id, 903, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 924, "\'", 924, 1, true);
            EndWriteAttribute();
            WriteLiteral("\n            class=\"table-stroke\">\n            <td class=\"font-weight-bold\">\n                ");
#nullable restore
#line 42 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
           Write(Model[i].ContractNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 45 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
           Write(Model[i].DateConclusionContract.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 48 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
           Write(Model[i].LastNameDeceased);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 51 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                 if (Model[i].Portrait.TypePortrait != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>");
#nullable restore
#line 53 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                      Write(Model[i].Portrait.TypePortrait.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n");
#nullable restore
#line 54 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n                ");
#nullable restore
#line 57 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
           Write(Model[i].NameCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 60 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
           Write(Model[i].PhoneCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 63 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
           Write(Model[i].Portrait.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n");
#nullable restore
#line 65 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
             if (Model[i].Portrait.DateCompleat > new DateTime(2000, 01, 01))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\n                    <label>Завершен ");
#nullable restore
#line 68 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                               Write(Model[i].Portrait.DateCompleat.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </td>\n");
#nullable restore
#line 70 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
            }
            else if (Model[i].Portrait.DateBegin > new DateTime(2000, 01, 01))
            {
                TimeSpan time = Model[i].Portrait.DateBegin.AddDays(15) - DateTime.Today;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                 if (Model[i].Portrait.DateBegin.AddDays(12) > DateTime.Today)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"status-green\">\n                        <label>В процессе (ост. ");
#nullable restore
#line 77 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                                            Write(time.Days + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" дн.)</label>\n                    </td>\n");
#nullable restore
#line 79 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                }
                else if (Model[i].Portrait.DateBegin.AddDays(15) >= DateTime.Today)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"status-orange\">\n                        <label>В процессе (ост. ");
#nullable restore
#line 83 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                                            Write(time.Days + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" дн.)</label>\n                    </td>\n");
#nullable restore
#line 85 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"status-red\">\n                        <label>Просрочка ");
#nullable restore
#line 89 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                                    Write(time.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" дн.</label>\n                    </td>\n");
#nullable restore
#line 91 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"status-blue\">\n                    <label>В ожидании</label>\n                </td>\n");
#nullable restore
#line 99 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("        </tr>\n");
#nullable restore
#line 110 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Portrait\_AllPortraitsPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PortraitViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

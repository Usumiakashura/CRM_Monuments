#pragma checksum "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Setting\AllTypePortraits.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21395c05ec362607b576554efaccb700598c3c84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setting_AllTypePortraits), @"mvc.1.0.view", @"/Views/Setting/AllTypePortraits.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21395c05ec362607b576554efaccb700598c3c84", @"/Views/Setting/AllTypePortraits.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934e7ca0af94def58485c3824f00829c927a85b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Setting_AllTypePortraits : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TypePortraitViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/add.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("s-add-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control float-md-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/remove.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("s-remove-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllTypePortraits", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"center content-box-min\">\r\n    <h4 class=\"float-md-left\">Типы портретов</h4>\r\n    <a class=\"add-btn my-btn float-md-right\" title=\"Добавить\" id=\"Add\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21395c05ec362607b576554efaccb700598c3c846694", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </a>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21395c05ec362607b576554efaccb700598c3c847823", async() => {
                WriteLiteral("\r\n        <table class=\"table full\">\r\n            <thead>\r\n                <tr>\r\n                    <th>Название:</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody id=\"body\">\r\n");
#nullable restore
#line 16 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Setting\AllTypePortraits.cshtml"
                 for (int i = 0; i < Model.Count(); i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr");
                BeginWriteAttribute("id", " id=", 635, "", 657, 1);
#nullable restore
#line 18 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Setting\AllTypePortraits.cshtml"
WriteAttributeValue("", 639, $"container{i}", 639, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <td>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21395c05ec362607b576554efaccb700598c3c849074", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 20 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Setting\AllTypePortraits.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].TypePortrait.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
#nullable restore
#line 21 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Setting\AllTypePortraits.cshtml"
                       Write(Html.HiddenFor(c => c[i].TypePortrait.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 22 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Setting\AllTypePortraits.cshtml"
                       Write(Html.HiddenFor(c => c[i].Deleted));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <a class=\"remove float-md-left \" title=\"Удалить\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21395c05ec362607b576554efaccb700598c3c8411449", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 28 "E:\Учеба\БГУиР\Дипломный проект\CRM_Monuments_Sol\Web_CRM_Monuments\Views\Setting\AllTypePortraits.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n        <div>\r\n            <input type=\"submit\" value=\"Сохранить изменения\" class=\"btn btn-primary\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#Add"").click(AddTypePortrait);
            $("".remove"").click(RemoveTypePortrait);
        });

        function AddTypePortrait() {
            var TypeTextsBlock = $($(document).find("".table"")[0]).find(""#body"")[0];
            var Count = $(document).find(""[id*='container']"").length;
            console.log(TypeTextsBlock);
            var Tr = $(""<tr/>"").attr(""id"", ""container"" + Count).appendTo(TypeTextsBlock);
            var Td = $(""<td/>"").appendTo(Tr);
            $(""<input/>"")
                .attr(""class"", ""form-control float-md-left"")
                .attr(""type"", ""text"")
                .attr(""name"", ""["" + Count + ""].TypePortrait.Name"")
                .attr(""id"", ""z"" + Count + ""__TypePortrait_Name"")
                .appendTo(Td);

            $(""<input/>"").attr(""data-val"", true).attr(""name"", ""["" + Count + ""].TypePortrait.Id"")
                .attr(""type"", ""hidden"").attr(""data-val-required"", ""The Id field is r");
                WriteLiteral(@"equired."")
                .attr(""id"", ""z"" + Count + ""__TypePortrait_Id"").appendTo(Td);
            $(""<input/>"").attr(""data-val"", true).attr(""data-val-required"", ""The Id field is required."")
                .attr(""name"", ""["" + Count + ""].Deleted"")
                .attr(""id"", ""z"" + Count + ""__Deleted"")
                .attr(""type"", ""hidden"")
                .attr(""value"", ""false"")
                .attr(""class"", ""check-box"")
                .appendTo(Td);

            var ImgLink = $(""<a/>"").attr(""class"", ""remove float-md-left"").attr(""title"", ""Удалить"").appendTo(Td);
            $(""<img/>"").attr(""src"", ""/Images/remove.png"").attr(""class"", ""s-remove-btn"").appendTo(ImgLink);
        }

        function RemoveTypePortrait() {
            if (confirm(""Вы действительно хотите удалить тип портрета?"")) {
                var Container = $(this)[0].closest(""[id*='container']"");
                $($(Container).find(""[id$='__Deleted']"")[0]).val(true)
                $(Container).attr(""hidden"", true);
   ");
                WriteLiteral("         }\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TypePortraitViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

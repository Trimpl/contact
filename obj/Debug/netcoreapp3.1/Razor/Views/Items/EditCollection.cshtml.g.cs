#pragma checksum "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fbc54dd39a8b55489785589d82673e95020f226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_EditCollection), @"mvc.1.0.view", @"/Views/Items/EditCollection.cshtml")]
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
#line 1 "C:\Users\Trimpl\Desktop\itra\contact\Views\_ViewImports.cshtml"
using contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trimpl\Desktop\itra\contact\Views\_ViewImports.cshtml"
using contact.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Trimpl\Desktop\itra\contact\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fbc54dd39a8b55489785589d82673e95020f226", @"/Views/Items/EditCollection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b23f3bdeb39f231a20ba212cec3e2e2715309c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_EditCollection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<contact.Models.Collect>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/addCh.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Alcohol", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Guns", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Phones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditSaveCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbc54dd39a8b55489785589d82673e95020f2266519", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbc54dd39a8b55489785589d82673e95020f2267780", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6fbc54dd39a8b55489785589d82673e95020f2268042", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 5 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"form-group col-lg-3 col-md-5\">\r\n            <label for=\"recipient-name\" class=\"col-form-label\">");
#nullable restore
#line 8 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                          Write(Localizer["Topic"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <input type=\"text\" name=\"Topic\"");
                BeginWriteAttribute("class", " class=\"", 445, "\"", 632, 2);
                WriteAttributeValue("", 453, "form-control", 453, 12, true);
                WriteAttributeValue(" ", 465, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 9 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                                 if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);\r\n");
#nullable restore
#line 10 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 466, 166, false);
                EndWriteAttribute();
                WriteLiteral(" id=\"recipient-name\"");
                BeginWriteAttribute("value", " value=\"", 653, "\"", 673, 1);
#nullable restore
#line 10 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
WriteAttributeValue("", 661, Model.Topic, 661, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group col-lg-3 col-md-5\">\r\n            <label for=\"message-text\" class=\"col-form-label\">");
#nullable restore
#line 13 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                        Write(Localizer["Theme"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <select name=\"Theme\"");
                BeginWriteAttribute("class", " class=\"", 867, "\"", 1054, 2);
                WriteAttributeValue("", 875, "form-control", 875, 12, true);
                WriteAttributeValue(" ", 887, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 14 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                      if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);\r\n");
#nullable restore
#line 15 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 888, 166, false);
                EndWriteAttribute();
                WriteLiteral(" id=\"message-text\"");
                BeginWriteAttribute("value", " value=\"", 1073, "\"", 1093, 1);
#nullable restore
#line 15 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
WriteAttributeValue("", 1081, Model.Theme, 1081, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbc54dd39a8b55489785589d82673e95020f22613889", async() => {
#nullable restore
#line 16 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                   Write(Localizer["Alcohol"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbc54dd39a8b55489785589d82673e95020f22615301", async() => {
#nullable restore
#line 17 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                Write(Localizer["Cars"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbc54dd39a8b55489785589d82673e95020f22616707", async() => {
#nullable restore
#line 18 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                Write(Localizer["Guns"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbc54dd39a8b55489785589d82673e95020f22618113", async() => {
#nullable restore
#line 19 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                  Write(Localizer["Phones"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n    </div>\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"form-group col-lg-7 col-md-7 text-center\" id=\"cartinka\">\r\n");
#nullable restore
#line 25 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
             if (Model.Img != "")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <img style=\"width:100%;max-width:900px;max-height:500px;\" id=\"cartinka\" class=\"mx-auto rounded shadow mb-3\"");
                BeginWriteAttribute("src", " src=\"", 1719, "\"", 1735, 1);
#nullable restore
#line 27 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
WriteAttributeValue("", 1725, Model.Img, 1725, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 28 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"form-group col-lg-3 col-md-4\">\r\n            <input type=\"text\" style=\"display : none;\" id=\"imgur_link\" name=\"img\"");
                BeginWriteAttribute("value", " value=\"", 1963, "\"", 1981, 1);
#nullable restore
#line 33 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
WriteAttributeValue("", 1971, Model.Img, 1971, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div class=\"custom-file \">\r\n                <input type=\"file\"");
                BeginWriteAttribute("class", " class=\"", 2061, "\"", 2253, 2);
                WriteAttributeValue("", 2069, "custom-file-input", 2069, 17, true);
                WriteAttributeValue(" ", 2086, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 35 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                             if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);\r\n");
#nullable restore
#line 36 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 2087, 166, false);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2254, "\"", 2272, 1);
#nullable restore
#line 36 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
WriteAttributeValue("", 2262, Model.Img, 2262, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onchange=\"upload(this.files[0])\">\r\n                <label");
                BeginWriteAttribute("class", " class=\"", 2331, "\"", 2537, 3);
                WriteAttributeValue("", 2339, "custom-file-label", 2339, 17, true);
                WriteAttributeValue(" ", 2356, "text-truncate", 2357, 14, true);
                WriteAttributeValue(" ", 2370, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 37 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                               if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);\r\n");
#nullable restore
#line 38 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 2371, 166, false);
                EndWriteAttribute();
                WriteLiteral(" for=\"customFile\" id=\"Label\">");
#nullable restore
#line 38 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                                                  Write(Localizer["Upload"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"form-group col-lg-5 col-md-10\">\r\n            <label for=\"message-text\" class=\"col-form-label\">");
#nullable restore
#line 44 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                        Write(Localizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <textarea name=\"Description\"");
                BeginWriteAttribute("class", " class=\"", 2880, "\"", 3243, 3);
                WriteAttributeValue("", 2888, "form-control", 2888, 12, true);
                WriteAttributeValue(" ", 2900, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 45 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                              if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);min-height:200px;\"\r\n");
#nullable restore
#line 46 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                        } 
                                                        else {

#line default
#line hidden
#nullable disable
                    WriteLiteral("\" style=\"min-height:200px;\"\r\n");
#nullable restore
#line 48 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 2901, 337, false);
                WriteAttributeValue("  ", 3238, "id=", 3240, 5, true);
                EndWriteAttribute();
                WriteLiteral("message-text\">");
#nullable restore
#line 48 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n        </div>\r\n    </div>\r\n    <div class=\"row justify-content-center\">\r\n        <button class=\"btn btn-dark\">");
#nullable restore
#line 52 "C:\Users\Trimpl\Desktop\itra\contact\Views\Items\EditCollection.cshtml"
                                Write(Localizer["Save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<contact.Models.Collect> Html { get; private set; }
    }
}
#pragma warning restore 1591

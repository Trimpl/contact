#pragma checksum "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596e9ba8e9e39cebfb2738fbd91a8a4b43283a3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_CreateItem), @"mvc.1.0.view", @"/Views/Items/CreateItem.cshtml")]
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
#line 1 "C:\Users\Trimpl\Desktop\projects\contact\Views\_ViewImports.cshtml"
using contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trimpl\Desktop\projects\contact\Views\_ViewImports.cshtml"
using contact.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Trimpl\Desktop\projects\contact\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596e9ba8e9e39cebfb2738fbd91a8a4b43283a3b", @"/Views/Items/CreateItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b23f3bdeb39f231a20ba212cec3e2e2715309c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_CreateItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<contact.ViewModels.CreateItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/addCh.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "596e9ba8e9e39cebfb2738fbd91a8a4b43283a3b5057", async() => {
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
            WriteLiteral(@"
<script type=""text/javascript"">
(function() {
  'use strict';
  window.addEventListener('load', function() {
    var forms = document.getElementsByClassName('needs-validation');
    var validation = Array.prototype.filter.call(forms, function(form) {
      form.addEventListener('submit', function(event) {
        if (form.checkValidity() === false) {
          event.preventDefault();
          event.stopPropagation();
        }
        form.classList.add('was-validated');
      }, false);
    });
  }, false);
})();

    </script>
<script type=""text/javascript"">
    function SearchT() {
        var url = $('#validationTooltip03').val();
        var string = """";
        $.ajax({
            url: '");
#nullable restore
#line 27 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
             Write(Url.Action("TagList", "Items"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            async: true,
            cache: false,
            data: { search: url},
            success: function (data) {
                $.each(data, function (k, val) {
                    string += '<button type=""button"" onclick=""Add(' + ""'"" + val + ""'"" + ')"" class=""list-group-item list-group-item-action"">' + val + '</button>';
                });
                $('#tags').empty();
                $('#tags').append(string);
            }
        });
    }
    function empty() {
        $('#tags').empty();
    }
    function Add(str) {
        console.log('кнопка ' + str);
        var input = $('#validationTooltip03').val();
        var array = input.split('#');
        array.splice(0,1);
        console.log(input);
        console.log(array);
        array.pop();
        console.log(array);
        array.push(str);
        console.log(array);
        $('#validationTooltip03').val('#' + array.join('#'));
    }
</script>
<div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "596e9ba8e9e39cebfb2738fbd91a8a4b43283a3b8058", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Topic\"");
                BeginWriteAttribute("value", " value=\"", 2082, "\"", 2102, 1);
#nullable restore
#line 59 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
WriteAttributeValue("", 2090, Model.Topic, 2090, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 2149, "\"", 2169, 1);
#nullable restore
#line 60 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
WriteAttributeValue("", 2157, Model.Email, 2157, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <div class=\"row justify-content-center\">\r\n            <div class=\"col-lg-3 col-md-4 mb-2\">\r\n                <div class=\"input-group\">\r\n                    <div class=\"input-group-prepend\">\r\n                        <div");
                BeginWriteAttribute("class", " class=\"", 2401, "\"", 2593, 2);
                WriteAttributeValue("", 2409, "input-group-text", 2409, 16, true);
                WriteAttributeValue(" ", 2425, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 65 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                      if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(120,129,176);\r\n");
#nullable restore
#line 66 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 2426, 167, false);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                      Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <input required type=\"text\" name=\"Name\"");
                BeginWriteAttribute("class", " class=\"", 2708, "\"", 2909, 3);
                WriteAttributeValue("", 2716, "form-control", 2716, 12, true);
                WriteAttributeValue(" ", 2728, "rounded-right", 2729, 14, true);
                WriteAttributeValue(" ", 2742, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 68 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                                               if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);\r\n");
#nullable restore
#line 69 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 2743, 166, false);
                EndWriteAttribute();
                WriteLiteral(" id=\"recipient-name\">\r\n                    <div class=\"invalid-feedback\">\r\n                        ");
#nullable restore
#line 71 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                   Write(Localizer["feedback"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-4 mb-2\">\r\n                <div class=\"input-group\">\r\n                    <div class=\"input-group-prepend\">\r\n                        <div");
                BeginWriteAttribute("class", " class=\"", 3281, "\"", 3473, 2);
                WriteAttributeValue("", 3289, "input-group-text", 3289, 16, true);
                WriteAttributeValue(" ", 3305, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 78 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                      if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(120,129,176);\r\n");
#nullable restore
#line 79 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 3306, 167, false);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 79 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                      Write(Localizer["Tag"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <input required onkeyup=\"SearchT()\" autocomplete=\"off\" type=\"text\" name=\"Tag\"");
                BeginWriteAttribute("class", " class=\"", 3625, "\"", 3826, 3);
                WriteAttributeValue("", 3633, "form-control", 3633, 12, true);
                WriteAttributeValue(" ", 3645, "rounded-right", 3646, 14, true);
                WriteAttributeValue(" ", 3659, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 81 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                                                                                     if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);\r\n");
#nullable restore
#line 82 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 3660, 166, false);
                EndWriteAttribute();
                WriteLiteral(" id=\"validationTooltip03\" value=\"#\">\r\n                    <div class=\"invalid-feedback\">\r\n                        ");
#nullable restore
#line 84 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                   Write(Localizer["feedback"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""list-group rounded shadow-sm"" id=""tags"" style=""position:absolute;z-index:999;max-height:200px;overflow-y:auto;width:inherit;"">
                    
                </div>
            </div>
        </div>
        <div class=""row justify-content-center"">
            <div class=""form-group col-lg-7 col-md-7 text-center"" id=""cartinka""></div>
        </div>
        <div class=""row justify-content-center"">
            <div class=""form-group col-lg-6 col-md-8 my-2"">
                <input type=""text"" style=""display : none;"" id=""imgur_link"" name=""img""");
                BeginWriteAttribute("value", " value=\"", 4605, "\"", 4613, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <div class=\"custom-file \">\r\n                    <input type=\"file\"");
                BeginWriteAttribute("class", " class=\"", 4701, "\"", 4893, 2);
                WriteAttributeValue("", 4709, "custom-file-input", 4709, 17, true);
                WriteAttributeValue(" ", 4726, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 99 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                 if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);\r\n");
#nullable restore
#line 100 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 4727, 166, false);
                EndWriteAttribute();
                WriteLiteral(" onchange=\"upload(this.files[0])\">\r\n                    <label");
                BeginWriteAttribute("class", " class=\"", 4956, "\"", 5163, 3);
                WriteAttributeValue("", 4964, "custom-file-label", 4964, 17, true);
                WriteAttributeValue(" ", 4981, "text-truncate", 4982, 14, true);
                WriteAttributeValue(" ", 4995, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 101 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                   if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(120,129,176);\r\n");
#nullable restore
#line 102 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 4996, 167, false);
                EndWriteAttribute();
                WriteLiteral(" for=\"customFile\" id=\"Label\">");
#nullable restore
#line 102 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                                  Write(Localizer["Upload"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 106 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
         foreach (var collection in JsonSerializer.Deserialize<Dictionary<string, string[]>>(Model.Fields))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
             if (collection.Value.Length != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                 foreach (var value in collection.Value)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                     if (collection.Key == "int")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row justify-content-center\">\r\n                            <div class=\"col-lg-6 col-md-8 mb-2\">\r\n                                <label for=\"recipient-name\" class=\"col-form-label\">");
#nullable restore
#line 116 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                              Write(value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input type=\"hidden\" id=\"Int\" name=\"Int\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 5941, "\"", 5955, 1);
#nullable restore
#line 117 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
WriteAttributeValue("", 5949, value, 5949, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input type=\"number\" id=\"Int\" name=\"Int\"");
                BeginWriteAttribute("class", " class=\"", 6031, "\"", 6218, 2);
                WriteAttributeValue("", 6039, "form-control", 6039, 12, true);
                WriteAttributeValue(" ", 6051, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 118 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                                              if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);\r\n");
#nullable restore
#line 119 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 6052, 166, false);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 122 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                     if (collection.Key == "str")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row justify-content-center\">\r\n                            <div class=\"col-lg-6 col-md-8 mb-2\">\r\n                                <label for=\"recipient-name\" class=\"col-form-label\">");
#nullable restore
#line 127 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                              Write(value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input type=\"hidden\" id=\"Str\" name=\"Str\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 6711, "\"", 6725, 1);
#nullable restore
#line 128 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
WriteAttributeValue("", 6719, value, 6719, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <textarea type=\"text\" id=\"Str\" name=\"Str\"");
                BeginWriteAttribute("class", " class=\"", 6802, "\"", 6989, 2);
                WriteAttributeValue("", 6810, "form-control", 6810, 12, true);
                WriteAttributeValue(" ", 6822, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 129 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                                               if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);\r\n");
#nullable restore
#line 130 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 6823, 166, false);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 133 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                     if (collection.Key == "date")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row justify-content-center\">\r\n                            <div class=\"col-lg-6 col-md-8 mb-2\">\r\n                                <label for=\"recipient-name\" class=\"col-form-label\">");
#nullable restore
#line 138 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                              Write(value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input type=\"hidden\" id=\"Date\" name=\"Date\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 7496, "\"", 7510, 1);
#nullable restore
#line 139 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
WriteAttributeValue("", 7504, value, 7504, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input type=\"date\" id=\"Date\" name=\"Date\"");
                BeginWriteAttribute("class", " class=\"", 7586, "\"", 7773, 2);
                WriteAttributeValue("", 7594, "form-control", 7594, 12, true);
                WriteAttributeValue(" ", 7606, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 140 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                                              if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176);\r\n");
#nullable restore
#line 141 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 7607, 166, false);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 144 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                     if (collection.Key == "bool")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row justify-content-center\">\r\n                            <div class=\"col-lg-6 col-md-8 mb-2\">\r\n                                <input type=\"hidden\" id=\"Bool\" name=\"Bool\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 8170, "\"", 8184, 1);
#nullable restore
#line 149 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
WriteAttributeValue("", 8178, value, 8178, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <label for=\"recipient-name\" class=\"col-form-label\">");
#nullable restore
#line 150 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                              Write(value);

#line default
#line hidden
#nullable disable
                WriteLiteral(": <input type=\"checkbox\" id=\"Bool\" name=\"Bool\" style=\"height:15px;width:15px;\"></label>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 153 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row justify-content-center\">\r\n            <button class=\"btn btn-dark\" type=\"submit\">\r\n                <div class=\"btn-txt\">");
#nullable restore
#line 159 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                Write(Localizer["CreateItem"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            </button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Topic", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                   WriteLiteral(Model.Topic);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Topic"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Topic", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Topic"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                  WriteLiteral(Model.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Email", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\CreateItem.cshtml"
                                                                                                        WriteLiteral(Model.IdCollection);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["IdCollection"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-IdCollection", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["IdCollection"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<contact.ViewModels.CreateItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

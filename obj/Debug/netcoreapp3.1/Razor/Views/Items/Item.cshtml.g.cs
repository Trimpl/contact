#pragma checksum "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20939f5da9b85c127bded51727ec0510904496e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Item), @"mvc.1.0.view", @"/Views/Items/Item.cshtml")]
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
#line 4 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20939f5da9b85c127bded51727ec0510904496e", @"/Views/Items/Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b23f3bdeb39f231a20ba212cec3e2e2715309c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<contact.ViewModels.ItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CollectionsItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Westwind.AspNetCore.Markdown.MarkdownTagHelper __Westwind_AspNetCore_Markdown_MarkdownTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script src=\"//code.jquery.com/jquery-1.11.3.min.js\"></script>\r\n<script src=\"//ajax.aspnetcdn.com/ajax/jquery.ui/1.10.3/jquery-ui.min.js\"></script>\r\n");
            WriteLiteral(@"<script type=""text/javascript"">
    $(document).ready(
        function Again() {
            var name = $('#searchh').val();
            name = encodeURIComponent(name);
            var color = $('#Color').val();
            var text = $('#Text').val();
            var status = $('#status').val();
            $.ajax({
                url: '");
#nullable restore
#line 14 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                 Write(Url.Action("ListComments", "Items"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?IdItem=' + name,
                async: true,
                cache: false,
                success: function (data) {
                    var string = '';
                    $.each(data, function (k, val) {
                        var date = new Date(Date.parse(val.time));
                        var d = new Date(date.getFullYear(), date.getMonth(), date.getDay());
                        d = formatDate(d);
                        var nowdate = d + '  ' + date.getHours() + ':' + date.getMinutes();
                        var a = """";
                        if (status == ""True"") {
                            a = '<a class=""btn btn-xs"" href=""/Items/DeleteComment/?Id=' + val.id + '""><i class=""fas fa-trash-alt""></i></a>';
                        };
                        string += '<div id=""' + k + '"" class=""row"">' +
                                        '<div class=""col-sm-12 col-md-12 mb-2"">' +
                                            '<div class=""card shadow-sm border-0"">' +
         ");
            WriteLiteral(@"                                       '<div class=""card-header bg-dark text-light d-flex justify-content-between"">' +
                            '<b>' + val.userEmail + '</b><small class=""ml-auto"">' + nowdate + '</small>' + a +
                                                '</div>' +
                                                '<div class=""card-body""'+ ' style=""' + color + '"">'+
                                                    '<p class=""card-text"">' + val.comment + '</p>'+
                                                '</div>' +
                                            '</div>' +
                                        '</div>' +
                                    '</div>';
                    });
                    if ($('#results').html() != string) {
                        $('#results').empty();
                        $('#results').append(string);
                    };
                    setTimeout(Again,4000);
                }
            });
        });
    funct");
            WriteLiteral(@"ion formatDate(date) {

        var dd = date.getDate();
        if (dd < 10) dd = '0' + dd;

        var mm = date.getMonth() + 1;
        if (mm < 10) mm = '0' + mm;

        var yy = date.getFullYear() % 100;
        if (yy < 10) yy = '0' + yy;

        return dd + '.' + mm + '.' + yy;
    }
</script>
<script type=""text/javascript"">
    function Like() {
        var name = $('#searchh').val();
        name = encodeURIComponent(name);
        if ($('#like').html().includes('<i class=""far fa-heart""></i>')) {
            $.ajax({
                url: '");
#nullable restore
#line 69 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                 Write(Url.Action("Like", "Items"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?ItemId=' + name,
                async: true,
                cache: false,
                success: function (data) {
                    $('#like').empty();
                    $('#like').append(data + ' <i class=""fas fa-heart""></i>');
                }
            });
        }
        else {
            $.ajax({
                url: '");
#nullable restore
#line 80 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                 Write(Url.Action("Like", "Items"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?ItemId=' + name,
                async: true,
                cache: false,
                success: function (data) {
                    $('#like').empty();
                    $('#like').append(data + ' <i class=""far fa-heart""></i>');
                }
            });
        }
        
    }
</script>
");
#nullable restore
#line 92 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"hidden\" id=\"status\"");
            BeginWriteAttribute("value", " value=\"", 4029, "\"", 4062, 1);
#nullable restore
#line 95 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
WriteAttributeValue("", 4037, Model.isAdmin.ToString(), 4037, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<div class=\"row\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 4095, "\"", 4432, 9);
            WriteAttributeValue("", 4103, "col-md-5", 4103, 8, true);
            WriteAttributeValue(" ", 4111, "col-md-5", 4112, 9, true);
            WriteAttributeValue(" ", 4120, "col-lg-5", 4121, 9, true);
            WriteAttributeValue(" ", 4129, "mb-3", 4130, 5, true);
            WriteAttributeValue(" ", 4134, "mx-5", 4135, 5, true);
            WriteAttributeValue(" ", 4139, "rounded", 4140, 8, true);
            WriteAttributeValue(" ", 4147, "shadow", 4148, 7, true);
            WriteAttributeValue(" ", 4154, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 97 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                     if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                WriteLiteral("border-0\" style=\"background:rgb(21,46,77)\r\n");
#nullable restore
#line 98 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                            } else {

#line default
#line hidden
#nullable disable
                WriteLiteral(" border \r\n");
#nullable restore
#line 99 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                                    }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 4155, 276, false);
            WriteAttributeValue(" ", 4431, "", 4432, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"sticky-top mt-2 text-center\">\r\n            <div class=\"mb-2\">\r\n");
#nullable restore
#line 102 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                 if (Model.isAdmin == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20939f5da9b85c127bded51727ec0510904496e13907", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20939f5da9b85c127bded51727ec0510904496e14190", async() => {
#nullable restore
#line 105 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                                                                  Write(Localizer["EditItem"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                                           WriteLiteral(Model.Item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20939f5da9b85c127bded51727ec0510904496e16962", async() => {
#nullable restore
#line 106 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                                                                                    Write(Localizer["Back"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                                                   WriteLiteral(Model.Item.IdCollection);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 110 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
             if (Model.Item.Img != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"text-center\">\r\n                    <img style=\"width:100%;max-width:600px;max-height:600px;\" class=\"mx-auto rounded shadow mb-3\"");
            BeginWriteAttribute("src", " src=\"", 5228, "\"", 5249, 1);
#nullable restore
#line 113 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
WriteAttributeValue("", 5234, Model.Item.Img, 5234, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n");
#nullable restore
#line 115 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
             foreach (var fields in JsonSerializer.Deserialize<Dictionary<string, string[]>>(Model.Item.Fields))
            {
                if (fields.Value.Length != 0)
                {
                    for (int j = 0; j < fields.Value.Length; j += 2)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                         if (fields.Key == "int")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"mb-2 mx-auto\">\r\n                                    <h4>");
#nullable restore
#line 126 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                   Write(fields.Value.ElementAt(j));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  ");
#nullable restore
#line 126 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                    Write(fields.Value.ElementAt(j + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 129 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                         if (fields.Key == "str")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"mb-2 mx-auto\">\r\n                                    <h4>");
#nullable restore
#line 134 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                   Write(fields.Value.ElementAt(j));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("markdown", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20939f5da9b85c127bded51727ec0510904496e24317", async() => {
#nullable restore
#line 134 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                              Write(fields.Value.ElementAt(j + 1));

#line default
#line hidden
#nullable disable
            }
            );
            __Westwind_AspNetCore_Markdown_MarkdownTagHelper = CreateTagHelper<global::Westwind.AspNetCore.Markdown.MarkdownTagHelper>();
            __tagHelperExecutionContext.Add(__Westwind_AspNetCore_Markdown_MarkdownTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 137 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                         if (fields.Key == "date")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"mb-2 mx-auto\">\r\n                                    <h4>");
#nullable restore
#line 142 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                   Write(fields.Value.ElementAt(j));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  ");
#nullable restore
#line 142 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                    Write(fields.Value.ElementAt(j + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 145 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                         if (fields.Key == "bool")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"mb-2 mx-auto\">\r\n                                    <input type=\"hidden\" id=\"Bool\" name=\"Bool\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 7068, "\"", 7102, 1);
#nullable restore
#line 150 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
WriteAttributeValue("", 7076, fields.Value.ElementAt(j), 7076, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <h4>\r\n                                        ");
#nullable restore
#line 152 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                   Write(fields.Value.ElementAt(j));

#line default
#line hidden
#nullable disable
            WriteLiteral(": <input disabled type=\"checkbox\" id=\"Bool\" name=\"Bool\" style=\"height:15px;width:15px;\" ");
#nullable restore
#line 152 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                                                                                                           if (fields.Value.ElementAt(j + 1) == "on") {

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral(" checked\r\n");
#nullable restore
#line 153 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    </h4>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 157 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                         
                    }
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <input type=\"hidden\" id=\"searchh\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 7722, "\"", 7744, 1);
#nullable restore
#line 162 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
WriteAttributeValue("", 7730, Model.Item.Id, 7730, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div id=\"likes\">\r\n                <button type=\"button\" class=\"btn btn-dark btn-lg mb-2\" id=\"like\" onclick=\"Like()\" ");
#nullable restore
#line 165 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                                                   if (!User.Identity.IsAuthenticated) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral(" disabled\r\n");
#nullable restore
#line 166 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 167 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
               Write(Model.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 168 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                     if (Model.Liked == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"far fa-heart\"></i>");
#nullable restore
#line 169 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                 }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fas fa-heart\"></i>");
#nullable restore
#line 171 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-sm-12 col-md-5 col-lg-4 mb-2 ml-lg-5 ml-md-0\">\r\n        <div>\r\n");
#nullable restore
#line 178 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20939f5da9b85c127bded51727ec0510904496e32139", async() => {
                WriteLiteral("\r\n                    <button class=\"btn btn-dark btn-block\" type=\"submit\" name=\"IdItem\"");
                BeginWriteAttribute("value", " value=\"", 8576, "\"", 8598, 1);
#nullable restore
#line 181 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
WriteAttributeValue("", 8584, Model.Item.Id, 8584, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 181 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                                                         Write(Localizer["Add"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    <textarea name=\"Text\"");
                BeginWriteAttribute("class", " class=\"", 8669, "\"", 8875, 2);
                WriteAttributeValue("", 8677, "form-control", 8677, 12, true);
                WriteAttributeValue(" ", 8689, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 182 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                               if (Context.Request.Cookies["theme"] == "dark") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("border-0 text-light\" style=\"background:rgb(83,129,176)\r\n");
#nullable restore
#line 183 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 8690, 185, false);
                EndWriteAttribute();
                WriteLiteral(" aria-label=\"With textarea\"></textarea>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 185 "C:\Users\Trimpl\Desktop\projects\contact\Views\Items\Item.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div id=\"results\"></div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<contact.ViewModels.ItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e3bdd904a943dfe9e9ec164c390868ed52e74e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\_ViewImports.cshtml"
using LibraryAspNetCore;

#line default
#line hidden
#line 2 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
using LibraryAspNetCore.Models;

#line default
#line hidden
#line 3 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
using LibraryAspNetCore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e3bdd904a943dfe9e9ec164c390868ed52e74e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5acb1787d0d7480690acca622493a3601d05c56", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryAspNetCore.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(166, 186, true);
            WriteLiteral("\r\n<h3>Все книги</h3>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Название</td>\r\n        <td>Автор</td>\r\n        <td>Жанр</td>\r\n        <td>Издатель</td>\r\n        <td></td>\r\n    </tr>\r\n");
            EndContext();
#line 17 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(393, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(424, 9, false);
#line 20 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(433, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(457, 16, false);
#line 21 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
           Write(item.Author.Name);

#line default
#line hidden
            EndContext();
            BeginContext(473, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(497, 17, false);
#line 22 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
           Write(item.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(514, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(538, 25, false);
#line 23 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
           Write(item.PublishingHouse.Name);

#line default
#line hidden
            EndContext();
            BeginContext(563, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(1173, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(1207, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "916880572c614ebeb52392f4fb8edac7", async() => {
                BeginContext(1274, 44, true);
                WriteLiteral("<div class=\"btn btn-default\">Подробнее</div>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1322, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1365, 12, true);
            WriteLiteral("\r\n</table>\r\n");
            EndContext();
#line 46 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
 if (!User.IsInRole("User"))
{

#line default
#line hidden
            BeginContext(1410, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1414, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8668cb3f27b74440ada9cd3933db3161", async() => {
                BeginContext(1463, 49, true);
                WriteLiteral("<div class=\"btn btn-success\">Добавить книгу</div>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1516, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryAspNetCore.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591

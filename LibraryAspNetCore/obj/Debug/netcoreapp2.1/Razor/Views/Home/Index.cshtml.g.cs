#pragma checksum "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc70db09bdba2e01ba925e2d019e0727adb05514"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc70db09bdba2e01ba925e2d019e0727adb05514", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5acb1787d0d7480690acca622493a3601d05c56", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryAspNetCore.ViewModels.InfoBookViewModel>>
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
            BeginContext(183, 215, true);
            WriteLiteral("\r\n<h3>Все книги</h3>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Название</td>\r\n        <td>Автор</td>\r\n        <td>Жанр</td>\r\n        <td>Издатель</td>\r\n        <td>Библиотеки</td>\r\n        <td></td>\r\n    </tr>\r\n");
            EndContext();
#line 18 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(439, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(470, 14, false);
#line 21 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
           Write(item.Book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(484, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(508, 21, false);
#line 22 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
           Write(item.Book.Author.Name);

#line default
#line hidden
            EndContext();
            BeginContext(529, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(553, 22, false);
#line 23 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
           Write(item.Book.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(575, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(599, 30, false);
#line 24 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
           Write(item.Book.PublishingHouse.Name);

#line default
#line hidden
            EndContext();
            BeginContext(629, 47, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <ul>\r\n");
            EndContext();
#line 27 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
                     if (item.Libraries != null && item.Libraries.Count > 0)
                    {
                        foreach (InfoBookInLibraryViewModel library in item.Libraries)
                        {

#line default
#line hidden
            BeginContext(892, 32, true);
            WriteLiteral("                            <li>");
            EndContext();
            BeginContext(925, 20, false);
#line 31 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
                           Write(library.Library.Name);

#line default
#line hidden
            EndContext();
            BeginContext(945, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 32 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1051, 58, true);
            WriteLiteral("                        <li> Ещё нет в библиотеках </li>\r\n");
            EndContext();
#line 37 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1132, 76, true);
            WriteLiteral("                </ul>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1208, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbf4e9f7d9b74cf6b44ab6f85694a8de", async() => {
                BeginContext(1280, 44, true);
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
#line 41 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
                                                             WriteLiteral(item.Book.Id);

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
            BeginContext(1328, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 44 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1371, 12, true);
            WriteLiteral("\r\n</table>\r\n");
            EndContext();
#line 47 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
 if (!User.IsInRole("User"))
{

#line default
#line hidden
            BeginContext(1416, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1420, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04b1ca74ab554d1ba66804c4f4c3cdb4", async() => {
                BeginContext(1469, 49, true);
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
            BeginContext(1522, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 50 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryAspNetCore.ViewModels.InfoBookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

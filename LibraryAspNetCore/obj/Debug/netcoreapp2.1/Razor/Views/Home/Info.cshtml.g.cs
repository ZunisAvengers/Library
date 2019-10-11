#pragma checksum "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6546c2c2b9cba370090a3d5eca65b43dc4ff7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Info.cshtml", typeof(AspNetCore.Views_Home_Info))]
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
#line 2 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\_ViewImports.cshtml"
using LibraryAspNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6546c2c2b9cba370090a3d5eca65b43dc4ff7b", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5acb1787d0d7480690acca622493a3601d05c56", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryAspNetCore.ViewModels.InfoBookViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("align", new global::Microsoft.AspNetCore.Html.HtmlString("right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBookInCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
  
    ViewData["Title"] = "Info";
    string href = "";
    if (Model.Book.ImageType == "image/jpg") { href = Model.Book.ImagePath + ".jpg"; }
    else if (Model.Book.ImageType == "image/png") { href = Model.Book.ImagePath + ".png"; }

#line default
#line hidden
            BeginContext(301, 200, true);
            WriteLiteral("\r\n<h2>Info</h2>\r\n\r\n<div>\r\n    <h4>Book</h4>\r\n    <hr />\r\n    <div style=\"display:flex;justify-content:space-between\">\r\n\r\n        <dl class=\"dl-horizontal\" style=\"\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(502, 45, false);
#line 19 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Book.Name));

#line default
#line hidden
            EndContext();
            BeginContext(547, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(603, 41, false);
#line 22 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
           Write(Html.DisplayFor(model => model.Book.Name));

#line default
#line hidden
            EndContext();
            BeginContext(644, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(700, 57, false);
#line 25 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Book.YearOfPublishing));

#line default
#line hidden
            EndContext();
            BeginContext(757, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(813, 53, false);
#line 28 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
           Write(Html.DisplayFor(model => model.Book.YearOfPublishing));

#line default
#line hidden
            EndContext();
            BeginContext(866, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(922, 45, false);
#line 31 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Book.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(967, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1023, 41, false);
#line 34 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
           Write(Html.DisplayFor(model => model.Book.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 44, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        ");
            EndContext();
            BeginContext(1108, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ad07fd547df40bda1a265e6631f7b03", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1118, "~/", 1118, 2, true);
#line 37 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
AddHtmlAttributeValue("", 1120, href, 1120, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "typeof", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 37 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
AddHtmlAttributeValue("", 1135, Model.Book.ImageType, 1135, 21, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1207, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 39 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
     if (Model.Libraries.Count > 0 && Model.Libraries != null)
    {

#line default
#line hidden
            BeginContext(1292, 43, true);
            WriteLiteral("        <h4>Имеется в:</h4>\r\n        <ul>\r\n");
            EndContext();
#line 43 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
             foreach (var library in Model.Libraries)
            {

#line default
#line hidden
            BeginContext(1405, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(1426, 20, false);
#line 45 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
               Write(library.Library.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1446, 18, true);
            WriteLiteral(" (Книг в наличии: ");
            EndContext();
            BeginContext(1465, 23, false);
#line 45 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
                                                      Write(library.CurrentQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(1488, 24, true);
            WriteLiteral(")</li>\r\n                ");
            EndContext();
            BeginContext(1512, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e68e0cac94dd4c3fbd5dd55ee79ea01f", async() => {
                BeginContext(1604, 53, true);
                WriteLiteral("<div class=\"btn btn-success\">Добавить в корзину</div>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
                                                                      WriteLiteral(library.BookinLibraryId);

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
            BeginContext(1661, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
            }

#line default
#line hidden
            BeginContext(1678, 15, true);
            WriteLiteral("        </ul>\r\n");
            EndContext();
#line 49 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1717, 53, true);
            WriteLiteral("        <h4>Данной книги ещё нет в библиотеках</h4>\r\n");
            EndContext();
#line 53 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
    }

#line default
#line hidden
            BeginContext(1777, 27, true);
            WriteLiteral("</div>\r\n<br>\r\n<br>\r\n<div>\r\n");
            EndContext();
#line 58 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
     if (!User.IsInRole("User"))
    {

#line default
#line hidden
            BeginContext(1845, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1853, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5d9745da70b43e6bb45bd4487bad2d7", async() => {
                BeginContext(1934, 41, true);
                WriteLiteral("<div class=\"btn btn-danger\">Удалить</div>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
                                                             WriteLiteral(Model.Book.Id);

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
            BeginContext(1979, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1989, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29954f7eb614fe4851d7a74b4a8d295", async() => {
                BeginContext(2068, 43, true);
                WriteLiteral("<div class=\"btn btn-default\">Изменить</div>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
                                                           WriteLiteral(Model.Book.Id);

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
            BeginContext(2115, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 62 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Home\Info.cshtml"
    }

#line default
#line hidden
            BeginContext(2128, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2132, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "184547a1d80144e1951a8d4b67aed582", async() => {
                BeginContext(2154, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2170, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryAspNetCore.ViewModels.InfoBookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

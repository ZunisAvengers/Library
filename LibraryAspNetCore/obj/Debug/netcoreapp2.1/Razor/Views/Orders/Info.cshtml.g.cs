#pragma checksum "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f0708e0da43fd8b27eee4702d27b6b2b5c2ff45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Info), @"mvc.1.0.view", @"/Views/Orders/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Info.cshtml", typeof(AspNetCore.Views_Orders_Info))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f0708e0da43fd8b27eee4702d27b6b2b5c2ff45", @"/Views/Orders/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5acb1787d0d7480690acca622493a3601d05c56", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryAspNetCore.ViewModels.OrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
  
    ViewData["Title"] = "Info";

#line default
#line hidden
            BeginContext(94, 171, true);
            WriteLiteral("\r\n<h2>Info</h2>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Дата заказа:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(266, 35, false);
#line 17 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
       Write(Model.Order.DateOrder.ToString("D"));

#line default
#line hidden
            EndContext();
            BeginContext(301, 105, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Дата Выдачи заказа:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(407, 33, false);
#line 23 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
       Write(Model.Order.DateGet.ToString("D"));

#line default
#line hidden
            EndContext();
            BeginContext(440, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Библиотека:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(538, 24, false);
#line 29 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
       Write(Model.Order.Library.Name);

#line default
#line hidden
            EndContext();
            BeginContext(562, 81, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Статус:\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 35 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
             if (!Model.Order.IsGet)
            {

#line default
#line hidden
            BeginContext(696, 44, true);
            WriteLiteral("                <p>Вы не забрали книги</p>\r\n");
            EndContext();
#line 38 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
            }
            else if (!Model.Order.DeliveredInLibrary)
            {

#line default
#line hidden
            BeginContext(825, 54, true);
            WriteLiteral("                <p>Вы не вернули книги. Верните их до ");
            EndContext();
            BeginContext(880, 46, false);
#line 41 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
                                                 Write(Model.Order.DateOrder.AddDays(7).ToString("D"));

#line default
#line hidden
            EndContext();
            BeginContext(926, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 42 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
            }
            else if (Model.Order.Notflicetion)
            {

#line default
#line hidden
            BeginContext(1010, 35, true);
            WriteLiteral("                <p>Вы должник</p>\r\n");
            EndContext();
#line 46 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1093, 37, true);
            WriteLiteral("                <p>Заказ закрыт</p>\r\n");
            EndContext();
#line 50 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
            }

#line default
#line hidden
            BeginContext(1145, 62, true);
            WriteLiteral("        </dd>\r\n    </dl>\r\n    <h4>Список книг</h4>\r\n    <ul>\r\n");
            EndContext();
#line 55 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
         foreach (var item in Model.Books)
        {

#line default
#line hidden
            BeginContext(1262, 34, true);
            WriteLiteral("            <li>\r\n                ");
            EndContext();
            BeginContext(1296, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0a0aef748413aa6d55e878f94c58e", async() => {
                BeginContext(1361, 9, false);
#line 58 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1370, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(1373, 16, false);
#line 58 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
                                                                                       Write(item.Author.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1389, 1, true);
                WriteLiteral(")");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1394, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 60 "C:\Users\ktitov\source\repos\LibraryAspNetCore\LibraryAspNetCore\Views\Orders\Info.cshtml"
        }

#line default
#line hidden
            BeginContext(1426, 59, true);
            WriteLiteral("    </ul>\r\n</div>\r\n<div>\r\n    <div class=\"btn btn-default\">");
            EndContext();
            BeginContext(1485, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab232e3ae164095bc8a4c234e48090f", async() => {
                BeginContext(1507, 14, true);
                WriteLiteral("Назад к списку");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1525, 16, true);
            WriteLiteral("</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryAspNetCore.ViewModels.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

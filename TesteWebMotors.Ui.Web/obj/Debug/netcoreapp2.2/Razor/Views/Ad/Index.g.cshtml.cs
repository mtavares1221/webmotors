#pragma checksum "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ea9cb6bdc1b9e7e37b7882bd823187bc416ea9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ad_Index), @"mvc.1.0.view", @"/Views/Ad/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ad/Index.cshtml", typeof(AspNetCore.Views_Ad_Index))]
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
#line 1 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\_ViewImports.cshtml"
using TesteWebMotors.Ui.Web;

#line default
#line hidden
#line 2 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\_ViewImports.cshtml"
using TesteWebMotors.Ui.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ea9cb6bdc1b9e7e37b7882bd823187bc416ea9", @"/Views/Ad/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f08960722e313924af74cb9029dbad1b29f82d", @"/Views/_ViewImports.cshtml")]
    public class Views_Ad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TesteWebMotors.Domain.Entities.Ad>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
  
    ViewData["Title"] = "Anúncios";

#line default
#line hidden
            BeginContext(101, 32, true);
            WriteLiteral("\r\n<h1>Anúncios</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(133, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ea9cb6bdc1b9e7e37b7882bd823187bc416ea93854", async() => {
                BeginContext(156, 12, true);
                WriteLiteral("Novo Anúncio");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(172, 495, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Marca
            </th>
            <th>
                Modelo
            </th>
            <th>
               Versão
            </th>
            <th>
                Ano
            </th>
            <th>
                Quilometragem
            </th>
            <th>
                Observação
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 37 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(699, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(748, 39, false);
#line 40 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Make));

#line default
#line hidden
            EndContext();
            BeginContext(787, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(843, 40, false);
#line 43 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
            EndContext();
            BeginContext(883, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(939, 42, false);
#line 46 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Version));

#line default
#line hidden
            EndContext();
            BeginContext(981, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1037, 39, false);
#line 49 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1132, 37, false);
#line 52 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Km));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1225, 38, false);
#line 55 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Obs));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1319, 55, false);
#line 58 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1395, 58, false);
#line 59 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
           Write(Html.ActionLink("Exibir", "Details", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1474, 58, false);
#line 60 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
           Write(Html.ActionLink("Excluir", "Delete", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\Mama\source\repos\TesteWebMotors\TesteWebMotors.Ui.Web\Views\Ad\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1571, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TesteWebMotors.Domain.Entities.Ad>> Html { get; private set; }
    }
}
#pragma warning restore 1591

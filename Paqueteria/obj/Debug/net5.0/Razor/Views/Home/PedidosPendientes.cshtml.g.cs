#pragma checksum "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd01093603e8759d921b618932045957a2985e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PedidosPendientes), @"mvc.1.0.view", @"/Views/Home/PedidosPendientes.cshtml")]
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
#line 1 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\_ViewImports.cshtml"
using Paqueteria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\_ViewImports.cshtml"
using Paqueteria.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\_ViewImports.cshtml"
using Paqueteria.Models.dbModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\_ViewImports.cshtml"
using Paqueteria.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dd01093603e8759d921b618932045957a2985e1", @"/Views/Home/PedidosPendientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c761f402d6d6f2714c11faad331ec36c5316b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PedidosPendientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidosPendientesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/PedidosPendientes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
  
    ViewData["Title"] = "Pedidos pendientes";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dd01093603e8759d921b618932045957a2985e14193", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<h1 class=""d-flex justify-content-center"">Pedidos pendientes</h1>
<br />

<table id=""pendientes"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Descripcion</th>
            <th>Costo</th>
            <th>Destino</th>
            <th>Repartidor</th>
            <th>Estatus</th>
            <th>Marcar como</th>
        </tr>
    </thead>
    
    <tbody>
");
#nullable restore
#line 26 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
         foreach (Vpedido pendiente in Model.Pendientes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
           Write(pendiente.IdPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
           Write(pendiente.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
           Write(pendiente.Costo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
           Write(pendiente.Calle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
                            Write(pendiente.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
                                              Write(pendiente.Colonia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
           Write(pendiente.IdRepartidor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
                                   Write(pendiente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
                                                     Write(pendiente.Paterno);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
                                                                        Write(pendiente.Materno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
           Write(pendiente.Estatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
                              Write(pendiente.DescEst);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <input  type=\"button\" value=\"Recolectado\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1082, "\"", 1130, 4);
            WriteAttributeValue("", 1092, "cambiarEstatus(", 1092, 15, true);
#nullable restore
#line 36 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
WriteAttributeValue("", 1107, pendiente.IdPedido, 1107, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1126, ",", 1126, 1, true);
            WriteAttributeValue(" ", 1127, "2)", 1128, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" >\r\n                <input type=\"button\" value=\"Entregado\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1213, "\"", 1261, 4);
            WriteAttributeValue("", 1223, "cambiarEstatus(", 1223, 15, true);
#nullable restore
#line 37 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
WriteAttributeValue("", 1238, pendiente.IdPedido, 1238, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1257, ",", 1257, 1, true);
            WriteAttributeValue(" ", 1258, "3)", 1259, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\r\n                <input type=\"button\" value=\"Cancelado\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1343, "\"", 1391, 4);
            WriteAttributeValue("", 1353, "cambiarEstatus(", 1353, 15, true);
#nullable restore
#line 38 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
WriteAttributeValue("", 1368, pendiente.IdPedido, 1368, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1387, ",", 1387, 1, true);
            WriteAttributeValue(" ", 1388, "4)", 1389, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Fernando\source\repos\Paqueteria\Paqueteria\Views\Home\PedidosPendientes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PedidosPendientesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

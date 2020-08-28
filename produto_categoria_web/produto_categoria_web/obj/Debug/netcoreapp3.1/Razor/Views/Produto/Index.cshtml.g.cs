#pragma checksum "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d535a1d5faa769fca13f1e2f7d027d4f4c6eae31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
#line 1 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\_ViewImports.cshtml"
using produto_categoria_web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\_ViewImports.cshtml"
using produto_categoria_web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d535a1d5faa769fca13f1e2f7d027d4f4c6eae31", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44de82258e073a16799b33605a6799a9627c2af9", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dominio.Model.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Produto.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Produtos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title"">
                        Produtos
                    </div>
                </div>
                <div class=""card-body"">
                    <button onclick=""$('#modalAdicionar').modal();"" class=""btn btn-primary"">Adicionar Produto</button>
");
#nullable restore
#line 17 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
                     if (Model != null)
                    {
                        if (Model.Count > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <table class=""table table-striped table-hover mt-5"">
                                <thead>
                                    <tr>
                                        <th>Nome</th>
                                        <th>Descrição</th>
                                        <th>Preço</th>
                                        <th>Preço Anterior</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 32 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 35 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
                                           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 36 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
                                           Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 37 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
                                           Write(item.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 38 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
                                           Write(item.PrecoAnterior);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-right\">\r\n                                                <button class=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1808, "\"", 1865, 3);
            WriteAttributeValue("", 1818, "modalEditar(", 1818, 12, true);
#nullable restore
#line 40 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1830, JsonConvert.SerializeObject(item), 1830, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1864, ")", 1864, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button> |\r\n                                                <button class=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1953, "\"", 1980, 3);
            WriteAttributeValue("", 1963, "excluir(", 1963, 8, true);
#nullable restore
#line 41 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1971, item.Id, 1971, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1979, ")", 1979, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</button>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 44 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n");
#nullable restore
#line 47 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 55 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
Write(Html.Partial("_modalAdicionarProduto"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 56 "D:\Documentos\Repos\produto_categoria_web\produto_categoria_web\produto_categoria_web\Views\Produto\Index.cshtml"
Write(Html.Partial("_modalEditarProduto"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d535a1d5faa769fca13f1e2f7d027d4f4c6eae319950", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dominio.Model.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
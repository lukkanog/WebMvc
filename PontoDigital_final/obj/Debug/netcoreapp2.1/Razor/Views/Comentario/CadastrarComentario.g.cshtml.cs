#pragma checksum "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91f8bf2ee33dc0a97c191255f73cc42d3d0c76ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_CadastrarComentario), @"mvc.1.0.view", @"/Views/Comentario/CadastrarComentario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/CadastrarComentario.cshtml", typeof(AspNetCore.Views_Comentario_CadastrarComentario))]
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
#line 1 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\_ViewImports.cshtml"
using PontoDigital_final;

#line default
#line hidden
#line 2 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\_ViewImports.cshtml"
using PontoDigital_final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91f8bf2ee33dc0a97c191255f73cc42d3d0c76ec", @"/Views/Comentario/CadastrarComentario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a12cf24a622b5515d7b44a1d5000cf1eb2c499a", @"/Views/_ViewImports.cshtml")]
    public class Views_Comentario_CadastrarComentario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital_final.ViewModels.ComentarioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml"
  
    ViewData["Title"] = "Faça seu comentário | Ponto Digital";
    ViewData["css"] = "faleconosco-style.css";

#line default
#line hidden
            BeginContext(179, 100, true);
            WriteLiteral("<main class=\"container\">\r\n    <div class=\"content\">\r\n        <h2>Envie seu Comentário</h2>\r\n        ");
            EndContext();
            BeginContext(279, 2437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a1f34b4518d42fa8567b7d7ff463ed2", async() => {
                BeginContext(356, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml"
             if (@Model.Usuario != null)
            {

#line default
#line hidden
                BeginContext(415, 121, true);
                WriteLiteral("                <div class=\"campo\">\r\n                    <input type=\"text\" name=\"nome\" placeholder=\"Nome\" maxlength=\"50\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 536, "\"", 563, 1);
#line 14 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml"
WriteAttributeValue("", 544, Model.Usuario.Nome, 544, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(564, 173, true);
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"campo\">\r\n                    <input type=\"text\" name=\"numero\" placeholder=\"Número de telefone\" maxlength=\"12\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 737, "\"", 768, 1);
#line 17 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml"
WriteAttributeValue("", 745, Model.Usuario.Telefone, 745, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(769, 171, true);
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"campo\">\r\n                    <input type=\"email\" name=\"email\" maxlength=\"50\" id=\"email\" placeholder=\"Email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 940, "\"", 968, 1);
#line 20 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml"
WriteAttributeValue("", 948, Model.Usuario.Email, 948, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(969, 163, true);
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"campo\">\r\n                    <input type=\"text\" name=\"empresa\" placeholder=\"Empresa\" maxlength=\"50\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1132, "\"", 1167, 1);
#line 23 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml"
WriteAttributeValue("", 1140, Model.Usuario.Empresa.Nome, 1140, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1168, 168, true);
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"campo\">\r\n                    <input type=\"text\" name=\"cnpj\" placeholder=\"CNPJ da empresa\" maxlength=\"40\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1336, "\"", 1371, 1);
#line 26 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml"
WriteAttributeValue("", 1344, Model.Usuario.Empresa.Cnpj, 1344, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1372, 36, true);
                WriteLiteral(" required>\r\n                </div>\r\n");
                EndContext();
#line 28 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml"
            }else
            {

#line default
#line hidden
                BeginContext(1442, 832, true);
                WriteLiteral(@"                <div class=""campo"">
                    <input type=""text"" name=""nome"" placeholder=""Nome"" maxlength=""50"" required>
                </div>
                <div class=""campo"">
                    <input type=""text"" name=""numero"" placeholder=""Número de telefone"" maxlength=""12"" required>
                </div>
                <div class=""campo"">
                    <input type=""email"" name=""email"" maxlength=""50"" id=""email"" placeholder=""Email"" required>
                </div>
                <div class=""campo"">
                    <input type=""text"" name=""empresa"" placeholder=""Empresa"" maxlength=""50"" required>
                </div>
                <div class=""campo"">
                    <input type=""text"" name=""cnpj"" placeholder=""CNPJ da empresa"" maxlength=""40"" required>
                </div>
");
                EndContext();
#line 45 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml"
            }

#line default
#line hidden
                BeginContext(2289, 420, true);
                WriteLiteral(@"            <div class=""campo"">
                <input type=""text"" name=""assunto"" placeholder=""Assunto"" maxlength=""50"" required>
            </div>
            <div class=""campo"">
                <input type=""textarea"" name=""mensagem"" maxlength=""500"" id=""mensagem"" placeholder=""Deixe aqui sua mensagem"" required>
            </div>
            <input type=""submit"" value=""Enviar Mensagem"" class=""submit"">
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 10 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Comentario\CadastrarComentario.cshtml"
AddHtmlAttributeValue("", 293, Url.Action("CadastrarComentario","Comentario"), 293, 47, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2716, 21, true);
            WriteLiteral("\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigital_final.ViewModels.ComentarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\46735197879\Desktop\lucas\mvc_web\Ex2\Views\Usuario\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0906312e61133b04775df5d9f29e64dd4458774d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Editar), @"mvc.1.0.view", @"/Views/Usuario/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Editar.cshtml", typeof(AspNetCore.Views_Usuario_Editar))]
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
#line 1 "C:\Users\46735197879\Desktop\lucas\mvc_web\Ex2\Views\Usuario\Editar.cshtml"
using Ex2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0906312e61133b04775df5d9f29e64dd4458774d", @"/Views/Usuario/Editar.cshtml")]
    public class Views_Usuario_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\46735197879\Desktop\lucas\mvc_web\Ex2\Views\Usuario\Editar.cshtml"
  
    Layout = "MasterPage";
    ViewBag.Title = "Editar usuário";
    UsuarioModel usuario = ViewBag.Usuario;
    string dataDeNascimento = usuario.DataNascimento.ToString("yyyy-MM-dd");

#line default
#line hidden
            BeginContext(219, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(224, 13, false);
#line 9 "C:\Users\46735197879\Desktop\lucas\mvc_web\Ex2\Views\Usuario\Editar.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(237, 81, true);
            WriteLiteral("</h1>\r\n\r\n<form action=\"/Usuario/Editar\" method =\"POST\">\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 318, "\"", 337, 1);
#line 12 "C:\Users\46735197879\Desktop\lucas\mvc_web\Ex2\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 326, usuario.Id, 326, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(338, 77, true);
            WriteLiteral(" name=\"id\">\r\n    \r\n    <label for=\"nome\">Nome</label>\r\n    <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 415, "\"", 436, 1);
#line 15 "C:\Users\46735197879\Desktop\lucas\mvc_web\Ex2\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 423, usuario.Nome, 423, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(437, 77, true);
            WriteLiteral(" name=\"nome\">\r\n\r\n    <label for=\"email\">Email</label>\r\n    <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 514, "\"", 536, 1);
#line 18 "C:\Users\46735197879\Desktop\lucas\mvc_web\Ex2\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 522, usuario.Email, 522, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(537, 79, true);
            WriteLiteral(" name =\"email\">\r\n\r\n    <label for=\"senha\">Senha</label>\r\n    <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 616, "\"", 638, 1);
#line 21 "C:\Users\46735197879\Desktop\lucas\mvc_web\Ex2\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 624, usuario.Senha, 624, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(639, 101, true);
            WriteLiteral(" name =\"senha\">\r\n\r\n    <label for=\"datanascimento\">Data de Nascimento</label>\r\n    <input type=\"date\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 740, "\"", 765, 1);
#line 24 "C:\Users\46735197879\Desktop\lucas\mvc_web\Ex2\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 748, dataDeNascimento, 748, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(766, 77, true);
            WriteLiteral(" name =\"datanascimento\">\r\n\r\n    <input type=\"submit\" value=\"Editar\">\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
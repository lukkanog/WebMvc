#pragma checksum "c:\Users\USER\Desktop\WebMvc\PontoDigital_final\Views\Home\QuemSomos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8ab0d82713fa9d2ae00ca6ce41228a04ae3eb9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QuemSomos), @"mvc.1.0.view", @"/Views/Home/QuemSomos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/QuemSomos.cshtml", typeof(AspNetCore.Views_Home_QuemSomos))]
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
#line 1 "c:\Users\USER\Desktop\WebMvc\PontoDigital_final\Views\_ViewImports.cshtml"
using PontoDigital_final;

#line default
#line hidden
#line 2 "c:\Users\USER\Desktop\WebMvc\PontoDigital_final\Views\_ViewImports.cshtml"
using PontoDigital_final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ab0d82713fa9d2ae00ca6ce41228a04ae3eb9f", @"/Views/Home/QuemSomos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a12cf24a622b5515d7b44a1d5000cf1eb2c499a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_QuemSomos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/apple.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo da empresa Agora Vai"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/equipe.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Equipe de desenvolvedores do Ponto Digital"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Equipe de desenvolvedores do Ponto Digital"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "c:\Users\USER\Desktop\WebMvc\PontoDigital_final\Views\Home\QuemSomos.cshtml"
  
    ViewData["Title"] = "Quem Somos | Ponto Digital";
    ViewData["css"] = "quemsomos-style.css";

#line default
#line hidden
            BeginContext(108, 302, true);
            WriteLiteral(@"<main class=""container"">
        <div class=""content"">
            <h2>Quem Somos</h2>
        </div>
        <section class=""agora-vai container"">
            <div class=""agora-vai content textbox"">
                <h3>Agora Vai</h3>
                    <div class=""flex"">
                    ");
            EndContext();
            BeginContext(410, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b597f5486e2342628811430f29135de2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(469, 2351, true);
            WriteLiteral(@"
                    <p>A Agora Vai é uma empresa focada no desenvolvimento de soluções de tecnologia da informação, tendo como diferencial a facilidade de uso de seus produtos.
                    <br><br>
                    Formada por especialistas de larga vivência nas áreas de gestão do conhecimento, arquitetura da informação, usabilidade e soluções web, sua equipe conta com profissionais especializados em Python, Zope  e Plone, reconhecidos pelas comunidades de programadores de todo o mundo.
                    <br><br>
                    Desde a especificação de um projeto até os ajustes finais de desempenho de um servidor, a Simples Consultoria possui expertise técnica e prática em todas as etapas necessárias para o desenvolvimento de projetos web para a sua empresa, de intranets a portais.  
                    <br><br>
                    Em seu portfólio, estão softwares conhecidos, como o Drello e o Dacebook, além de mais de outros 50 soluções oferecidas com o objetivo de facilitar o trab");
            WriteLiteral(@"alho em equipe em empresas.</p>
                </div>
            </div>
        </section>
        <section class=""visao container"">
            <div class=""visao content textbox"">
                <h3>Visão</h3>
                <p>Ser a produtora de softwares mais admirada do mundo – a referência global no setor.</p>
            </div>
        </section>
        <section class=""missao container"">
            <div class=""missao content textbox"">
                <h3>Missão</h3>
                <p>Ser líder inquestionável no setor de Softwares para empresas.</p>
            </div>
        </section>
        <section class=""valores container"">
            <div class=""valores content textbox"">
                <h3>Valores</h3>
                <ul>
                    <li>Ética</li>
                    <li>Transparência</li>
                    <li>Qualidade</li>
                    <li>Inovação</li>
                    <li>Lealdade institucional</li>
                    <li>Respeito ao cl");
            WriteLiteral(@"iente</li>
                    <li>Preservação do meio ambiente</li>
                </ul>
            </div>
        </section>
        <section class=""equipe container"">
            <div class=""equipe content textbox"">
                <h3>Desenvolvedores do Ponto Digital</h3>
                ");
            EndContext();
            BeginContext(2820, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca6d53f6764a43fa81af0fa85f93d36b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2948, 53, true);
            WriteLiteral("\r\n            </div>\r\n        </section>\r\n    </main>");
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

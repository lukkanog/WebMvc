using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital_final.Models;
using PontoDigital_final.Repositories;
using PontoDigital_final.ViewModels;

namespace PontoDigital_final.Controllers
{
    public class ComentarioController : Controller
    {
        ComentarioRepository comentarioRepositorio = new ComentarioRepository();
        UsuarioRepository usuarioRepositorio = new UsuarioRepository();
        private const string  SESSION_EMAIL = "_EMAIL";
        private const string SESSION_USUARIO = "_USUARIO";

        [HttpGet]
        public IActionResult CadastrarComentario()
        {
            var usuario = usuarioRepositorio.ObterUsuario(HttpContext.Session.GetString(SESSION_EMAIL));
            ComentarioViewModel cvm = new ComentarioViewModel();
            if (usuario!=null)
            {
                cvm.Usuario = usuario;
            } else 
            {
                cvm.Usuario = null;    
            }
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return View(cvm);
        }

        [HttpPost]
        public IActionResult CadastrarComentario(IFormCollection form)
        {
            Comentario comentario = new Comentario();
            comentario.Assunto = form["assunto"];
            comentario.Mensagem = form["mensagem"];
            
            comentario.Autor = new Usuario();
            comentario.Autor.Nome = form["nome"];
            comentario.Autor.Telefone = form["telefone"];
            comentario.Autor.Email = form["email"];

            comentario.Autor.Empresa = new Empresa();
            comentario.Autor.Empresa.Nome = form["empresa"];
            comentario.Autor.Empresa.Cnpj = form["cnpj"];

            comentarioRepositorio.Inserir(comentario);
            return RedirectToAction("Sucesso");
        }     
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital_final.Models;
using PontoDigital_final.Repositories;

namespace PontoDigital_final.Controllers
{
    public class ComentarioController : Controller
    {
        ComentarioRepository comentarioRepositorio = new ComentarioRepository();
        [HttpGet]
        public IActionResult CadastrarComentario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarComentario(IFormCollection form)
        {
            Comentario comentario = new Comentario();
            comentario.Assunto = form["assunto"];
            comentario.Mensagem = form["mensagem"];

            comentarioRepositorio.Inserir(comentario);
            return RedirectToAction("Sucesso");
        }     
    }
}
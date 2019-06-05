using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital_final.Models;
using PontoDigital_final.Repositories;

namespace PontoDigital_final.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioRepository usuarioRepositorio = new UsuarioRepository();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(IFormCollection form)
        {
            if (!form["senha"].Equals(form["confirmarsenha"]))
            {
                TempData["Mensagem"] = "Por favor, confirme sua senha corretamente.";
                return RedirectToAction("Index","Usuario");
            } else
            {
                Usuario usuario = new Usuario();
                usuario.Nome = form["nome"];
                usuario.Telefone = form["telefone"];
                usuario.Email = form["email"];
                usuario.Endereco = form["endereco"];
                usuario.DataNascimento = DateTime.Parse(form["data-nascimento"]);
                usuario.Senha = form["senha"];

                Empresa empresa = new Empresa();
                empresa.Nome = form["empresa"];
                empresa.Cnpj = form["cnpj"];

                usuario.Empresa = empresa;

                usuarioRepositorio.Inserir(usuario);
            }
            return RedirectToAction ("Index","Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FazerLogin(IFormCollection form)
        {
            var email = form["email"];
            var senha = form["senha"];

            var usuario = usuarioRepositorio.TentarLogin(email,senha);
            if (usuario != null)
            {
                
            }
            return RedirectToAction("Index","Home");
        }




    }
}
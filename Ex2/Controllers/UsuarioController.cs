using System;
using Ex2.Models;
using Ex2.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex2.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        //esse "metodo" é apenas para leitura, nao para capturar informações (httpget)
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form)
        {
            UsuarioModel usuario = new UsuarioModel
            (
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento: DateTime.Parse(form["datanascimento"])
            );//BOB O CONSTRUTOR DE USUARIO

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Cadastrar(usuario);

            TempData["mensage"] = "Usuário cadastrado com sucesso!";
            return RedirectToAction("Listar");
        }//action Cadastrar

        [HttpGet]
        public IActionResult Listar()
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.Listar();
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuarioRetornado = usuarioRepositorio.BuscarPorId(id);
            if (usuarioRetornado != null)
            {
                ViewBag.usuario = usuarioRetornado;
            }else
            {
                TempData["mensagem"] = $"Deu ruim cz, usuário nao encontrado";
                return RedirectToAction("Listar");
            }
            return View();

        }//Editar()

        [HttpPost]
        public IActionResult Editar(IFormCollection form)
        {
            UsuarioModel usuario = new UsuarioModel
            (
                id: int.Parse(form["id"]),
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento: DateTime.Parse(form["datanascimento"])
            );
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Editar(usuario);

            TempData["mensagem"] = "Usuário editado com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        
        public IActionResult Excluir(int id)
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Excluir(id);

            TempData["mensagem"] = "Usuário excluído com sucesso!";
            return RedirectToAction("Listar");
        }
    }    
}
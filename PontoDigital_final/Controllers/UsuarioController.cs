using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital_final.Models;
using PontoDigital_final.Repositories;
using PontoDigital_final.ViewModels;

namespace PontoDigital_final.Controllers
{
    public class UsuarioController : Controller
    {
        private const string  SESSION_EMAIL = "_EMAIL";
        private const string SESSION_USUARIO = "_USUARIO";
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
                // TempData["erro"] = "Por favor, confirme sua senha corretamente.";
                ErroViewModel erroViewModel = new ErroViewModel();
                erroViewModel.Mensagem = "Por favor, confirme sua senha corretamente.";
                erroViewModel.LinkVoltar = "/Usuario/Index";
                return View("Erro",erroViewModel);

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

                
                //FOTO
                // var fotinha = form["foto"];

                // if (usuario.Foto != null && usuario.Foto.Length > 0)
                // {
                //     var fileName = Path.GetFileName (usuario.Foto.FileName);
                //     var NomeArquivo = Guid.NewGuid ().ToString ().Replace ("-", "") + Path.GetExtension (fileName);
                //     var CaminhoArquivo = Path.Combine (Directory.GetCurrentDirectory (), "wwwroot\\uploads\\imgs", NomeArquivo);

                
                //     using (var StreamImagem = new FileStream (CaminhoArquivo, FileMode.Create)) 
                //     {
                //         usuario.Foto.CopyTo(StreamImagem);
                //     }

                //     usuario.UrlFoto = "/uploads/imgs/"+NomeArquivo;
                // }                                                            *****ARRUMA ESSA PORRA AQUI VAI TOMAR NO CU PQP**** 
                
                
                bool emailJaExiste = usuarioRepositorio.VerificarEmailExistente(usuario.Email);

                if (!emailJaExiste)
                {
                    usuarioRepositorio.Inserir(usuario);
                    return RedirectToAction ("Index","Home");
                } else
                {
                    ErroViewModel erroViewModel = new ErroViewModel();
                    erroViewModel.Mensagem = "Esse email já está sendo utilizado.";
                    erroViewModel.LinkVoltar = "/Usuario/Index/";
                    // TempData["erro"] = "Esse email já está sendo utilizado.";
                    // TempData["voltar"] = "";
                    return View("Erro",erroViewModel);
                }

            }
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
                string[] usuarioNomes = usuario.Nome.Split(" ");
                string primeiroNome = usuarioNomes[0];
                HttpContext.Session.SetString(SESSION_EMAIL, email);
                HttpContext.Session.SetString(SESSION_USUARIO, primeiroNome);
                return RedirectToAction("Index","Home");
            } else {
                // TempData["erro"] = "Email ou senha inválidos";
                ErroViewModel erroViewModel = new ErroViewModel();
                erroViewModel.Mensagem =  "Email ou senha inválidos";
                erroViewModel.LinkVoltar = "/Usuario/Login/";
                return View("Erro",erroViewModel);
            }
        }

        [HttpGet]
        public IActionResult FazerLogout()
        {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_USUARIO);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult ExibirPerfil()
        {
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Usuario = usuarioRepositorio.ObterUsuario(HttpContext.Session.GetString(SESSION_EMAIL));
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return View(usuarioViewModel);
        }

        [HttpGet]
        public IActionResult EditarPerfil()
        {
            var usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Usuario = usuarioRepositorio.ObterUsuario(HttpContext.Session.GetString(SESSION_EMAIL));
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return View(usuarioViewModel);
        }   
        

        [HttpPost]
        public IActionResult EditarPerfil(IFormCollection form)
        {
            Usuario usuarioAntigo = usuarioRepositorio.ObterUsuario(HttpContext.Session.GetString(SESSION_EMAIL));
            Usuario usuario = new Usuario();

            usuario.Nome = form["nome"];
            usuario.Telefone = form["telefone"];
            usuario.Email = form["email"];
            usuario.Endereco = form["endereco"];

            if (string.IsNullOrEmpty(form["data-nascimento"]))
            {
                usuario.DataNascimento = usuarioAntigo.DataNascimento;
            } else
            {
                usuario.DataNascimento = DateTime.Parse(form["data-nascimento"]);
            }
            
            Empresa empresa = new Empresa();
            empresa.Nome = form["empresa"];
            empresa.Cnpj = form["cnpj"];

            usuario.Empresa = empresa;

            usuarioRepositorio.EditarUsuario(usuarioAntigo,usuario);
            // return RedirectToAction("ExibirPerfil","Usuario");
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return RedirectToAction("ExibirPerfil","Usuario");
        }

        public IActionResult Erro()
        {
            // ErroViewModel evm = new ErroViewModel();
            // var mensagem = TempData["ErroMensagem"];
            // evm.Mensagem = (string)mensagem;
            // return View(evm);
            // TempData.Keep("erro");
            return View();
        } 






    }/////////////////////////////////////////////////////////*****FIM*****////////////////////////////////////////////////////////////////////////////
}
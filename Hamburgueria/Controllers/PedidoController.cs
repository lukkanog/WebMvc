using System;
using Hamburgueria.Models;
using Hamburgueria.Repositorios;
using Hamburgueria.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria.Controllers
{
    public class PedidoController : Controller
    {
        PedidoRepositorio pedidoRepositorio = new PedidoRepositorio();
        HamburguerRepositorio hamburguerRepositorio = new HamburguerRepositorio();
        ShakeRepositorio shakeRepositorio = new ShakeRepositorio();

        [HttpGet]
        public IActionResult Index()
        {
            var hamburgueres = hamburguerRepositorio.Listar();
            var shakes = shakeRepositorio.Listar();

            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Hamburgueres = hamburgueres;
            pedido.Shakes = shakes;
            return View(pedido);
        }


        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form)
        {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereço"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["hamburguer"]);
            System.Console.WriteLine(form["shake"]);
            System.Console.WriteLine();

            //Instanciação do objeto - Forma 1
            Pedido pedido = new Pedido();
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;

            //Instanciação do objeto - Forma 2 (pede geração de um construtor)
            Hamburguer hamburguer = new Hamburguer(
                Nome: form["hamburguer"],
                Preco: hamburguerRepositorio.ObterPrecoDe(form["hamburguer"])
            );

            //Instanciação do objeto - Forma 3 (resumo da forma 1)
            Shake shake = new Shake() {
                Nome = form["shake"],
                Preco = shakeRepositorio.ObterPrecoDe(form["shake"])
            };

            pedido.Hamburguer = hamburguer;
            pedido.Shake = shake;
            pedido.DataPedido = DateTime.Now;
            pedido.PrecoTotal = pedido.Hamburguer.Preco + pedido.Shake.Preco;

            pedidoRepositorio.Inserir(pedido);
            
            ViewData["controller"] = "Pedido";
            ViewData["precoTotal"] = pedido.PrecoTotal;
            return View("Sucesso");
        }
    }//end of the world
}
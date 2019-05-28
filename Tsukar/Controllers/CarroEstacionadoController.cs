using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tsukar.Models;
using Tsukar.Repositorios;
using Tsukar.ViewModels;

namespace Tsukar.Controllers
{
    public class CarroEstacionadoController : Controller
    {
        CarroEstacionadoRepositorio carroRepositorio = new CarroEstacionadoRepositorio();
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();

        [HttpGet]
        public IActionResult Index()
        {
            var carros = carroRepositorio.Listar();
            var modelos = modeloRepositorio.Listar();
            var marcas = marcaRepositorio.Listar();

            CarroEstacionadoViewModel carroViewModel = new CarroEstacionadoViewModel();
            carroViewModel.Modelos = modelos;
            carroViewModel.Marcas = marcas; 
            @ViewData["modelos"] = modelos;
            @ViewData["marcas"] = marcas;
            return View(carroViewModel);
        }

        
        [HttpPost]
        public IActionResult RegistrarCarro(IFormCollection form)
        {
            CarroEstacionado carroEstacionado = new CarroEstacionado();
            carroEstacionado.NomeCondutor = form["nomeCondutor"];
            carroEstacionado.Placa = form["placa"];
            
            var marca = new Marca();
            marca.Nome = form["marca"];

            var modelo = new Modelo();
            modelo.Nome = form["modelo"];
            modelo.Marca = marca;

            carroEstacionado.Modelo = modelo;
            carroEstacionado.Marca = marca;
            carroEstacionado.DataEntrada = DateTime.Now;

            carroRepositorio.Inserir(carroEstacionado);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ListarCarros()
        {
            @ViewData["Carros"] = carroRepositorio.Listar();
            return View();
        }
    }
}
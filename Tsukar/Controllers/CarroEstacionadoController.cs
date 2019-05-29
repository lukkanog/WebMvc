using System;
using System.Collections.Generic;
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


        // [HttpPost]
        // public IActionResult FiltrarResultados(IFormCollection form)
        // {
        //     var listaFiltrada = carroRepositorio.Filtrar(
        //         DateTime.Parse(form["data"]),
        //         form["modelo"]
        //     );
        //     ViewData["Carros"] = listaFiltrada;
        //     this.listaCarros = listaFiltrada;
        //     return RedirectToAction("ListarCarros");
        // }

        [HttpGet]
        public IActionResult ListarCarros(List<CarroEstacionado> listaDeCarros)
        {
            // var listaDeCarros = carroRepositorio.Listar();
            if (listaDeCarros.Count == 0)
            {
                ViewData["mensagem"] = "Não há carros estacionados no TsuCar no momento.";
                return RedirectToAction("Index");
            }
            ViewData["Carros"] = listaDeCarros;
            @ViewData["modelos"] = modeloRepositorio.Listar();
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(string placa)
        {
            CarroEstacionadoRepositorio carroRepositorio = new CarroEstacionadoRepositorio();
            carroRepositorio.Excluir(placa);

            return RedirectToAction("ListarCarros");
        }
    }
}
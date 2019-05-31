using System;
using System.Collections.Generic;
using System.IO;
using Tsukar.Models;

namespace Tsukar.Repositorios
{
    public class CarroEstacionadoRepositorio
    {
        private const string PATH = "DataBase/CarrosEstacionados.csv";
        //O CONST DIZ Q ESSA STRING NAO É UMA VARIAVEL, SEU VALOR É SEMPRE O MEMO(CONSTANTE)
        public void Inserir(CarroEstacionado carro)
        {
            // if (!File.Exists(PATH))
            // {
            //     carro.Id = 1;
            // } else
            // {
            //     carro.Id = File.ReadAllLines(PATH).Length + 1;
            // }                                                                         ***** COMENTADO PQ NO MEU N TEM ID FODASE*****

            StreamWriter sw = new StreamWriter(PATH,true);
            sw.WriteLine($"{carro.Placa.ToUpper()};{carro.NomeCondutor.ToUpper()};{carro.Modelo.Nome};{carro.Marca.Nome};{carro.DataEntrada}");
            sw.Close();
        }

        private List<CarroEstacionado> CarrosEstacionados = new List<CarroEstacionado>();
        public List<CarroEstacionado> Listar()
        {
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                if(string.IsNullOrEmpty(item))
                {
                    continue;
                }
                
                string[] dados = item.Split(";");
                var carro = new CarroEstacionado();
                var modelo = new Modelo();
                var marca = new Marca();
                carro.Modelo = modelo;
                carro.Marca = marca;

                carro.Placa = dados[0];
                carro.NomeCondutor = dados[1];
                modelo.Nome = dados[2];
                marca.Nome = dados[3];
                carro.DataEntrada = DateTime.Parse(dados[4]);

                this.CarrosEstacionados.Add(carro);
            }
            return this.CarrosEstacionados;
        }

        public void Excluir(string placa)
        {
            string[] linhas = File.ReadAllLines(PATH);

            for (int i=0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");
                if (placa.Equals(linha[0]))
                {
                    linhas[i] ="";
                    break;
                }
            }
            File.WriteAllLines(PATH,linhas);
        }

        public List<CarroEstacionado> Filtrar(DateTime data)
        {
            var listaFiltrada = new List<CarroEstacionado>();
            var listaDeCarros = Listar();
            
            foreach (var item in listaDeCarros)
            {
                if (item.DataEntrada.ToShortDateString() == data.ToShortDateString())
                {
                    listaFiltrada.Add(item);
                } else
                {
                    continue;
                }
            }
            
            return listaFiltrada;
        }

        public List<CarroEstacionado> Filtrar(string modelo)
        {
            var listaFiltrada = new List<CarroEstacionado>();
            var listaDeCarros = Listar();
            
            foreach (var item in listaDeCarros)
            {
                if (item.Modelo.Nome.Equals(modelo))
                {
                    listaFiltrada.Add(item);
                } else
                {
                    continue;
                }
            }
            
            return listaFiltrada;
        }

        public List<CarroEstacionado> Filtrar(DateTime data,string modelo)
        {
            var listaFiltrada = new List<CarroEstacionado>();
            var listaDeCarros = Listar();
            
            foreach (var item in listaDeCarros)
            {
                if (item.DataEntrada.ToShortDateString() == data.ToShortDateString() && item.Modelo.Nome.Equals(modelo))
                {
                    listaFiltrada.Add(item);
                } else
                {
                    continue;
                }
            }
            
            return listaFiltrada;
        }
    }//end of the world


}
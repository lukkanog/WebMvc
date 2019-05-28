using System;
using System.Collections.Generic;
using System.IO;
using Tsukar.Models;

namespace Tsukar.Repositorios
{
    public class CarroEstacionadoRepositorio
    {
        private string PATH = "DataBase/CarrosEstacionados.csv";
        public void Inserir(CarroEstacionado carro)
        {
            StreamWriter sw;
            if (!File.Exists(PATH))
            {
                sw = new StreamWriter(PATH,true);
            } else
            {
                sw = new StreamWriter(PATH,false);
            }
                sw.WriteLine($"{carro.Placa.ToUpper()};{carro.NomeCondutor};{carro.Modelo.Nome};{carro.Marca.Nome};{carro.DataEntrada}");
                sw.Close();
        }

        private List<CarroEstacionado> CarrosEstacionados = new List<CarroEstacionado>();
        public  List<CarroEstacionado> Listar()
        {
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
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
    }
}
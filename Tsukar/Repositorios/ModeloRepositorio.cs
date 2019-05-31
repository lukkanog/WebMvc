using System.Collections.Generic;
using System.IO;
using Tsukar.Models;

namespace Tsukar.Repositorios
{
    public class ModeloRepositorio
    {
        private const string PATH = "DataBase/Modelos.csv";
        private List<Modelo> Modelos = new List<Modelo>();
        public List<Modelo> Listar()
        {
            string[] modelos = File.ReadAllLines(PATH);
            foreach (var item in modelos)
            {
                if (item != null)
                {

                string[] dados = item.Split(";");
                
                var modelo = new Modelo();

                modelo.Id = int.Parse(dados[0]);
                modelo.Nome = dados[1];
                

                this.Modelos.Add(modelo);
                }else
                {
                    System.Console.WriteLine("DEU RUIM CARAIO");
                }
            }
            return this.Modelos;
        }
    }
}
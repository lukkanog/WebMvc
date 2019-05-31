using System.Collections.Generic;
using System.IO;
using Tsukar.Models;

namespace Tsukar.Repositorios
{
    public class MarcaRepositorio
    {
        private const string PATH = "DataBase/Marcas.csv";
        private List<Marca> Marcas = new List<Marca>();
        public List<Marca> Listar()
        {
            string[] marcas = File.ReadAllLines(PATH);

            foreach (var item in marcas)
            {
                string[] dados = item.Split(";");
                var marca = new Marca();

                marca.Id = int.Parse(dados[0]);
                marca.Nome = dados[1];

                this.Marcas.Add(marca);
            }
            return this.Marcas;
        }
    }
}
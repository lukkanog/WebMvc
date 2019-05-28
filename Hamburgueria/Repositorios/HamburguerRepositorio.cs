using System.Collections.Generic;
using System.IO;
using Hamburgueria.Models;

namespace Hamburgueria.Repositorios
{
    public class HamburguerRepositorio
    {
        private const string PATH = "DataBase/Hamburguer.csv";
        //o const evita q essa variavel seja modificada depois//
        private List<Hamburguer> Hamburgueres = new List<Hamburguer>();

        public List<Hamburguer> Listar()
        {
            var registros = File.ReadAllLines(PATH);
            
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                var hamburguer = new Hamburguer();

                hamburguer.Nome = valores[1];
                hamburguer.Preco = double.Parse(valores[2]);
                
                this.Hamburgueres.Add(hamburguer);
            } 

            return this.Hamburgueres;
            //RETORNA A LISTA LA DE CIMA FORA DO METODO TLG CZ//
        }

        public double ObterPrecoDe(string nomeHamburguer)
        {
            var lista = Listar();
            var preco = 0.00;

            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeHamburguer))
                {
                    preco = item.Preco;
                }
            }

            return preco;
        }
    }
}
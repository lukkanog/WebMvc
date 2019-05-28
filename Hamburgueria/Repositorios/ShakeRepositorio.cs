using System;
using System.Collections.Generic;
using System.IO;
using Hamburgueria.Models;
using Microsoft.Extensions.Primitives;

namespace Hamburgueria.Repositorios
{
    public class ShakeRepositorio
    {
        private const string PATH = "DataBase/Shake.csv";
        //o const evita q essa variavel seja modificada depois//
        private List<Shake> Shakes = new List<Shake>();

        public List<Shake> Listar()
        {
            var registros = File.ReadAllLines(PATH);
            
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                var shake = new Shake();

                shake.Nome = valores[1];
                shake.Preco = double.Parse(valores[2]);
                
                this.Shakes.Add(shake);
            } 

            return this.Shakes;
            //RETORNA A LISTA LA DE CIMA FORA DO METODO TLG CZ//
        }

        public double ObterPrecoDe(string nomeShake)
        {
            var lista = Listar();
            var preco = 0.00;

            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeShake))
                {
                    preco = item.Preco;
                }
            }

            return preco;
        }
    }
}
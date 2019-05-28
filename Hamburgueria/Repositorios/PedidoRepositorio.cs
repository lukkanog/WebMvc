using System;
using System.Collections.Generic;
using System.IO;
using Hamburgueria.Models;

namespace Hamburgueria.Repositorios
{
    public class PedidoRepositorio
    {
        private List<Pedido> pedidos = new List<Pedido>();
        private string path = "Database/Pedidos.csv";
        public bool Inserir(Pedido pedido)
        {
            try{
                if (!File.Exists(path))
                {
                    File.Create(path).Close();                
                }
                var linha = $"{pedido.Id};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.Hamburguer.Nome};{pedido.Hamburguer.Preco};{pedido.Shake.Nome};{pedido.Shake.Preco};{pedido.PrecoTotal};{pedido.DataPedido}";

                File.AppendAllText(path,linha+"\n");
            
            } catch (Exception e){
                System.Console.WriteLine("Entrou no catch");
                System.Console.WriteLine(e.StackTrace);
            }
            

            return true;
        }//Inserir()
    }
}
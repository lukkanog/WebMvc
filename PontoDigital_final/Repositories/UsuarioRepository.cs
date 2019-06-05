using System;
using System.Collections.Generic;
using System.IO;
using PontoDigital_final.Models;

namespace PontoDigital_final.Repositories
{
    public class UsuarioRepository
    {
        private const string PATH = "Database/usuarios.csv";
        public void Inserir(Usuario usuario)
        {
            if (!File.Exists(PATH))
            {
                usuario.Id = 1;
            } else 
            {
                usuario.Id = File.ReadAllLines(PATH).Length;
            }
            string linha = $"{usuario.Id};{usuario.Nome.ToUpper()};{usuario.Endereco.ToUpper()};{usuario.DataNascimento.ToShortDateString()}{usuario.Email};{usuario.Senha};{usuario.Empresa.Nome};{usuario.Empresa.Cnpj}";
            
            StreamWriter sw = new StreamWriter(PATH,true);
            sw.WriteLine(linha);
            sw.Close();
        }

        public List<Usuario> Listar()
        {
            var listaDeUsuarios = new List<Usuario>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }

                string[] dados = item.Split(";");
                Usuario usuario = new Usuario();
                usuario.Id = int.Parse(dados[0]);
                usuario.Nome = dados[1];
                usuario.Endereco = dados[2];
                usuario.DataNascimento = DateTime.Parse(dados[3]);
                usuario.Email =dados[4];
                usuario.Senha = dados[5];

                Empresa empresa = new Empresa();
                empresa.Nome = dados[6];
                empresa.Cnpj = dados[7];

                usuario.Empresa = empresa;
                listaDeUsuarios.Add(usuario);
            }
            return listaDeUsuarios;
        }

        public Usuario TentarLogin(string email, string senha)
        {
            Usuario usuario;
            var listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios)
            {
                if (item == null)
                {
                    continue;
                }

                if (email.Equals(item.Email) && senha.Equals(item.Senha))
                {
                    usuario = item;
                    return usuario;
                } 
            }
            return null;
        }
    }
}
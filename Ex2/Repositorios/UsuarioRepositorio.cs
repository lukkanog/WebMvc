using System;
using System.Collections.Generic;
using System.IO;
using Ex2.Models;

namespace Ex2.Repositorios
{
    public class UsuarioRepositorio
    {
        public UsuarioModel Cadastrar(UsuarioModel usuario)
        {   
            if (File.Exists("usuarios.csv"))
            {
                usuario.Id = File.ReadAllLines("usuarios.csv").Length+1;
                //se o arquivo existir, vai contar quantas linhas tem e adicionar mais um tendeu
            } else
            {
                usuario.Id = 1;
            }

            StreamWriter sw = new StreamWriter("usuarios.csv",true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento:dd/MM/yyyy}");
            sw.Close();
            return usuario;
        }//cadastrar()

        public List<UsuarioModel> Listar()
        {
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
            string[] linhas = File.ReadAllLines("usuarios.csv");
            UsuarioModel usuario;

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }

                string[] linha = item.Split(";");

                usuario = new UsuarioModel(
                    id: int.Parse(linha[0]),
                    nome: linha[1],
                    email: linha[2],
                    senha: linha[3],
                    dataNascimento: DateTime.Parse(linha[4])
                );

                listaDeUsuarios.Add(usuario);
            }//forítti
            return listaDeUsuarios;
        }
        public UsuarioModel BuscarPorId(int id)
        {
            string[] linhas = File.ReadAllLines("usuarios.csv");

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");

                if (id.ToString().Equals(linha[0]))
                {
                    UsuarioModel usuario = new UsuarioModel(
                        id: int.Parse(linha[0]),
                        nome: linha[1],
                        email: linha[2],
                        senha: linha[3],
                        dataNascimento: DateTime.Parse(linha[4])
                    );
                    return usuario;
                }
            }
            return null;
        }//BuscarPorId()
        public void Editar(UsuarioModel usuario)
        {
            string[] linhas = File.ReadAllLines("usuarios.csv");

            for (int i=0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");
                if (usuario.Id.ToString().Equals(linha[0]))//////////////////////////
                {
                    linhas[i] = $"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento:dd/MM/yyyy}";
                    break;
                }
            }
            File.WriteAllLines("usuarios.csv",linhas);
        }//Editar()

        public void Excluir(int id)
        {
             string[] linhas = File.ReadAllLines("usuarios.csv");

            for (int i=0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");
                if (id.ToString().Equals(linha[0]))
                {
                    linhas[i] ="";
                    break;
                }
            }
            File.WriteAllLines("usuarios.csv",linhas);
        }
    }
}
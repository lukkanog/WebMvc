using System;
using System.IO;
using PontoDigital_final.Models;

namespace PontoDigital_final.Repositories
{
    public class ComentarioRepository
    {
        private const string PATH = "Database/Comentarios.csv";
        public void Inserir(Comentario comentario)
        {
            if (!File.Exists(PATH))
            {
                comentario.Id = 1;
            } else 
            {
                comentario.Id = File.ReadAllLines(PATH).Length;
            }

            comentario.DataDoComentario = DateTime.Now;

            string linha = $"{comentario.Id};{comentario.DataDoComentario};{comentario.Assunto};{comentario.Mensagem};{comentario.Autor.Nome};{comentario.Autor.Telefone};{comentario.Autor.Email};{comentario.Autor.Empresa.Nome};{comentario.Autor.Empresa.Cnpj}";
            
            StreamWriter sw = new StreamWriter(PATH,true);
            sw.WriteLine(linha);
            sw.Close();
        }
    }
}
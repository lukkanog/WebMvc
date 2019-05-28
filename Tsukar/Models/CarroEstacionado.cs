using System;

namespace Tsukar.Models
{
    public class CarroEstacionado
    {
        public string NomeCondutor {get;set;}
        public Marca Marca {get;set;}
        public Modelo Modelo {get;set;}
        public string Placa {get;set;}
        public DateTime DataEntrada {get;set;}

    }
}
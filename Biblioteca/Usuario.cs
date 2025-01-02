using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        public string Nome {get;set;}
        public string Cpf {get;set;}
        
        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}
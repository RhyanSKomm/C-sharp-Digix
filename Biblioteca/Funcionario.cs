using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Funcionario : Usuario
    {
        public string Cargo {get;set;}

        public Funcionario(string nome,string cpf, string cargo) : base(nome, cpf)
        {
            Cargo = cargo;
        }

    }
}
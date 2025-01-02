using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class Professor
    {
        public string Nome {get;set;}

        public Professor(string nome)
        {
            Nome = nome;
        }

        public void Ensinar()
        {
            System.Console.WriteLine($"Professor: {Nome}");
        }
    }
}
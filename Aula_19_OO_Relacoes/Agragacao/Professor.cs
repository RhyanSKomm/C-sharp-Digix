using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Relacoes.Agragacao
{
    public class Professor
    {
        public string Nome;
        
        public Professor(string nome)
        {
            Nome = nome;
        }

        public void ensinar()
        {
            System.Console.WriteLine("Professor "+ Nome + " está ensinando.");
        }
    }
}
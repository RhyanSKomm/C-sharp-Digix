using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class Aluno
    {
        public string Nome {get;set;}

        public Aluno(string nome)
        {
            Nome = nome;
        }        

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome: {Nome}");
        }
    }
}
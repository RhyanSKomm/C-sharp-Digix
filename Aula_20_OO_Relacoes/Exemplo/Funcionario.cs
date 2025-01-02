using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes_Exercicio
{
    public class Funcionario
    {
        public string Nome;
        public DateTime Nascimento;
        public string Cpf;
        public Endereco Endereco;

        public Funcionario(string nome, DateTime nascimento, string cpf, Endereco endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
            Endereco = endereco;
        }

        public void GetNome()
        {
            System.Console.WriteLine(Nome);
        }

        public void GetNascimento()
        {
            System.Console.WriteLine(Nascimento);
        }

        public void GetCpf()
        {
            System.Console.WriteLine(Cpf);
        }

        public void GetEnderecos()
        {
            System.Console.WriteLine(Endereco);
        }
    }
}
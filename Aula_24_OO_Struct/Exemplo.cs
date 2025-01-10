using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_Struct
{
    public struct PessoaStruct
    {
        public string Nome {get;set;}
        public int Idade {get;set;}

        public PessoaStruct (string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
    public class PessoaClass
    {
        public string Nome {get;set;}
        public int Idade {get;set;}

        public PessoaClass (string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

    class ExecutarE
    {
        static void Main(string[] args)
        {
            PessoaStruct pessoaStruct1 = new PessoaStruct("João", 20);
            PessoaStruct pessoaStruct2 = pessoaStruct1;
            pessoaStruct2.Nome = "Maria";

            System.Console.WriteLine(pessoaStruct1);
            System.Console.WriteLine(pessoaStruct2);
            
            
            PessoaStruct pessoaClasse1 = new PessoaStruct("João", 20);
            PessoaStruct pessoaClasse2 = pessoaClasse1;
            pessoaStruct2.Nome = "Maria";

            System.Console.WriteLine(pessoaClasse1);
            System.Console.WriteLine(pessoaClasse2);

        }
    }
}
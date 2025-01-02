using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_01_02_25
{
    public class Pessoa
    {
        protected string nome;
        protected string cpf;

        public Pessoa(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
    }
}
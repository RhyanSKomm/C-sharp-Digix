using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes_Exercicio
{
    public class Vendedor : Funcionario
    {
        public EquipeVenda Equipevenda {get;set;}

        public Vendedor(string nome, DateTime nascimento, string cpf,Endereco endereco,EquipeVenda equipeVenda) : base(nome,nascimento,cpf, endereco)
        {
            Equipevenda = equipeVenda;
        }

        public float GetSalario()
        {
            return 1;
        }
    }
}
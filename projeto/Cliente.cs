using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string CartaoFidelidade { get; set; }
        public double TotalGasto { get; set; }

        public Cliente(string nome, string endereco, string telefone, string cartaoFidelidade, double TotalGasto){
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            CartaoFidelidade = cartaoFidelidade;
            TotalGasto = TotalGasto;
            
        }
    }
}
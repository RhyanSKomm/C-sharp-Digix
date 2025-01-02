using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; } 

        public Fornecedor(string nome, string cnpj, string endereco)
        {
            Nome = nome;
            Cnpj = cnpj;
            Endereco = endereco;
        }
    }
}    
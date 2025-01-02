using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class FornecedorRecorrente : Fornecedor
    {
        public double Desconto { get; set; }
        public FornecedorRecorrente(double desconto, string nome, string cnpj, string endereco) : base( nome, cnpj, endereco)
        {
            Desconto = desconto;
        }

    }
}    
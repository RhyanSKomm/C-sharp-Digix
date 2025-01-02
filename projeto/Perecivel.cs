using System;

namespace Padaria{
    public class ProdutoPerecivel : Produto
    {
        public DateTime DataValidade { get; set; }

        public ProdutoPerecivel (string nome, string codigo, double precoCusto, double precoFinal, DataTime dataValidade) : base(nome, codigo, precoCusto, precoFinal)
        {
            DataValidade = dataValidade;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class CartaoCredito : IPagamento, IAnuidade
    {
        public string NumeroCartao{get; set;}
        public DateTime DataVencimento { get; set;}
        public double ValorAnuidade { get; set;}

        public CartaoCredito(string numeroCartao, DateTime dataVencimento, double valorAnuidade)
        {
            NumeroCartao = numeroCartao;
            DataVencimento = dataVencimento;
            ValorAnuidade = valorAnuidade;
        }

        public void RealizarPagamento(double valor)
        {
            System.Console.WriteLine($"Pagamento de R${valor} realizado com sucesso!");
        }

        public void ExibirComprovante()
        {
            System.Console.WriteLine($"Comprovante de pagamento com o cartão {NumeroCartao}");
        }

        public DateTime CalcularDataVencimento()
        {
            return DateTime.Now.AddYears(1);
        }

        public double CalcularValorAnuidade()
        {
            return 100;
        }
    }
}
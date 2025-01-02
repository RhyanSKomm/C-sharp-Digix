using System;

namespace Padaria{
    public class Produto{
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoFinal { get; set; }

        Dictionary<string,string> = new Dictionary<string,string>();

        public Produto(string nome, string codigo, double precoCusto, double precoFinal){
            Nome = nome;
            Codigo = codigo;
            PrecoCusto = precoCusto;
            PrecoFinal = precoFinal;
            
        }
    }
}
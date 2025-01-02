using System;

namespace Name
{
    class Padaria
    {
        public string nomeAlimento;

        public double preco;

        public string bebidas;

        public string doces;

        public DateTime datavalidade;

        public string encomenda(){
            return "Encomenda de " + nomeAlimento + " do valor " + preco;
        }

        public double cestaCompras(List<(string nomeAlimento, double preco)> itens){
            double total = 0;

            foreach (var item in itens)
            {
                Console.WriteLine($"Item: {item.nomeAlimento}, Preço: {item.preco}");
                total += item.preco;
            }
            return total;
        }
    }
}
using System.Net.Http.Headers;
using System;
using System.Data;

namespace Name
{
    class Executar
    {
        static void Maina(string[] args)
        {
            // Cachorro cachorro1 = new Cachorro();
            // cachorro1.nome = "Rex";
            // cachorro1.raca = "Rotweiller";
            // cachorro1.idade = 13;

            // cachorro1.escrevaSaida();

            Padaria padaria = new Padaria();

            padaria.nomeAlimento = "Sonho";
            padaria.preco = 7.5;
            padaria.bebidas = "Café";
            padaria.doces = "Bolo de cenoura";
            padaria.datavalidade = DateTime.Now.AddDays(3);

            System.Console.WriteLine(padaria.encomenda());

            List<(string nomeAlimento, double preco)> listasCompras = new List<(string nomeAlimento, double preco)>
            {
                ("Pão Francês", 5.98 ),
                ("Bolo de Cenoura", 20.50 ),
                ("Coxinha", 4.50 ),
                ("Suco Natural", 10.20 ),
            };

            double total = padaria.cestaCompras(listasCompras);
            System.Console.WriteLine($"Total de cestas de compras R${total}");
        }
    }
}
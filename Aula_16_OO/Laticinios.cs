namespace Name
{
    class Laticinios
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public Laticinios()
        {
            Nome = null;
            Preco = 0;
            Quantidade = 0;
        }

        public Laticinios(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public void Carrinho()
        {
            System.Console.WriteLine($"{this.Nome} : R${this.Preco}, qnt:{this.Quantidade}un");
        }

        public double CalcularEstoque()
        {
            return Preco * Quantidade;
        }
    }
}
namespace Name
{
    class Limpeza
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public Limpeza()
        {
            Nome = null;
            Preco = 0;
            Quantidade = 0;
        }

        public Limpeza(string nome, double preco, int quantidade)
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
namespace Name
{
    class Petiscos
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

            
        public Petiscos()
        {
            Nome = null;
            Preco = 0;
            Quantidade = 0;
        }

        public Petiscos(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public void Carrinho()
        {
            System.Console.WriteLine($"{this.Nome} : R${this.Preco}, qnt:{this.Quantidade}g");
        }
        
        public double CalcularEstoque()
        {
            return Preco * Quantidade;
        }
    }
}
namespace Name
{
    class Carnes
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public Carnes()
        {
            Nome = null;
            Preco = 0;
            Quantidade = 0;
        }

        public Carnes(string nome, double preco, int quantidade)
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
namespace Name
{
    class Produto
    {
        public string nome;
        public double preco;

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public Produto()
        {
            this.nome = "Sem Nome";
            this.preco = 0;
        }

        public void exibirInformacoes()
        {
            System.Console.WriteLine("Nome: " + this.nome);
            System.Console.WriteLine("Preco: " + this.preco);
        }

        static void Main(string[] args)
        {
            // Produto p1 = new Produto("Notebook", 2000);
            // p1.exibirInformacoes();

            Produto p2 = new Produto();
            p2.nome = "Celular";
            p2.preco = 1000;
            p2.exibirInformacoes();
        }
    }
}
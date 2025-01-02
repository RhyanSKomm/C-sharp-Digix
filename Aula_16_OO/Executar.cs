namespace Name
{
    class Executar
    {
        static void Main(string[] args)
        {
            Carnes carne = new Carnes("Picanha",119.90,5000);
            Ferramentas ferramenta = new Ferramentas("Faca",9.99,1);
            Laticinios laticinio = new Laticinios("leite",11.98,2);
            Limpeza limpeza = new Limpeza("detergente",13.4,6);
            Petiscos petisco = new Petiscos("tiras de carne",12.95,500);


            carne.Carrinho();
            System.Console.WriteLine(carne.CalcularEstoque());

            ferramenta.Carrinho();
            System.Console.WriteLine(ferramenta.CalcularEstoque());

            laticinio.Carrinho();
            System.Console.WriteLine(laticinio.CalcularEstoque());

            limpeza.Carrinho();
            System.Console.WriteLine(limpeza.CalcularEstoque());

            petisco.Carrinho();
            System.Console.WriteLine(petisco.CalcularEstoque());
            

            double maiorValor = new[] {
                carne.CalcularEstoque(),
                ferramenta.CalcularEstoque(),
                laticinio.CalcularEstoque(),
                limpeza.CalcularEstoque(),
                petisco.CalcularEstoque()
            }.Max();
                        
            System.Console.WriteLine();
            System.Console.WriteLine(maiorValor);
        }
    }
}
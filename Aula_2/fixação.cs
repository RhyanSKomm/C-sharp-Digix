namespace fix
{
    class fix
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite seu Nome Completo: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Quantos quartos tem sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string linha = Console.ReadLine();

            System.Console.WriteLine();

            System.Console.WriteLine(nome);
            System.Console.WriteLine(quartos);
            System.Console.WriteLine(preco);
            System.Console.WriteLine(linha.Replace(" ", "\n"));
        }
    }
}
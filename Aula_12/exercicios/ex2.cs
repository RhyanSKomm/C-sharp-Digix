namespace Name
{
    class ex2
    {
        static int Produto(int n)
        {
            if(n == 1)
                return 1;
            else
                return n * Produto(n-1);
        }

        static void Produto()
        {
            System.Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            System.Console.WriteLine(Produto(n));
        }
    }
}
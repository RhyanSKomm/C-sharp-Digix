namespace Name
{
    class ex4
    {
        static int MDC(int x, int n)
        {
            if(n == 0)
                return x;
            else
                return MDC(n, x % n);
        }
        static void MDC()
        
        {
            Console.Write("Digite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int n = int.Parse(Console.ReadLine());

        

            Console.WriteLine(MDC(x,n));
        }
    }
}
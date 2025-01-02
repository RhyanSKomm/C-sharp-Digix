namespace Name
{
    class ex3
    {
        static double Potencia(int x, int n)
        {
            if (n == 0)
                return 1;
            else
                return x * Potencia(x, n-1);
        }

        static void Potencia()
        {
            Console.Write("Digite a base (x): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente não-negativo (n): ");
            int n = int.Parse(Console.ReadLine());

            if (n<0)
            {
                Console.WriteLine("O expoente deve ser um número inteiro não-negativo.");
            }
            else
            {
                System.Console.WriteLine(Potencia(x,n));
            }
        }
    }
}
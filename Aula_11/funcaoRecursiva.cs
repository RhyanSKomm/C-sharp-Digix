using System.Diagnostics.Contracts;

namespace Name
{
    class FuncaoRecursiva
    {
        static int Pares (int[] vetor, int n)
        {
            if (n==0)
                return 0;
            else if (vetor[n-1] % 2 == 0)
                return vetor[n-1] + Pares(vetor, n-1);
            else
                return Pares(vetor, n - 1);
        }
        static int Impares (int[] vetor, int n)
        {
            if (n==0)
                return 0;
            else if (vetor[n-1] % 2 == 1)
                return vetor[n-1] + Pares(vetor, n-1);
            else
                return Pares(vetor, n - 1);
        }

        static int Fatorial(int n)
        {
            if (n == 0)
                return 1;
            else 
                return n * Fatorial(n-1);
        }

        static int Fibonacci(int n)
        {
            if(n == 0 || n == 1)
                return 1;
            else
                return Fibonacci(n-1) + Fibonacci(n -2);
        }

        static int Fatorial12(int n)
        {
            int fatorial = 1;
            for (int i = 1; i <= n; i++)
                fatorial *= i;
            return fatorial;
        }

        static int Fibonacci12(int n)
        {
            int a = 0, b = 1, c = 1;
            for(int i = 2; i <= n; i++)
            {
                c = a+b;
                a = b;
                b = c;
            }
            return c;
        }

    static void recurcao()
        {
            // int num = int.Parse(Console.ReadLine());
            // System.Console.WriteLine(Fatorial(num));
            // System.Console.WriteLine(Fibonacci(num));

        int[] vetor = {1,2,3,4,5,6,7,8,9,10};
        System.Console.WriteLine(Pares(vetor,vetor.Length));
        System.Console.WriteLine(Impares(vetor,vetor.Length));
        }
    }
}
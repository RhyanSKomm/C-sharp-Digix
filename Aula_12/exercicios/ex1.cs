namespace Name
{
    class Exercicios
    {
        static int Soma(int n){
            if (n == 1)
                return 1;
            else
                return n + Soma(n-1);

        }
        static void Soam()
        {
            Console.Write("Digite um número inteiro n: ");
            int n = int.Parse(Console.ReadLine());
             Console.WriteLine(Soma(n));
        }
    }
}
namespace Exemplo
{
    
    public class Exemplo
    {
        static void Main(string[] args)
        {
            int [] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetor [i] = Random.Shared.Next(1, 100);
            }

            System.Console.WriteLine("Ordem direta: ");
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(vetor[i]);
            }

            System.Console.WriteLine("Ordem inversa");
            for (int i = 9; i >=0; i--)
            {
                System.Console.WriteLine(vetor[i]);
            }
        }
    }
}
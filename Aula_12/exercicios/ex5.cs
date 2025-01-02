namespace Name
{
    class ex5
    {
        static int SomaVetor(int[] vetor, int indice)
        {
            if (indice == vetor.Length)
                return 0;
            else
                return vetor[indice] + SomaVetor(vetor, indice + 1);
        }

        static void SomaVetor()
        {
             Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º elemento: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine(SomaVetor(vetor, 0));
        }
    }
}
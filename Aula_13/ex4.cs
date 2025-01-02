namespace Name
{
    class ex4
    {
        static void Ordenar(int[] vetor)
        {
            int aux, j;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;
                while (j >= 0 && vetor[j] < aux)
                {
                    vetor[j+1] = vetor[j];
                    j--;
                }
                vetor[j+1] = aux;
            }
        }
            
        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.Write(vetor[i] + " ");
            }
                System.Console.WriteLine();
        }
        static void Maino(string[] args)
        {
            System.Console.WriteLine("Digite o tamanho do array");
                int len = int.Parse(Console.ReadLine());

                int[] vetor = new int [len];

                System.Console.WriteLine("Digite os valores: ");
                for (int i = 0; i < vetor.Length; i++)
                {
                    int valor = int.Parse(Console.ReadLine());
                    vetor[i] = valor;
                }


            System.Console.WriteLine("Vetor Desordenado");
            Imprimir(vetor);
            Ordenar(vetor);
            System.Console.WriteLine("Vetor Ordenado");
            Imprimir(vetor);
        }
    }
}
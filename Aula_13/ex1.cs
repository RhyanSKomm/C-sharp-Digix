namespace Name
{
    class ex1
    {
        static void Ordenar(int[] vetor)
            {
                int aux;
                for (int i = 0; i < vetor.Length;i ++)
                {
                    for (int j = 0; j < vetor.Length - 1; j++ )
                    {
                        if (vetor[j] > vetor[j+1])
                        {
                            aux = vetor[j];
                            vetor[j] = vetor[j+1];
                            vetor[j+1] = aux;
                        }
                    }
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

            static void Maina(string[] args)
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
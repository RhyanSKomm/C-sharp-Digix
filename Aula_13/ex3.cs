namespace Name
{
    class ex3
    {
        static void Ordenar(string[] vetor)
                {
                    int menor;
                    string aux;
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        menor = i;
                        for (int j = i + 1; j < vetor.Length; j++)
                        {
                            if (vetor[j].CompareTo(vetor[menor]) < 0)
                            {
                                menor = j;
                            }
                        }
                            aux = vetor[i];
                            vetor[i] = vetor[menor];
                            vetor[menor] = aux;
                    }
                }
            
            static void Imprimir(string[] vetor)
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    System.Console.WriteLine();
                    System.Console.Write(vetor[i] + ", ");
                }
                System.Console.WriteLine();
            }
            static void Maini(string[] args)
            {
                
                System.Console.WriteLine("Digite o tamanho do array");
                int len = int.Parse(Console.ReadLine());

                string[] vetor = new string [len];

                System.Console.WriteLine("Digite os nomes: ");
                for (int i = 0; i < vetor.Length; i++)
                {
                    string valor = Console.ReadLine();
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
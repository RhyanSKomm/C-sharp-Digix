using System;
using System.Diagnostics;

namespace Name
{
    class ex5
    {
        
        static void OrdenarMerge(int[] vetor, int inicio, int fim)
        {
            if (inicio > fim)
            {
                int meio = (inicio + fim) / 2;
                Ordenar(vetor, inicio, meio);
                Ordenar(vetor, meio + 1, fim);
                Intercalar(vetor, inicio, meio, fim);
            }
        }
        
        static void Intercalar(int[] vetor, int inicio, int meio, int fim)
        {
            int[] aux = new int[vetor.Length];
            for (int j = inicio; j <= fim; j++)
            {
                aux[j] = vetor[j];
            }
            int i1 = inicio;
            int i2 = meio + 1;
            int i3 = inicio;

            while (i1 <= meio && i2 <= fim)
            {
                if (aux[i1] < aux[i2])
                {
                    vetor[i3] = aux[i1];
                    i1++;
                }
                else
                {
                    vetor[i3] = aux[i2];
                    i3++;
                }
                i3++;
                }
                while (i1 <= meio)
                {
                    vetor[i3] = aux[i1];
                    i1++;
                    i3++;;
                }
            }
        
        
        
        
        static void OrdenarBubble(int[] vetor)
            {
                int aux;
                for (int i = 0; i < vetor.Length;i ++)
                {
                    for (int j = 0; j < vetor.Length - 1; j++ )
                    {
                        if (vetor[j] < vetor[j+1])
                        {
                            aux = vetor[j];
                            vetor[j] = vetor[j+1];
                            vetor[j+1] = aux;
                        }
                    }
                }
            }

        static void OrdenarSelection(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] > vetor[menor])
                    {
                        menor = j;
                    }
                }
                    aux = vetor[i];
                    vetor[i] = vetor[menor];
                    vetor[menor] = aux;
            }
        }

        static void OrdenarInsertion(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] > vetor[menor])
                    {
                        menor = j;
                    }
                }
                    aux = vetor[i];
                    vetor[i] = vetor[menor];
                    vetor[menor] = aux;
            }
        }


        static void Main(string[] args)
        {
            int[] vetor = new int[1000];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                vetor[i] = random.Next(1, 101);
            }


            // Criar copias para cada algoritmo
            int[] bubleArray = (int[])vetor.Clone();
            int[] selectionArray = (int[])vetor.Clone();
            int[] insertionArray = (int[])vetor.Clone();
            int[] MergeArray = (int[])vetor.Clone();
            


            // Mede o tempo de execução do BubbleSort
            var inicio = DateTime.Now.Ticks; // Pega o tempo atual em ticks
            OrdenarBubble(bubleArray);
            var tempoBubble = DateTime.Now.Ticks - inicio; // Pega o tempo atual em ticks

            // Mede o tempo de execução do SelectionSort
            inicio = DateTime.Now.Ticks; // Pega o tempo atual em ticks
            OrdenarSelection(selectionArray);
            var tempoSelection = DateTime.Now.Ticks - inicio; // Pega o tempo atual em ticks

            // Mede o tempo de execução do InsertionSort
            inicio = DateTime.Now.Ticks; // Pega o tempo atual em ticks
            OrdenarInsertion(insertionArray);
            var tempoInsertion = DateTime.Now.Ticks - inicio; // Pega o tempo atual em ticks
            
            
            inicio = DateTime.Now.Ticks; // Pega o tempo atual em ticks
            OrdenarMerge(MergeArray);
            var tempoMerge = DateTime.Now.Ticks - inicio; // Pega o tempo atual em ticks



            string melhorAlgoritmo;
            int[] melhorArray;

            if (tempoBubble < tempoSelection && tempoBubble < tempoInsertion)
            {
                melhorAlgoritmo = "BubbleSort";
                melhorArray = bubleArray;
            }
            else if (tempoSelection < tempoBubble && tempoSelection < tempoInsertion)
            {
                melhorAlgoritmo = "SelectionSort";
                melhorArray = selectionArray;
            }
            else
            {
                melhorAlgoritmo = "InsertionSort";
                melhorArray = insertionArray;
            }

            // Exibe os tempos de execução
            Console.WriteLine($"Tempo de execução do BubbleSort: {tempoBubble}");
            Console.WriteLine($"Tempo de execução do SelectionSort: {tempoSelection}");
            Console.WriteLine($"Tempo de execução do InsertionSort: {tempoInsertion}");
            Console.WriteLine($"Tempo de execução do MergeSort: {tempoMerge}");
            Console.WriteLine($"O melhor algoritmo foi o {melhorAlgoritmo}");
        }
    }
}
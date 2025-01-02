namespace Name
{
    class QuickSort
    {

        static void Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio > fim)
            {
                int p = Particionar(vetor, inicio, fim);
                Ordenar(vetor, inicio, p-1);
                Ordenar(vetor, p+1, fim);
            }
        }

        static int Particionar(int[] vetor, int inicio, int fim)
        {
            int pivo = vetor[fim];
            int i = inicio -1;
            for(int j = 0; j < fim; j++)
            {
                if (vetor[j] < pivo)
                {

                
                int aux = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = aux;
            
            }
            }
            int aux2 = vetor[i + 1];
            vetor[i+1] = vetor[fim];
            vetor[fim] = aux2;
            return i + 1;
        }


        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.WriteLine(vetor[i] + "");
            }
                System.Console.WriteLine();
        }
        static void Quick()
        {
            int[] vetor = {3,1,5,7,3,4};
            System.Console.WriteLine("Vetor Desordenado");
            Imprimir(vetor);
            Ordenar(vetor, 0, vetor.Length);
            System.Console.WriteLine("Vetor Ordenado");
            Imprimir(vetor);
        }
    }
}
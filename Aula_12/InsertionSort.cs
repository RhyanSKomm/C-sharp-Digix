namespace Aula_11
{
    class InsertionSort
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
        static void Main(string[] args)
        {
            int[] vetor = {3,1,5,7,3,4};
            System.Console.WriteLine("Vetor Desordenado");
            Imprimir(vetor);
            Ordenar(vetor);
            System.Console.WriteLine("Vetor Ordenado");
            Imprimir(vetor);
        }
    }
}
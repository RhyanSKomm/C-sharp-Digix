using System;

namespace Aula_9
{
    
    class Program
    {
        
        static int soma(int a, int b){
            return a+b;
        }

        static int somaVetor(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma;
        }

        static int somaMatriz(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz [i, j];
                }
            }
            return soma;
        }

        static void program()
        {
            int a = 10;
            int b = 20;
            int resultado0 = soma(a,b);
            System.Console.WriteLine($"A soma de {a} + {b} é {resultado0}");

            int[] vetor = {1,2,3,4,5};
            int resultado1 = somaVetor(vetor);
            System.Console.WriteLine($"O resultado da soma do vetor é: {resultado1}");

            int [,] matriz = new int [3, 3]{
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            int resultado2 = somaMatriz(matriz);
            System.Console.WriteLine($"O resultado da soma da matriz é: {resultado2}");
        }
    }
}
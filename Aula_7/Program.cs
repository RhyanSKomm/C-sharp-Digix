using System;

namespace ExemploMatriz;
class Program
{
    static void Mainerro()
    {
        // Formas de declarar uma matriz
        int[,] matriz1 = new int[2, 3]; // 2 linhas e 3 colunas
        int[,] matrizInicializada = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

        // Acessando elementos da matriz
        Console.WriteLine(matrizInicializada[0, 0]); // 1
        Console.WriteLine(matrizInicializada[1, 2]); // 6
        


        // Percorrendo a matriz
        for (int i = 0; i < matrizInicializada.GetLength(0); i++) // getLength(0) retorna o número de linhas, tem o 0 pois é a primeira dimensão
        {
            for (int j = 0; j < matrizInicializada.GetLength(1); j++) // getLength(1) retorna o número de colunas, tem o 1 pois é a segunda dimensão
            {
                Console.Write(matrizInicializada[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Somando todos os elementos da matriz
        int[,] matrizA = { { 1, 2 }, { 3, 4 } };
        int[,] matrizB = { { 5, 6 }, { 7, 8 } };
        int[,] resultado = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultado[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }

        // Exibindo o resultado
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(resultado[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Transposição de Matrizes
        int[,] matriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
        int[,] transposta = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                transposta[i, j] = matriz[j, i];
            }
        }

        // Ver o resultado
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(transposta[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
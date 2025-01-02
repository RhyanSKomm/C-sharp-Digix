namespace exercicios
{
    internal class exercicios
    {
        static void Main(string[] args)
        {
//             //              EX1
//             // int [] ex1 = new int []{0,1,2,3,4,5,6,7,8,9};
//             // foreach (var i in ex1)
//             // {
//             //     System.Console.WriteLine(i);
//             // }
//             // for (int i = ex1.Length -1; i >= 0; i--)
//             // {
//             //     System.Console.WriteLine(ex1[i]);
//             // }



//             //             EX2
            int [] nums = new int[10];
            for (int i = 0; i<10; i++){
                System.Console.WriteLine("Digite 10 números: ");
                nums [i] = int.Parse(Console.ReadLine());  
            }
            int maior = nums [0];
            int menor = nums [0];
            for (int i = 1; i < nums.Length; i++){
                if (nums[i] > maior){
                    maior = nums[i];
                }
                if (nums[i] < menor){
                    menor = nums [i];
                }
            }
            System.Console.WriteLine($"Maior:{maior}");
            System.Console.WriteLine($"Menor:{menor}");



//             //              EX3
//             // int[,] m1 = {
//             //     { 1, 2, 3, 4}
//             //     { 5, 6, 6, 8}
//             //     { 9, 10, 11, 12}
//             //     {13, 14, 15, 16}
//             // };
//             // int maior = m1[0][0]
//             // int menor = m1[0][0]
//             // for (int i = 0; i < length; i++)
//             // {
//             //     for (int j = 0; j < length; i++)
//             //     {
//             //         if (m1[i][j] > maior)
//             //         {
//             //             maior = m1[i][j]
//             //         }
//             //         if (m1[i][j] < menor)
//             //         {
//             //             menor = m1[i][j]
//             //         }
//             //     }
//             // }
//             // System.Console.WriteLine(maior);
//             // System.Console.WriteLine(menor);



//             //              EX4
//             // int[,] m1 = {
//             //     { 1, 2, 3, 4},
//             //     { 5, 6, 6, 8},
//             //     { 9, 10, 11, 12},
//             //     {13, 14, 15, 16},
//             // };
//             // int sum = 0;
//             // for (int i = 0; i < m1.GetLength(0); i++)
//             // {
//             //     sum += m1[i, i];
//             // }   
//             // System.Console.WriteLine(sum);



//             //              EX5
//             // int[,] matrizA = {
//             //     { 1, 2, 3, 4 },
//             //     { 5, 6, 7, 8 },
//             //     { 9, 10, 11, 12 },
//             //     { 13, 14, 15, 16 }
//             // };
//             // int[,] matrizB = {
//             //     { 17, 18, 19, 20 },
//             //     { 21, 22, 23, 24 },
//             //     { 25, 26, 27, 28 },
//             //     { 29, 30, 31, 32 }
//             // };
//             // int somaA = 0
//             // int somaB = 0
//             // for (int i = 0; i < matrizA.GetLength(0); i++)
//             // {
//             //     for ( int j = 0; j < matrizA.GetLength(1); j++)
//             //     {
//             //         somaA += matrizA[i,j]
//             //     }
//             // }
//             // for (int i = 0; i < matrizB.GetLength(0); i++)
//             // {
//             //     for ( int j = 0; j < matrizB.GetLength(1); j++)
//             //     {
//             //         somaB += matrizB[i,j]
//             //     }
//             // }
//             // System.Console.WriteLine(somaA + somaB);



//             //              EX6
//             // int[,] matrizA = {
//             //     { 2, 1, 2, 3 },
//             //     { 4, 5, 1, 2 },
//             //     { 3, 4, 1, 1 },
//             //     { 2, 3, 4, 5 }
//             // };
//             // int[,] matrizB = {
//             //     { 3, 4, 2, 2 },
//             //     { 2, 1, 2, 3 },
//             //     { 1, 5, 1, 3 },
//             //     { 2, 1, 1, 1 }
//             // };
//             // long multA = 1;
//             // long multB = 1;
//             // for (int i = 0; i < matrizA.GetLength(0); i++)
//             // {
//             //     for ( int j = 0; j < matrizA.GetLength(1); j++)
//             //     {
//             //         multA *= matrizA[i,j];
//             //     }
//             // }
//             // for (int i = 0; i < matrizB.GetLength(0); i++)
//             // {
//             //     for ( int j = 0; j < matrizB.GetLength(1); j++)
//             //     {
//             //         multB *= matrizB[i,j];
//             //     }
//             // }
//             // System.Console.WriteLine(multA * multB);
        }
    }
}
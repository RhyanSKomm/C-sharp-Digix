namespace exercicio
{
    class fixacao
    {
        static void Main(string[] args)
        {
            
            int [] vetor = new int [10];
            int sum = 0;
            System.Console.WriteLine("Digite 10 números: ");
            for (int i = 0; i < 10; i++)
            {    
                vetor[i] = int.Parse(Console.ReadLine());
                sum += vetor[i]
            }
            
            System.Console.WriteLine(${sum/10});



             int[,] m1 = {
                { 1, 2, 3, 4},
                { 5, 6, 6, 8},
                { 9, 10, 11, 12},
                {13, 14, 15, 16},
            };
            int sum = 0;
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                sum += m1[i, i];
            }   
            System.Console.WriteLine(sum);



            int[] vetorInteiros = { 1, 2, 3, 3, 2, 1 };
            int[] invetor = new int[vetorInteiros.Length];

            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                invetor[i] = vetorInteiros[vetorInteiros.Length - 1 - i];
            }
            
            bool pal = true;
            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                if (invetor[i] != vetorInteiros[i])
                {
                    pal = false;
                    break; 
                }
            }

            System.Console.WriteLine(pal ? "palíndromo" : "não é palíndromo");




            int sum1 = 0;
            int sum2 = 0;

            int[,] matriz = new int[4, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sum1 += matriz[i, i];
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sum2 += matriz[i, matriz.GetLength(1) - 1 - i];
            }

            System.Console.WriteLine($"Soma da diagonal principal: {sum1}, Soma da diagonal secundária: {sum2}");




            int [,] matriz = new int [3, 3]{
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            int[,] transposta = new int[3,3];
            int[,] transposta2 = new int[3,3];

            for (int i = 0; i < matriz.GetLength(0); i++){
                for (int j = 0; j < matriz.GetLength(1); j++){
                    transposta [j, i] = matriz [i, j];
                }
            }

            for (int i = 0; i < transposta.GetLength(0); i++){
                for (int j = 0; j < transposta.GetLength(1); j++){
                    transposta2 [j, i] = transposta [i, matriz.GetLength(0) -1 -j];
                }
            }

            foreach (int i in transposta){
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine();
        }
    }
}
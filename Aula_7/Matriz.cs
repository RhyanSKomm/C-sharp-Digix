namespace ExemploMatriz
{
    public class Matriz
    {
        static void exemplo()
        {
            int [,] matriz = new int [3, 3]{
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            int[,] transposta = new int[3,3];

            for (int i = 0; i < matriz.GetLength(0); i++){
                for (int j = 0; j < matriz.GetLength(1); j++){
                    transposta [j, i] = matriz [i, j];
                }
            }

            for (int i = 0; i < transposta.GetLength(0); i++){
                for (int j = 0; j < transposta.GetLength(1); j++){
                    System.Console.WriteLine(transposta[i,j]+" ");
                }
            }
            System.Console.WriteLine();




            
        }
    }
}
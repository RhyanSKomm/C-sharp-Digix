namespace Aula_9_5
{
    
    public class exercicio
    {

        public delegate int[,] Rotar(int[,] valores);

        static int[,] Rotano(int[,] valores){
            int[,] transposta = new int[3,3];
            for (int i = 0; i < valores.GetLength(0); i++){
                for (int j = 0; j < valores.GetLength(1); j++){
                    transposta [j, i] = valores [i, j];
                }
            }
            return transposta;
        }

         static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Rotar rotação = Rotano;
            
           int [,] matriz = new int [3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            ImprimirMatriz(rotação(matriz));
        }
    }
}
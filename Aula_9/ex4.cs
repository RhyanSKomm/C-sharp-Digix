namespace Aula_9_4
{
    
    public class exercicio
    {

        public delegate double Diagonal(int[,] valores);

        static double Soma(int[,] valores){
            int sum = 0;
            for (int i = 0; i < valores.GetLength(0); i++)
            {
                sum += valores[i,i];
            }
            return sum;
        }
        

        static void ex4()
        {
            Diagonal somaDiagonal = Soma;
            int [,] matriz = new int [3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            System.Console.WriteLine(somaDiagonal(matriz));
        }
    }
}
namespace Aula_9_2
{
    
    public class exercicio
    {

        public delegate double somaMatriz(int[,] valores);

        static double Soma(int[,] valores){
            int soma = 0;
            foreach (var i in valores)
            {
                soma += i;
            }
            return soma;
        }
        

        static void somaDaMatriz()
        {
            somaMatriz soma = Soma;

            int [,] matriz = new int [3, 3]{
                {1,2,3},
                {4,5,6},
                {7,8,9}
        };
        System.Console.WriteLine(soma(matriz));
    }
}
}
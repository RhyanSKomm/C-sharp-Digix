namespace Aula_9
{
    
    public class exercicio
    {

        public delegate double calcularMedia(int[] valores);

        static double Media(int[] valores){
            double media = 0;
            foreach (var i in valores)
            {
                media += i;
            }
            return media / valores.Length;
        }
        static void media()
        {
            calcularMedia media = Media;

            int [] vetor = new int[10];
            
            System.Console.WriteLine("Digite 10 números: ");
            for(int i = 0; i<10; i++)
            {
               int n = int.Parse(Console.ReadLine());
               vetor[i] = n;
            }
            
            System.Console.WriteLine(media(vetor));
            
        }
    }
}
namespace Aula_9_3
{
    
    public class exercicio
    {

        public delegate bool verificar(int[]vetor1, int[]vetor2);

        static bool palindromo(int[] vetor1, int[] vetor2){
            for (int i = 0; i < vetor1.Length; i++)
            {
                if(vetor1[i] != vetor2[i]){
                    return false;
                }    
            }
             return true;
        }
        

        static void palin()
        {
            verificar verificar = palindromo;
            
            int [] vetor = new int[5];
            int [] invetor = new int[vetor.Length];

            System.Console.WriteLine("Digite 5 números: ");
            for(int i = 0; i<5; i++)
            {
               int n = int.Parse(Console.ReadLine());
               vetor[i] = n;
            }

            for(int i = 0; i<5; i++)
            {
                invetor[i] = vetor[vetor.Length -1 - i];
            }

            if(verificar(vetor,invetor)){
                 Console.WriteLine("Palíndromo");
            } else
            {
                Console.WriteLine("Não é Palíndromo");
            }
        }
    }
}
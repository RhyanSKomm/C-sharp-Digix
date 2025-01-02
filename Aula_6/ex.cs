namespace Exercicio1
{
    internal class Exercicio1
    {
        static void ex1()
        {
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
        }
    }
}
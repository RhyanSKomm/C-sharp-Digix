using System;

namespace Aula_9
{
    class Program
    {
        static int ParOuImpar(int num)
        {
            if (num % 2 == 0){
                return 0;
            } else {
                return 1;
            }
        }

        static string ParOuImpar(double num)
        {
            if (num % 2 == 0){
                return "Par";
            } else {
                return "Impar";
            }
        }

        
        static void Pi()
        {
            System.Console.WriteLine("3.14");
        }


        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Numero é: " + ParOuImpar(num));

            Pi();
        }
    }
}
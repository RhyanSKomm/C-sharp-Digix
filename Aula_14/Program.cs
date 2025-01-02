using System.Collections.Specialized;

namespace Name
{
    class Program
    {
        public class Lista
        {
            static int[] vetor = new int[10];

            //Metodo Inserir
            static void Inserir(int valor)
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] == 0)
                    {
                        vetor[i] = valor;
                        break;
                    }
                }
            }
        

            static void Remover(int valor)
            {
                for (int i = 0; i < vetor.Length; i++)
                {   
                    if (vetor[i] == valor)
                    {
                        vetor[i] = 0;
                        break;
                    }
                }
            }
            static void Listar()
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] != 0)
                    {
                        System.Console.WriteLine(vetor[i]);
                    }
                }
                System.Console.WriteLine();
            }

            static void Lista_Inversa()
            {
                for (int i = vetor.Length - 1; i > 0; i--)
                {
                    if (vetor[i] != 0)
                    {
                        System.Console.WriteLine(vetor[i]);
                    }
                }    
                System.Console.WriteLine();
            }

            static void Maina(string[] args)
            {
                Inserir(70);
                Inserir(50);
                Inserir(80);
                Inserir(90);
                Inserir(100);
                Listar();
                System.Console.WriteLine("Listar Inverso: ");
                Lista_Inversa();
                Remover(50);
                System.Console.WriteLine("Listar após remover o 50: ");
                Listar();
            }   
        }
    }
}
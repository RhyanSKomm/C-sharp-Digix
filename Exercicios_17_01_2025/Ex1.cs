using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_17_01_2025
{
    public class Ex1
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Dada uma matriz NxM");
            System.Console.WriteLine("Digite N: ");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite M: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,m];
            Random rand = new Random();
             for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rand.Next(1, 100); 
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    System.Console.WriteLine();
                    Console.Write(matriz[i, j] + "\t");  
                }
                Console.WriteLine(); 
            }

            while (true)
            {
                System.Console.WriteLine("\n1-Soma das linhas\n3-Soma das colunas\n3-Trasnpor a Matriz\n4-Sair");
                int op = int.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        string somaLinhas = "somaLinhas.csv";
                        
                        using (StreamWriter sw = new StreamWriter(somaLinhas))
                        {
                            sw.WriteLine("Linha,Soma");

                            for (int i = 0; i < n; i++)  
                            {
                                int soma = 0;
                            
                                for (int j = 0; j < m; j++)  
                                {
                                    soma += matriz[i, j]; 
                                }

                                sw.WriteLine($"  {i} ,  {soma}");
                            }
                        }
                        break;
                    
                    case 2:
                        string somaColuna = "somaColunas.csv";

                        using(StreamWriter sw = new StreamWriter(somaColuna))
                        {
                            sw.WriteLine("Coluna,Soma");

                            for (int j = 0; j < m; j++)
                            {
                                int soma = 0;

                                for (int i = 0; i < n; i++)
                                {
                                    soma += matriz [i,j];
                                }

                                sw.WriteLine($"  {j} ,  {soma}");
                            }
                        }
                        break;
                    
                    case 3:
                        int[,] matrizTransposta = new int[m,n];

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                matrizTransposta[j,i] = matriz[i,j];
                            }
                        }

                        string matrizTrans = "matrizTransposta.csv";
                        using(StreamWriter sw = new StreamWriter(matrizTrans))
                        {
                            for (int i = 0; i < m; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    sw.Write(matrizTransposta[i,j]);
                                    if (j < n - 1)  
                                    {
                                        sw.Write(",");
                                    }
                                }
                                sw.WriteLine();
                            }
                        }
                        break;
                    case 4:
                     return;
                }
            }
        }
    }
}
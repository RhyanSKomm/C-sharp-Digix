using System;

namespace desafio
{
    class Program
    {

        static void ExibirDados(int[,,] valores)
        {
            for (int i = 0; i < valores.GetLength(0); i++)
            {
                System.Console.WriteLine($"========== Departamento {i + 1} ==========");
                System.Console.WriteLine();
                for (int j = 0; j < valores.GetLength(1); j++)
                {
                    System.Console.WriteLine($"             Trimestre {j + 1}" + " ");
                    for (int k = 0; k < valores.GetLength(2); k++)
                    {
                        System.Console.WriteLine($"Mês {k + 1}: {valores[i, j, k]}");
                        System.Console.WriteLine();
                    }
                }
            }
        }


        static int[] SomaDp(int[,,] valores)
        {
            int sum = 0;

            int[] vetorDp = new int[5];


            for (int i = 0; i < valores.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < valores.GetLength(1); j++)
                {
                    for (int k = 0; k < valores.GetLength(2); k++)
                    {
                        sum += valores[i, j, k];
                        vetorDp[i] = sum;
                    }
                }
            }
            return vetorDp;
        }


        static void Milior(int[] ia)
        {
            int maior = 0;
            int dp = 0;


            for (int i = 0; i < ia.Length; i++)
            {
                if (ia[i] > maior)
                {
                    maior = ia[i];
                    dp = i + 1;
                }
            }
            System.Console.WriteLine($"Departamento com maior vendas foi o departamento {dp}");
        }



        static void Main(string[] args)
        {


            int[,,] Analise = new int[5, 4, 3]
            {
                {
                    {100, 150, 200},
                    {120, 160, 210},
                    {130, 170, 220},
                    {140, 180, 230}
                },
                {
                    {90, 140, 190},
                    {110, 150, 200},
                    {120, 160, 210},
                    {130, 170, 220}
                },
                {
                    {200, 250, 300},
                    {220, 270, 320},
                    {240, 290, 340},
                    {260, 310, 360}
                },
                {
                    {80, 130, 180},
                    {90, 140, 190},
                    {100, 150, 200},
                    {110, 160, 210}
                },
                {
                    {150, 200, 250},
                    {170, 220, 270},
                    {190, 240, 290},
                    {210, 260, 310}
                }
            };
            int[] dps = SomaDp(Analise);
            bool cases = true;



            while (cases)
            {
                System.Console.WriteLine("Digite a opção:\n1 - Exibir Dados\n2 - Vendas no ano\n3 - Departamento que mais vendeu\n0 - Sair");
                int op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        ExibirDados(Analise);
                        break;

                    case 2:
                        foreach (var i in dps)
                        {
                            System.Console.WriteLine(i);
                        }
                        break;

                    case 3:
                        Milior(dps);
                        break;

                    case 0:
                        cases = false;
                        break;
                    default:
                        System.Console.WriteLine("Opcão Inválida.");
                        break;
                }
            }
        }
    }
}
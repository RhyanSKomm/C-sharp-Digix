﻿using  System;

namespace Desaio2
{
    class desafio
    {
        static void MostrarClienteQueMaisComprou(object[,] transacoes)
        {
            Dictionary<string, double> gastosPorCliente = new Dictionary<string, double>();

            for (int i = 0; i < transacoes.GetLength(0); i++)
            {
                string cliente = (string)transacoes[i, 0];
                double valor = (double)transacoes[i, 1];

                if (gastosPorCliente.ContainsKey(cliente))
                {
                    gastosPorCliente[cliente] += valor;
                }
                else
                {
                    gastosPorCliente[cliente] = valor;
                }
            }

            string clienteMax = null;
            double valorMax = 0;

            foreach (var cliente in gastosPorCliente)
            {
                if (cliente.Value > valorMax)
                {
                    valorMax = cliente.Value;
                    clienteMax = cliente.Key;
                }
            }

            Console.WriteLine($"\nCliente que mais gastou: {clienteMax}");
            Console.WriteLine($"Valor total gasto: R${valorMax:F2}");
        }

        static void BuscaCategoria(string categoria, object[,] matriz)
        {
            System.Console.WriteLine($"\nTransações da categoria {categoria}\n");
            for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
            {
                if(categoria == (string)matriz[i, 4])
                {
                    System.Console.WriteLine($"\n{matriz[i, 0]}: R${matriz[i, 1]:F2}");
                }
            }
        }
        static void CalculaCategoria(object[,] matriz)
        {
            double[] categoria = new double[5];
            int toy = 0, make = 0, eletro = 0, book = 0, clothes = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                switch ((string)matriz[i, 4])
                {
                    case "Brinquedos":
                        categoria[0] += (double)matriz[i, 1];
                        toy++;
                        break;
                    case "Cosméticos":
                        categoria[1] += (double)matriz[i, 1];
                        make++;
                        break;
                    case "Eletrônicos":
                        categoria[2] += (double)matriz[i, 1];
                        eletro++;
                        break;
                    case "Livros":
                        categoria[3] += (double)matriz[i, 1];
                        book++;
                        break;
                    case "Roupas":
                        categoria[4] += (double)matriz[i, 1];
                        clothes++;
                        break;
                     
                    default:
                        break;
                }      
            }
            System.Console.WriteLine($"\nValor total Brinquedos: R${categoria[0]:F2}\tMédia: R${categoria[0]/toy:F2}\tVendas: {toy}");
            System.Console.WriteLine($"\nValor total Cosméticos: R${categoria[1]:F2}\tMédia: R${categoria[1]/make:F2}\tVendas: {make}");
            System.Console.WriteLine($"\nValor total Eletrônico: R${categoria[2]:F2}\tMédia: R${categoria[2]/eletro:F2}\tVendas: {eletro}");
            System.Console.WriteLine($"\nValor total Livros    : R${categoria[3]:F2}\tMédia: R${categoria[3]/book:F2}\tVendas: {book}");
            System.Console.WriteLine($"\nValor total Roupas    : R${categoria[4]:F2}\tMédia: R${categoria[4]/clothes:F2}\tVendas: {clothes}\n");
        }

        static bool Alfabetica(string nome1, string nome2)
        {
            int tamanho = Math.Min(nome1.Length, nome2.Length);
            for (int i = 0; i < tamanho; i++)
            {
                if(nome1[i] > nome2[i])
                {
                    return true;
                } else if(nome1[i] < nome2[i]) 
                {
                    return false;
                }
            }
            return nome1.Length < nome2.Length;
        }
         static void Ordernar(object[,] vetor)
        {
            for (int i = 0; i < vetor.GetLength(0); i++)
            {
                for (int j = 0; j < vetor.GetLength(0) - 1; j++)
                {
                    if((double)vetor[j,1] < (double)vetor[j+1,1])
                    {
                        // aux = vetor[j];
                        // vetor[j] = vetor[j+1];
                        // vetor[j+1] = aux;

                        (vetor[j, 0], vetor[j, 1], vetor[j, 2], vetor[j, 3], vetor[j, 4], vetor[j+1, 0], vetor[j+1, 1], vetor[j+1, 2], vetor[j+1, 3], vetor[j+1, 4]) = (vetor[j+1, 0], vetor[j+1, 1], vetor[j+1, 2], vetor[j+1, 3], vetor[j+1, 4], vetor[j, 0], vetor[j, 1], vetor[j, 2], vetor[j, 3], vetor[j, 4]);
                    } else if((double)vetor[j,1] == (double)vetor[j+1,1]) {
                        if(Alfabetica((string)vetor[j,0], (string)vetor[j+1,0])){
                            (vetor[j, 0], vetor[j, 1], vetor[j, 2], vetor[j, 3], vetor[j, 4], vetor[j+1, 0], vetor[j+1, 1], vetor[j+1, 2], vetor[j+1, 3], vetor[j+1, 4]) = (vetor[j+1, 0], vetor[j+1, 1], vetor[j+1, 2], vetor[j+1, 3], vetor[j+1, 4], vetor[j, 0], vetor[j, 1], vetor[j, 2], vetor[j, 3], vetor[j, 4]);
                        }
                    }
                }   
            }
        }

         static void Imprimir(object[,] vetor)
        {
            for (int i = 0; i < vetor.GetLength(0); i++)
            {
                for (int j = 0; j < vetor.GetLength(1); j++)
                {
                    System.Console.WriteLine(vetor[i,j] + " ");
                }
                System.Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            object[,] transacoes = new object[50, 5]
            {
                {"João Silva", 200.00, "15/09/2024", 12345, "Eletrônicos"},
                {"Maria Souza", 350.75, "10/10/2024", 67890, "Roupas"},
                {"Carlos Pereira", 75.30, "05/11/2024", 11122, "Livros"},
                {"Ana Lima", 200.00, "25/09/2024", 33344, "Brinquedos"},
                {"Paulo Almeida", 540.90, "18/08/2024", 55566, "Eletrônicos"},
                {"Clara Mendes", 99.99, "01/10/2024", 77788, "Cosméticos"},
                {"Rafael Costa", 430.00, "12/11/2024", 99900, "Eletrônicos"},
                {"Laura Ferreira", 150.25, "20/09/2024", 12347, "Roupas"},
                {"Marcos Dias", 200.00, "30/10/2024", 67892, "Livros"},
                {"Juliana Rocha", 310.80, "05/11/2024", 34567, "Brinquedos"},
                {"Lucas Nunes", 600.00, "15/08/2024", 78901, "Cosméticos"},
                {"Fernanda Gomes", 80.75, "22/09/2024", 22233, "Eletrônicos"},
                {"André Barbosa", 170.20, "03/11/2024", 44455, "Roupas"},
                {"Bianca Santos", 215.00, "10/09/2024", 66677, "Livros"},
                {"Otávio Mendes", 400.50, "17/11/2024", 88899, "Brinquedos"},
                {"Renata Costa", 135.90, "21/10/2024", 10101, "Cosméticos"},
                {"Gabriel Silva", 520.00, "02/09/2024", 23232, "Eletrônicos"},
                {"Amanda Ferreira", 300.75, "09/11/2024", 45454, "Roupas"},
                {"Ricardo Pinto", 199.99, "15/10/2024", 67676, "Livros"},
                {"Juliana Souza", 450.00, "25/09/2024", 89898, "Brinquedos"},
                {"Patrícia Lima", 95.30, "08/10/2024", 11223, "Cosméticos"},
                {"Gustavo Rocha", 410.25, "15/09/2024", 33445, "Eletrônicos"},
                {"Mariana Teixeira", 145.80, "20/10/2024", 55667, "Roupas"},
                {"Alberto Lima", 250.60, "12/11/2024", 77889, "Livros"},
                {"Camila Pereira", 380.50, "19/08/2024", 99001, "Brinquedos"},
                {"Daniel Nunes", 450.70, "23/09/2024", 12349, "Cosméticos"},
                {"Patrícia Lima", 670.00, "05/10/2024", 67894, "Eletrônicos"},
                {"Sandro Alves", 95.90, "10/11/2024", 34569, "Roupas"},
                {"Isabela Cardoso", 320.40, "08/09/2024", 78903, "Livros"},
                {"Eduardo Souza", 215.60, "12/10/2024", 22235, "Brinquedos"},
                {"Lívia Rocha", 190.00, "30/08/2024", 44457, "Cosméticos"},
                {"Fábio Oliveira", 340.30, "01/09/2024", 66679, "Eletrônicos"},
                {"Cristina Silva", 210.90, "18/10/2024", 88901, "Roupas"},
                {"Luiz Almeida", 405.25, "22/09/2024", 10103, "Livros"},
                {"Vanessa Rocha", 180.50, "09/10/2024", 23234, "Brinquedos"},
                {"Patrícia Lima", 490.00, "02/11/2024", 45456, "Cosméticos"},
                {"Adriana Costa", 300.25, "05/09/2024", 67678, "Eletrônicos"},
                {"Bruno Cardoso", 215.10, "12/10/2024", 89890, "Roupas"},
                {"Letícia Nunes", 400.75, "10/11/2024", 11225, "Livros"},
                {"Henrique Mendes", 220.80, "14/09/2024", 33447, "Brinquedos"},
                {"Roberta Costa", 330.00, "27/08/2024", 55669, "Cosméticos"},
                {"Marcelo Ferreira", 185.40, "03/10/2024", 77891, "Eletrônicos"},
                {"Helena Lima", 425.50, "11/11/2024", 99003, "Roupas"},
                {"Fernando Gomes", 240.60, "15/09/2024", 12351, "Livros"},
                {"Luísa Rocha", 150.20, "08/10/2024", 67896, "Brinquedos"},
                {"Rafaela Silva", 180.90, "02/09/2024", 34571, "Cosméticos"},
                {"Alex Mendes", 480.00, "05/10/2024", 78905, "Eletrônicos"},
                {"Bruna Almeida", 300.75, "14/11/2024", 22237, "Roupas"},
                {"Mário Dias", 215.90, "18/09/2024", 44459, "Livros"},
                {"Viviane Santos", 360.40, "22/10/2024", 66681, "Brinquedos"},
            };
            Ordernar(transacoes);
            // Imprimir(transacoes);
            // CalculaCategoria(transacoes);
            // MostrarClienteQueMaisComprou(transacoes);
            // BuscaCategoria("Livros", transacoes);

            System.Console.WriteLine("Esocolha uma opção:\n1 - Imprimir todas as transações\t2 - Calcular vendas por categoria\n3 - Cliente que mais comprou\t\t4 - Buscar transação por categoria\n5 - Top 5 Transações\t\t\t0 - Sair\n");
            string op = Console.ReadLine();
            while(op != "0")
            {
                switch (op)
                {
                    case "1":
                        Console.Clear();
                        Imprimir(transacoes);
                        System.Console.WriteLine("\n\nAperte qualquer tecla para voltar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        CalculaCategoria(transacoes);
                        System.Console.WriteLine("\n\nAperte qualquer tecla para voltar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        MostrarClienteQueMaisComprou(transacoes);
                        System.Console.WriteLine("\n\nAperte qualquer tecla para voltar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.Clear();
                        System.Console.WriteLine("\nCategorias: Brinquedos, Cosméticos, Eletrônicos, Livros e Roupas");
                        System.Console.Write("Informe uma categoria: ");
                        string categoria = Console.ReadLine();
                        BuscaCategoria(categoria, transacoes);
                        System.Console.WriteLine("\n\nAperte qualquer tecla para voltar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        Console.Clear();
                        System.Console.WriteLine($"\nAs 5 maiores compras são:\nR${transacoes[0, 1]:F2}\nR${transacoes[1, 1]:F2}\nR${transacoes[2, 1]:F2}\nR${transacoes[3, 1]:F2}\nR${transacoes[4, 1]:F2}");
                        System.Console.WriteLine("\n\nAperte qualquer tecla para voltar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                    System.Console.WriteLine("Informe um valor válido!\n\nAperte qualquer tecla para voltar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                System.Console.WriteLine("Esocolha uma opção:\n1 - Imprimir todas as transações\t2 - Calcular vendas por categoria\n3 - Cliente que mais comprou\t\t4 - Buscar transação por categoria\n5 - Top 5 Transações\t\t\t0 - Sair\n");
                op = Console.ReadLine();
            }
        }
    }
}
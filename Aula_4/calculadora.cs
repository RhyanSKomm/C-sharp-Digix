using System;

namespace Au
{
    class Proam{
        
        static void calc()
        {
            
            bool pg = true;
            while (pg == true)
            {
                
                
                System.Console.WriteLine("Bem vindo a simples calculadora! \nEscolha uma Operação \n1 - Adição \n2 - Subtração \n3- Multiplicação \n4 - Divisão \n5 - Sair \n");
                int op = int.Parse(Console.ReadLine());
                
                if (op == 5){
                    break;
                }else{
                    System.Console.WriteLine("Digite o primeiro número: ");
                    int n1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite o segundo número: ");
                    int n2 = int.Parse(Console.ReadLine());
                    
                    switch (op)
                    {
                        case 1:
                            System.Console.WriteLine($"{n1} + {n2} = {n1+n2}");
                            break;
                        case 2:
                            System.Console.WriteLine($"{n1} - {n2} = {n1-n2}");
                            break;
                        case 3:
                            System.Console.WriteLine($"{n1} * {n2} = {n1*n2}");
                            break;
                        case 4:
                            System.Console.WriteLine($"{n1} / {n2} = {n1/n2}");
                            break;
                    }
                }
            }
        }
    }
}
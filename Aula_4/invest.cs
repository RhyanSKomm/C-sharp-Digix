namespace Aula{

    internal class Progra{
        
        static void Main(string[] args)
        {
           double taxa = 1;

           System.Console.WriteLine("1 - Poupança \n2 - Renda Fixa \n3 - Ações");
           int invest = int.Parse(Console.ReadLine());
           
           System.Console.WriteLine("Digite o valor a ser investido");
           double valor = double.Parse(Console.ReadLine());
           
           System.Console.WriteLine("Por quantos anos? ");
           int anos = int.Parse(Console.ReadLine()); 
           
           switch(invest){
                case 1:
                    
                    for (int i = 1; anos != i-1; i++ ){
                        taxa += 0.03;
                    }
                    System.Console.WriteLine($"Rendimento = {valor * taxa:F0} ");
                    break;

                case 2:
                    
                    for (int i = 1; anos != i-1; i++ ){
                        taxa += 0.05;
                    }
                    System.Console.WriteLine($"Rendimento = {valor * taxa:F0} ");
                    break;

                case  3:
                    for (int i = 1; anos != i-1; i++ ){
                        if (i!=3){
                            taxa += 0.03;
                        }else{
                            taxa -= 0.05;
                        }
                        
                    }
                    System.Console.WriteLine($"Rendimento = {valor * taxa:F0} ");
                    break;
                    
                default:
                    System.Console.WriteLine("Informações Inválidas.");
                    break;
           }
        }
    }
}
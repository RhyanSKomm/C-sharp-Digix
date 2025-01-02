namespace Aula{

    internal class Progra{
        
        static void Main(string[] args)
        {
           System.Console.WriteLine("1 - Poupança \n2 - Renda Fixa \n3 - Ações");
           int invest = int.Parse(Console.ReadLine());
           
           System.Console.WriteLine("Digite o valor a ser investido");
           double valor = double.Parse(Console.ReadLine());
           
           System.Console.WriteLine("Por quantos anos? ");
           int anos = int.Parse(Console.ReadLine()); 
           
           switch(invest){
                case 1:
                    System.Console.WriteLine($"Rendimento = {((valor*0.03)*anos)+valor}");
                    
                    break;
                case 2:
                    System.Console.WriteLine($"Rendimento = {((valor*0.05)*anos)+valor}");
                    break;
                case  3:
                    System.Console.WriteLine($"Rendimento = {((valor*0.10)*anos)+valor}");
                    break;
                    
                default:
                    System.Console.WriteLine("Informações Inválidas.");
                    break;
           }
        }
    }
}
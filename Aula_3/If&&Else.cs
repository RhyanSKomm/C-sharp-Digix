namespace Au{

    internal class Pr{
        
        public static void If()
        {
            int idade = 15;
            
            if (idade >= 18 && idade <=50){
                System.Console.WriteLine("Adulto");
            }
            else if (idade > 50 && idade <= 100){
                System.Console.WriteLine("Idoso");
            }
            else if (idade>50){
                System.Console.WriteLine("Já Morreu");
            }
            else{
                System.Console.WriteLine("Criança");
            }    
        }
    }
}
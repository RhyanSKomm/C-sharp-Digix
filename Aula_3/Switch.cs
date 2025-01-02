namespace Aula_3{

    internal class Program{
        
        public static void  Switch()
        {
            int idade = 15;
            switch (idade)
            {
                case int n when n>= 17 && n<50:
                    System.Console.WriteLine("Adulto");
                    break;
                case int n when n>50 && n<=100:
                    System.Console.WriteLine("Idoso");
                    break;
                default:
                    System.Console.WriteLine("Criança");
                    break;
            }
        }
    }
}
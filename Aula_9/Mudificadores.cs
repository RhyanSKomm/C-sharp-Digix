namespace Aula_9
{
    
    public class Mudificadores
    {

        public int soma(int a, int b)
        {
            return a+b;
        }

        static int subtracao(int a, int b)
        {
            return a-b;
        }

        static void mud()
        {
            Mudificadores m = new Mudificadores();
            System.Console.WriteLine(m.soma(10,20));

            System.Console.WriteLine(subtracao(10,20));
        }
    }
}
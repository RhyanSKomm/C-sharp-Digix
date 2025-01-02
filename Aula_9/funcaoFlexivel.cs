namespace Aula_9
{
    
    public class Flexivel
    {

        public delegate int operacao(int a, int b);

        static int soma(int a, int b) => a + b;

        public delegate void notificar();
        public static void envioEmail() => System.Console.WriteLine("email enviado");
        public static void envioSMS() => System.Console.WriteLine("SMS enviado");
        static void ops()
        {
            operacao op = soma;
            System.Console.WriteLine(op(3,2));

            operacao op2 = (int a, int b) => a*b;
            System.Console.WriteLine(op2(3,2));

            // Func<int, int, int> op3 = delegate(int a, int b) {return args-b;};
            // System.Console.WriteLine(op3(3,2));


            notificar notificar = envioEmail;
            notificar += envioSMS;
            notificar();
        }
    }
}
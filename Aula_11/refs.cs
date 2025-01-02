namespace Name
{
    class Refs
    {

        static int Quadrado(int x)
        {
            return x*x;
        }

        static void QuadradoRef(ref int x)
        {
            x = x*x;
        }

        static int QuadradoOut(out int x)
        {
            x= 6;
            return x * x;
        }

        static void refs()
        {
            int a = 10;
            System.Console.WriteLine(Quadrado(a));
            System.Console.WriteLine(a);
            System.Console.WriteLine();
            QuadradoRef(ref a);
            System.Console.WriteLine(a);


        }

    }
}
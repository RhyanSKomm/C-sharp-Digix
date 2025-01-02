namespace areas
{
    class areas
    {
        static void Teste()
        {
            System.Console.WriteLine("Digite a Base: ");
            double b = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a Altura: ");
            double h = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o número de PI: ");
            double pi = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o Raio: ");            
            double r = double.Parse(Console.ReadLine());
            
            double aT = b * h / 2;
            double aQ = b * b;
            double aR = b * h;
            double aC = pi * (r * r);
            
            System.Console.WriteLine("Área de um triângulo: " + aT);
            System.Console.WriteLine("Área de um quadrado: " + aQ);
            System.Console.WriteLine("Área de um retângulo: " + aR);
            System.Console.WriteLine("Área de um círculo: " + aC);
        }
    }
}
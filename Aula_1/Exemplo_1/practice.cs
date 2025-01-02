using System;
namespace Exemplo
{
    internal class Tipos1
    {
        static void teste()
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            long n4 = 214748647L;
            float n5 = 5.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine($"{nome} do gênero {genero}, tem {n2} horas de curso C# feito pelp {obj1}");
        }
    }
}
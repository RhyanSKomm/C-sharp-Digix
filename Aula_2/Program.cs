using System;

namespace aula_2
{

    class Program
    {

        static void Teste()
        {
            int a = 20;
            int b = 3;
            int soma = a+b;
            System.Console.WriteLine(a + b);
            System.Console.WriteLine(a - b);
            System.Console.WriteLine(a * b);
            System.Console.WriteLine(a / b);
            System.Console.WriteLine(a * b);

            System.Console.WriteLine();
            
            int c = 10;
            int d = 5;
            c += d;
            c -= d;
            c *= d;
            c /= d;
            System.Console.WriteLine(c); 

            System.Console.WriteLine();

            int e = 10;
            int f = 4;
            System.Console.WriteLine(e == f);           
            System.Console.WriteLine(e != f);           
            System.Console.WriteLine(e < f);           
            System.Console.WriteLine(e > f);           
            System.Console.WriteLine(e <= f);           
            System.Console.WriteLine(e >= f);

            System.Console.WriteLine();

            bool g = true  ;         
            bool h = false;
            System.Console.WriteLine(g && h );          
            System.Console.WriteLine(g || h);          
            System.Console.WriteLine(!g);          

            System.Console.WriteLine();

            int i = 10;
            System.Console.WriteLine(i++);          
            System.Console.WriteLine(i);          
            System.Console.WriteLine(++i);                    
            System.Console.WriteLine(i--);          
            System.Console.WriteLine(i);          
            System.Console.WriteLine(--i);

            System.Console.WriteLine();

            int j = 10;          
            int k = 5;
            System.Console.WriteLine(i & k);
            System.Console.WriteLine(i | k);
            System.Console.WriteLine(i ^ k);
            System.Console.WriteLine(~i);
            System.Console.WriteLine(i << k);
            System.Console.WriteLine(i >> k);
        }
    }
}
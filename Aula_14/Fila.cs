namespace Name
{
    class Fila
    {
        static int[] fila = new int[10];

        static int inicio = 0;

        static int fim = 0;
        
        static int cout = 0;

        public static void Adicionar(int valor)
        {
            if (cout < fila.Length)
            {
                fila[fim] = valor;
                fim = (fim+1) % fila.Length;
                cout++;
            }
            else
            {
                System.Console.WriteLine("Fila cheia!");
            }
        }

        public static void Remover()
        {
            if (cout > 0)
            {
                fila[inicio] = 0;
                fim = (inicio+1) % fila.Length;
                cout--;
            }
            else
            {
                System.Console.WriteLine("Fila vazia!");
            }
        }
        
        public static void Mostrar()
        {
            for (int i = 0; i < cout; i++)
            {
                Console.WriteLine(fila[(inicio + i) % fila.Length]);
            }
        }

        //  Primeiro elemento da fila
        public static void Primeiro()
        {
            if (cout > 0)
            {
                Console.WriteLine(fila[inicio]);
            }
            else
            {
                Console.WriteLine("Fila vazia!");
            }
            System.Console.WriteLine();
        }

        public static void Maine(string[] args)
        {
            Adicionar(10);
            Adicionar(20);
            Adicionar(30);
            Adicionar(40);
            Adicionar(50);
            Adicionar(60);
            Primeiro();

            Mostrar();

            while (cout > 0)
            {
                Remover();
            }
        }
    }
}
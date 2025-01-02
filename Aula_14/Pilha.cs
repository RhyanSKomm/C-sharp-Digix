namespace Name
{
    class Pilha
    {
        static int[] pilha = new int[10];

        static int topo = 0;

        public static void Adicionar(int valor)
        {
            if (topo < pilha.Length)
            {
                pilha[topo] = valor;
                topo ++;
            }
            else
            {
                System.Console.WriteLine("Pilha cheia");
            }
        }

        static void Remover()
        {
            if (topo > 0)
            {
                topo--;
                pilha[topo] = 0;
            }
            else
            {
                System.Console.WriteLine("Pilha vazia");
            }
        }

        public static void Listar()
        {
            for (int i = topo - 1; i >= 0; i--)
            {
                System.Console.WriteLine(pilha[i]);
            }
            System.Console.WriteLine();
        }
        
        

        static void Maine(string[] args)
        {
            Adicionar(10);
            Adicionar(20);
            Adicionar(30);
            Adicionar(40);

            Listar();

            Remover();

            Listar();
        }
    }
}
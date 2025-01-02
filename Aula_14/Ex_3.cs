namespace Name
{
    class Ex_3
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

        static void VerificarTopo()
        {
            System.Console.WriteLine(pilha[topo - 1]);
        }
        
        static void Mainr(string[] args)
        {
            Adicionar(10);
            Adicionar(20);
            Adicionar(30);
            Adicionar(40);

            VerificarTopo();
        }
    }
}
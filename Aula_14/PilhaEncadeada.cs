namespace Name
{
    class PilhaEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        static Node? topo = null;

        static void Empilhar(int valor)
        {
            Node novonode = new Node { valor = valor, proximo = topo};

            topo = novonode;
        }

        static void Desempilhar()
        {
            if (topo == null)
            {
                System.Console.WriteLine("Pilha vazia");
                return;
            }

            System.Console.WriteLine($"Desempilhando {topo.valor}");
            topo = topo.proximo;
        }

        static void Listar()
        {
            if (topo == null)
            {
                System.Console.WriteLine("Pilha vazia");
                return;
            }
            System.Console.WriteLine("Listando a Pilha");
            Node? atual = topo;
            while (atual != null)   
            {
                System.Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static void Mainu(string[] args)
        {
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);
            Empilhar(40);

            Listar();

            Desempilhar();

            Listar();

            Desempilhar();

            Listar();
        }
    }
}
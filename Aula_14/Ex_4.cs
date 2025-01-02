namespace Name
{
    class Ex_4
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        static Node? topo = null;

        static void Empilhar(int valor)
        {
            // Cria um novo no com valor fornecido
            Node novoNode = new Node { valor = valor, proximo = topo };

            // Atualiza o topo do No
            topo = novoNode;
        }

        static void Reverter()
        {
            if (topo == null || topo.proximo == null)
            {
                return;
            }
            Node? anterior = null;
            Node? atual = topo;
            Node? proximo;
            
            while (atual != null)
            {
                proximo = atual.proximo;
                atual.proximo = anterior;
                anterior = atual;
                atual = proximo;
            }
            topo = anterior;
        }

        static void Listar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }
            System.Console.WriteLine("Listando a Pilha");
            Node? atual = topo;
            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

         static void Maihn()
        {
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);
            Listar();
            Reverter();
            Listar();


        }
    }
}
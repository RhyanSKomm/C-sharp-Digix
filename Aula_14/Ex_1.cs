namespace Name
{
    class Ex_1
    {
        class Node
        {
            public int valor;

            public Node? proximo;
        }

        static Node? inicio = null;

        public void Inserir(int valor, int posicao)
        {
            Node novoNode = new Node { valor = valor, proximo = null};

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                int i = 0;
                while (atual.proximo != null && i < posicao - 1)
                {
                    atual = atual.proximo;
                }
                novoNode.proximo = atual.proximo;
                atual.proximo = novoNode;
            }
        }

        public void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            Node? atual = inicio;
            Console.WriteLine("Elementos na lista:");

            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static void Maine()
        {
            Ex_1 lista = new Ex_1();

            // Insere valores na lista
            lista.Inserir(10,0);
            lista.Inserir(20,2);
            lista.Inserir(30,1);

            // Lista os valores da lista
            lista.Listar();

        }
    }
}
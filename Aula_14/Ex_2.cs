using Exemplo12ListPilhFilaENCADEADA;

namespace Name
{
    class Ex_2
    {
        class Node
        {
            public int valor;

            public Node? proximo;
        }

        static Node? inicio = null;

        public void Inserir(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while (atual.proximo != null)
                {
                    atual = atual.proximo;
                }
                atual.proximo = novoNode;
            }
        }

        public void Contem(int valor)
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            Node? atual = inicio;
            bool encontrado = false;


            while (atual != null)
            {
                if (atual.valor == valor)
                {
                    encontrado = true;
                    Console.WriteLine(encontrado);
                }
                    atual = atual.proximo;
            
            }
            if(!encontrado)
            {
                System.Console.WriteLine(encontrado);
            }
        }
        static void Mainr()
        {
            Ex_2 lista = new Ex_2();

            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Inserir(40);
            
            lista.Contem(21);
            
        }
    }
}
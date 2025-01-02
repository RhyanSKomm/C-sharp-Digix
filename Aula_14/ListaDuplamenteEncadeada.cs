using System.Diagnostics;

namespace Name
{
    class ListaDuplamenteEncadeada
    {
        class Node
        {
            public int valor;

            public Node? proximo;

            public Node? anterior;
        }

        static Node? inicio = null;

        static void Inserir(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = null, anterior = null};
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
                novoNode.anterior = atual;
            }
        }
        static void Excluir(int valor)
        {
            if (inicio == null)
            {
                return;
            }
            // if (inicio.valor == valor)
            // {
            //     inicio = inicio.proximo;
            //     inicio.anterior = null;
            //     return;
            // }
            if (inicio.valor == valor)
            {
                if (inicio.proximo != null)
                {
                    inicio.proximo.anterior = null;
                }
                inicio = inicio.proximo;
                return;
            }

            Node atual = inicio;
            while (atual != null && atual.valor != valor)
            {
                atual = atual.proximo;
            }

            if (atual != null)
            {
                if (atual.anterior != null)
                {
                    atual.anterior.proximo = atual.proximo;
                }
                if (atual.proximo != null)
                {
                    atual.proximo.anterior = atual.anterior;
                }
            }
        }
         static void RemoverRecorrenciaTodos(int valor)
        {
            Node? atual = inicio;

            while (atual != null)
            {
                // Caso o nó seja do inicio da lista
                if (atual.anterior == null)
                {
                    inicio = inicio.proximo;
                    if (inicio != null)
                    {
                        inicio.anterior = null;
                    }
                }

                // Caso o nó seja do fim da lista
                else if (atual.proximo == null)
                {
                    atual.anterior.proximo = null; // Remove o nó do fim, atual.anterior.proximo quer dizer que o nó anterior ao atual aponta para null
                }
                else 
                {
                    // Atualiza os ponteiros do nó anterior e do nó posterior
                    atual.anterior.proximo = atual.proximo;
                    atual.proximo.anterior = atual.anterior;
                }
            }

            // Avança para o próximo nó
            atual = atual.proximo;
        }
        
        static void Listar()
        {
            Node? atual = inicio;
            while (atual!= null)
            {
                System.Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }
        
        static void Maina(string[] args)
        {
            Inserir(10);
            Inserir(20);
            Inserir(30);
            Inserir(40);
            Inserir(50);
            Inserir(60);
            Inserir(70);
            
            Listar();
            System.Console.WriteLine();

            Excluir(20);
            Listar();
            
        }
    }
}
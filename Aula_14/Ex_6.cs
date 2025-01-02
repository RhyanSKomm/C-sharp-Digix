namespace Name
{
    class Ex_6
    {
        public class Fila
        {
            class Node
            {
                public int valor;
                public Node? proximo;
            }

            static Node? inicio = null;
            static Node? fim = null;

            static int contador = 0;

            // Enfileirar é acrescentar um elemento no final da fila
            static void Enfileirar(int valor)
            {
                // Cria um novo no com valor fornecido
                Node novoNode = new Node { valor = valor, proximo = null };

                // Se a fila estiver vazia, o novo nó é o início da fila
                if (inicio == null)
                {
                    inicio = novoNode;
                }
                else
                {
                    // Se a fila não estiver vazia, o novo nó é o próximo do último nó
                    fim!.proximo = novoNode; // fim!.proximo é seguro pois sabemos que fim não é nulo
                }

                // Atualiza o fim da fila
                fim = novoNode;

                // Incrementa o contador
                contador++;
            }

            public static void Tamanho()
            {
                System.Console.WriteLine(contador);
            }

            static void Maifn(string[] args)
            {
                Enfileirar(10);
                Enfileirar(20);
                Enfileirar(30);

                Tamanho();
            }
        }
    }
}
namespace Ex_5
{
    class Fila
    {
        class Node
        {
            public int Valor;      
            public Node? Proximo;
        }

        private Node? inicio = null;
        private Node? fim = null;

        public void Enfileirar(int valor)
        {
            Node novoNode = new Node { Valor = valor, Proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
                fim = novoNode;
            }
            else
            {
                fim.Proximo = novoNode;
                fim = novoNode;
            }
        }

        public int? Desenfileirar()
        {
            if (inicio == null)
            {
                Console.WriteLine("A fila está vazia!");
                return null;
            }

            int valor = inicio.Valor;
            inicio = inicio.Proximo;

            if (inicio == null)
                fim = null;

            return valor;
        }

        public void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("A fila está vazia!");
                return;
            }

            Console.WriteLine("Elementos na fila (do início ao fim):");
            Node? atual = inicio;
            while (atual != null)
            {
                Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }
        }

        public void InserirDeOutraFila(Fila outraFila)
        {
            while (outraFila.inicio != null)
            {
                int? valor = outraFila.Desenfileirar();
                if (valor.HasValue)
                {
                    Enfileirar(valor.Value);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Criando duas filas
            Fila fila1 = new Fila();
            Fila fila2 = new Fila();

            fila1.Enfileirar(10);
            fila1.Enfileirar(20);
            fila1.Enfileirar(30);

            Console.WriteLine("Fila 1 antes de adicionar elementos de Fila 2:");
            fila1.Listar();

            fila2.Enfileirar(40);
            fila2.Enfileirar(50);

            Console.WriteLine("Fila 2:");
            fila2.Listar();

            fila1.InserirDeOutraFila(fila2);

            Console.WriteLine("Fila 1 após adicionar elementos de Fila 2:");
            fila1.Listar();

            Console.WriteLine("Fila 2 após transferência:");
            fila2.Listar();
        }
    }
}
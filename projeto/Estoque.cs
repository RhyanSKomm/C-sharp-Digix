using System;

namespace Padaria
{
    public class Estoque
    {
        public Dictionary<Produto, int> EstoqueP { get; set; } = new Dictionary<Produto, int>(50);


        public void AdicionarProduto(Produto produto, int quantidade)
        {
            if (EstoqueP.ContainsKey(produto))
            {
                EstoqueP[produto] += quantidade;  // Se o produto já existir, soma a quantidade
            }
            else
            {
                EstoqueP.Add(produto, quantidade);  // Caso contrário, adiciona o produto com a quantidade
            }
        }

        public bool RemoverProduto(Produto produto, int quantidade)
    {
        // Verifica se o produto existe no EstoqueP
        if (EstoqueP.ContainsKey(produto))
        {
            // Verifica se há EstoqueP suficiente
            if (EstoqueP[produto] >= quantidade)
            {
                EstoqueP[produto] -= quantidade;

                // Se a quantidade do produto for zero ou negativa, remove o produto
                if (EstoqueP[produto] == 0)
                {
                    EstoqueP.Remove(produto);
                }

                return true;  // Produto foi removido corretamente
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente do produto no estoque.");
                return false;  // Quantidade insuficiente no estoque
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado no estoque.");
            return false;  // Produto não encontrado no estoque
        }
    }
        public void RemoverProduto(Produto produto)
        {
            EstoqueP.Remove(produto);
        }

    }
}
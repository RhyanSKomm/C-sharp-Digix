using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Padoca(string nome, List<Funcionario>? funcionarios = null, List<Cliente>? clientes = null, List<Fornecedor>? fornecedores = null)
    {
        public string Nome { get; set; } = nome;
        public List<Funcionario>? Funcionarios { get; set; } = funcionarios;
        public List<Cliente>? Clientes { get; set; } = clientes;
        public List<Fornecedor>? Fornecedores { get; set; } = fornecedores;
        public Estoque Estoque { get; set; } = new();

        public void AddFuncionario()
        {
            System.Console.WriteLine("Informe o tipo do funcionario (Gerente, Vendedor, Padeiro): ");
            string tipoFuncionario = Console.ReadLine().ToLower();
            
        }

        public void Venda(Vendedor vendedor, Cliente cliente, Produto produto, int quantidade)
        {
            if (Estoque.RemoverProduto(produto, quantidade))
            {
                double totalVenda = produto.PrecoFinal * quantidade;

                vendedor.MontanteVendas += totalVenda;
                cliente.TotalGasto += totalVenda;
            }
            else
            {
                Console.WriteLine("Venda não realizada: Produto ou quantidade insuficiente no estoque.");
            }

        }
        public void ConsultaEstoque()
        {
            if (Estoque.EstoqueP.Count == 0)
            {
                Console.WriteLine("O estoque está vazio.");
                return;
            }

            Console.WriteLine("Estoque atual:");

            // Itera sobre os produtos no dicionário e imprime as informações
            foreach (var item in Estoque.EstoqueP)
            {
                Produto produto = item.Key;
                int quantidade = item.Value;

                // Exibindo informações sobre o produto
                Console.WriteLine($"Código: {produto.Codigo}, Produto: {produto.Nome}, Preço: {produto.PrecoFinal:C}, Quantidade: {quantidade}");
            }
        }
        public void Menu()
        {
            int cont = 0;
            do
            {
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("1. Consultar Estoque"); //escrever qual é a funcao 1
                System.Console.WriteLine("2. Venda"); //escrever qual é a funcao 2
                System.Console.WriteLine("3. "); //escrever qual é a funcao 3
                System.Console.WriteLine("4. "); //escrever qual é a funcao 4
                System.Console.WriteLine("5.  ");//escrever qual é a funcao 5
                System.Console.WriteLine("6. "); //escrever qual é a funcao 6
                System.Console.WriteLine("7. "); //escrever qual é a funcao 7
                System.Console.WriteLine("8. "); //escrever qual é a funcao 8
                System.Console.WriteLine("0. Sair");
                cont = Convert.ToInt32(Console.ReadLine());
                if (cont == 1)
                {
                    //chamar a funcao 1
                    ConsultaEstoque();
                }
                else if (cont == 2)
                {
                    //chamar a funcao 2
                    System.Console.WriteLine("Informe o nome do vendedor: ");
                    string nomeVendedor = Console.ReadLine();
                    System.Console.WriteLine("Informe o nome do cliente: ");
                    string nomeCliente = Console.ReadLine();
                    System.Console.WriteLine("Informe o código do produto: ");
                    string codigo = Console.ReadLine();
                    System.Console.WriteLine("Informe a quantidade do produto: ");
                    int quantidade = Convert.ToInt32(Console.ReadLine());
                    Vendedor vendedor = (Vendedor)Funcionarios.FirstOrDefault(f => f.Nome == nomeVendedor);
                    Cliente cliente = (Cliente)Clientes.FirstOrDefault(c => c.Nome == nomeCliente);
                    Produto produto = (Produto)Estoque.EstoqueP.FirstOrDefault(p => p.Key.Codigo == codigo).Key;
                    Venda(vendedor, cliente, produto, quantidade);
                }
                else if (cont == 3)
                {
                    //chamar a funcao 3
                }
                else if (cont == 4)
                {
                    //chamar a funcao 4
                }
                else if (cont == 5)
                {
                    //chamar a funcao 5
                }
                else if (cont == 6)
                {
                    //chamar a funcao 6
                }
                else if (cont == 7)
                {
                    //chamar a funcao 7
                }
                else if (cont == 8)
                {
                    //chamar a funcao 8
                }

            } while (cont > 0);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Aula_21_OO.Desafio_3;
using Correção_Projeto;

namespace Aula_21_OO
{
    public class Executar
    {
        public static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            Estoque estoque = new Estoque();

            int opcao;

            do
            {
                
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Cadastrar Venda");
                Console.WriteLine("4 - Consultar Estoque");
                Console.WriteLine("5 - Gerar Relatório de Funcionarios");
                Console.WriteLine("6 - Sair");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente(clientes);
                        break;
                    case 2:
                        CadastrarProduto(produtos, estoque);
                        break;
                    case 3:
                        RegistrarVenda(clientes, produtos, vendas);
                        break;
                    case 4:
                        ConsultarEstoque(estoque);
                        break;
                    case 5:
                        GerarRelatorioVendas(vendas);
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 6);
        }

        

        public static void CadastrarCliente(List<Cliente> clientes)
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do cliente: ");
            int cpf = int.Parse(Console.ReadLine());
            Console.Write("Digite o Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Digite o Endereço: (Rua, Cidade, Estado, CEP)");
            string endereco = Console.ReadLine();
            
            System.Console.WriteLine("Digite o Estado: ");
            string estado = Console.ReadLine();

            if(!Enum.TryParse(estado, out Estado estadoEnum))
            {
                Console.WriteLine("Estado inválido");
                return;
            }

            Cliente cliente = new ClienteGold
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(", ")[0],
                    Cidade = endereco.Split(", ")[1],
                    Estado = estadoEnum,
                    CEP = int.Parse(endereco.Split(", ")[2])
                }
            };
        }

        private static void CadastrarProduto(List<Produto> produtos, Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("=== Cadastro de Produto ===");
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço de custo: ");
            double PrecoCusto = double.Parse(Console.ReadLine());
            Console.Write("Digite se é perecivel: ");
            bool perecivel = bool.Parse(Console.ReadLine());
            Console.Write("Digite o preço final: ");
            double precoFinal = double.Parse(Console.ReadLine());
            Console.Write("Digite a data de validade: ");
            DateTime dataValidade = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("=== Cadastro do Forncedor ===");
            System.Console.WriteLine("Digite o nome do fornecedor: ");
            string nomeFornecedor = Console.ReadLine();
            System.Console.WriteLine("Digite o endereço: ");
            Console.Write("Digite o Endereço: (Rua, Cidade, Bairro, Cidade, Estado)");
            string endereco = Console.ReadLine();
            System.Console.WriteLine("Digite o CNPJ: ");
            int cnpj = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite se o fornecedor é recorrente: ");
            bool recorrente = bool.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o desconto: ");
            double desconto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Estado: ");
            string estado = Console.ReadLine();

            if(!Enum.TryParse(estado, out Estado estadoEnum))
            {
                Console.WriteLine("Estado inválido");
                return;
            }


            string apelidoEstado = ApelidosPorEstado[estadoEnum];

            Fornecedor fornecedor = new Fornecedor
            {
                Nome = nomeFornecedor,
                CNPJ = cnpj,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(", ")[0],
                    Cidade = endereco.Split(", ")[1],
                    Estado = estadoEnum,
                    CEP = int.Parse(endereco.Split(", ")[2])
                }
            };

            Produto produto = new Produto
            {
                Nome = nome,
                Codigo = codigo,
                PrecoCusto = PrecoCusto,
                Apelido = apelidoEstado,
                Perecivel = perecivel,
                PrecoFinal = precoFinal,
                DataValidade = dataValidade,
                Fornecedor = fornecedor
            };

            produtos.Add(produto);
            estoque.Produtos = produtos.ToArray();
            System.Console.WriteLine("Produto cadastrado com sucesso!");

        }
         private static void RegistrarVenda(List<Cliente> clientes, List<Produto> produtos, List<Venda> vendas)
         {
            Console.Clear();
            Console.WriteLine("=== Cadastro de Venda ===");
            Console.Write("Digite o CPF: ");
            int cpf = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.CPF == cpf);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado");
                return;
            }
            
            List<Produto> produtosVenda = new List<Produto>();
            while (true)
            {
                Console.Write("Digite o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 0)
                {
                    break;
                }

                Produto produto = produtos.Find(p => p.Codigo == codigo);
                
                if (produto != null)
                {
                    produtosVenda.Add(produto);
                }
                else
                {
                    Console.WriteLine("Produto não encontrado");
                }
            }

            Venda venda = new Venda
            {
                Cliente = cliente,
                Produtos = produtosVenda.ToArray(),
                Data = DateTime.Now,
                FormaPagamento = "Cartão",
                Parcelas = 3,
            };

            venda.ValorTotal = venda.CalcularValorFinal();

            vendas.Add(venda);
            Console.WriteLine("Venda registrada com sucesso!");
         }

         private static void ConsultarEstoque(Estoque estoque)
         {
            Console.Clear();
            Console.WriteLine("=== Consulta de Estoque ===");
            Console.Write("Digite o codigo do produto: ");
            if (estoque.Produtos != null)
            {
                for (int i = 0; i < estoque.Produtos.Length; i++)
                {
                    Console.WriteLine($"Código: {estoque.Produtos[i].Codigo} - Nome: {estoque.Produtos[i].Nome} - Quantidade: {estoque.Quantidades[i]}");
                }
            }
            else
            {
                Console.WriteLine("Estoque vazio");
            }
         }

        private static void GerarRelatorioVendas(List<Venda> vendas)
        {
            Console.Clear();
            Console.WriteLine("=== Relatório de Vendas ===");
            if(vendas != null)
            {
                foreach (var venda in vendas)
                {
                    Console.WriteLine($"Cliente: {venda.Cliente.Nome} - Data: {venda.Data} - Valor: {venda.ValorTotal}");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma venda registrada");
            }
        }

        private static Dictionary<Estado, string> ApelidosPorEstado = new Dictionary<Estado, string>
        {
            {Estado.SP, "Chipa"},
            {Estado.MS, "Chipa"},
            {Estado.MG, "Pão de Queijo"},
            {Estado.RJ, "Bixcoito"},
            {Estado.BA, "Acarajé"}
        };
    }
}
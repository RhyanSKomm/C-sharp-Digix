using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes_Exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Estado estado = new Estado("Mato Grosso do Sul","MS");
            Cidade cidade = new Cidade("Campo Grande",estado);
            Endereco endereco = new Endereco("R. Spipe Calarge",271,"Jardim Tv Morena","79050-261",cidade);
            Funcionario funcionario = new Funcionario("Rhyan",DateTime.Now,"12334556723",endereco);
            EquipeVenda equipeVenda = new EquipeVenda("Jovem Aprendiz");
            Vendedor vendedor = new Vendedor("Rhyan", DateTime.Now,"12334556723",endereco, equipeVenda);
            Gerente gerente = new Gerente("Rhyan", DateTime.Now,"12334556723",endereco);

            funcionario.GetNome();
            funcionario.GetNascimento();
            funcionario.GetCpf();            
        }
    }
}
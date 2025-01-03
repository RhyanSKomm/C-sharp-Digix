using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Correção
{
    public abstract class Funcionario : IRelatorio
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario(string nome, Endereco endereco, string cpf, string telefone, double salarioBase)
        {
            Nome = nome;
            Endereco = endereco;
            CPF = cpf;
            Telefone = telefone;
            SalarioBase = salarioBase;
        }

        public abstract double CalcularSalario();

        public abstract void GerarRelatorio();
    }

    public class Gerente : Funcionario
    {
        public double Bonus { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase * 1.2;
        }

        public void CalcularGratificacao()
        {
            System.Console.WriteLine("Foi calculado a gratificação do gerente");
        }

        public override void GerarRelatorio()
        {
            System.Console.WriteLine("Gerente: " + Nome);
            Console.WriteLine("Salário: " + CalcularSalario());
        }
    }

    public class Vendedor : Funcionario
    {
        public double VendasRealizadas { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase * 1.1;
        }

        public void CalcularBonus()
        {
            System.Console.WriteLine("Foi calculado o bônus do vendedor");
        }

        public override void GerarRelatorio()
        {
            System.Console.WriteLine("Vendedor: " + Nome);
            Console.WriteLine("Salário: " + CalcularSalario());
        }
    }

    public class Padeiro : Funcionario
    {
        public double HorasNoturnasTrabalhadas { get; set; }

        public override double CalcularSalario()
        {
            double adicionalNoturno = HorasNoturnasTrabalhadas * (SalarioBase * 0.25/160);
        }

        public void CalcularPaozinho()
        {
            System.Console.WriteLine("Foi calculado as horas do padeiro");
        }

        public override void GerarRelatorio()
        {
            System.Console.WriteLine("Padeiro: " + Nome);
            Console.WriteLine("Salário: " + CalcularSalario());
        }
    }
}